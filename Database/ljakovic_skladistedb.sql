--
-- PostgreSQL database dump
--

-- Dumped from database version 13.1
-- Dumped by pg_dump version 13.1

-- Started on 2021-02-07 17:15:41

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 233 (class 1255 OID 24977)
-- Name: stavke_otpremnice_dodaj(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.stavke_otpremnice_dodaj() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
		DECLARE
			otp_kol INT;
		BEGIN
			otp_kol = OLD."Kol";

			UPDATE "Oprema" SET "Kol" = "Kol" + otp_kol WHERE "OpremaId" = OLD."OpremaId";
			RETURN NULL;
		END
	$$;


ALTER FUNCTION public.stavke_otpremnice_dodaj() OWNER TO postgres;

--
-- TOC entry 219 (class 1255 OID 24970)
-- Name: stavke_otpremnice_kol(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.stavke_otpremnice_kol() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
		DECLARE
			otp_kol INT;
			op_kol INT;
		BEGIN
			otp_kol = NEW."Kol";
			
			op_kol :=(
				SELECT "Kol"
				FROM "Oprema"
				WHERE "OpremaId" = NEW."OpremaId"
			);
			
			IF(op_kol < otp_kol) THEN 
				RAISE exception 'Premala kolicina u skladistu zeljene opreme.';
			ELSE RETURN NEW;
			END IF;
			RETURN NULL;
		END
	$$;


ALTER FUNCTION public.stavke_otpremnice_kol() OWNER TO postgres;

--
-- TOC entry 220 (class 1255 OID 25017)
-- Name: stavke_otpremnice_kol_manja_min(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.stavke_otpremnice_kol_manja_min() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
		DECLARE
			op_min_kol INT;
			op_kol INT;
		BEGIN
			op_min_kol :=(
				SELECT "MinKol"
				FROM "Oprema"
				WHERE "OpremaId" = NEW."OpremaId"
			);
			
			op_kol :=(
				SELECT "Kol"
				FROM "Oprema"
				WHERE "OpremaId" = NEW."OpremaId"
			);
			
			IF(op_kol < op_min_kol) THEN 
				RAISE exception 'Premala kolicina u skladistu zeljene opreme, narudzbenica je kreirana.';
			ELSE RETURN NEW;
			END IF;
			RETURN NULL;
		END
	$$;


ALTER FUNCTION public.stavke_otpremnice_kol_manja_min() OWNER TO postgres;

--
-- TOC entry 236 (class 1255 OID 25009)
-- Name: stavke_otpremnice_max_kol(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.stavke_otpremnice_max_kol() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
    DECLARE
        otp_kol INT;
		op_kol INT;
		op_max_kol INT;
    BEGIN
        otp_kol = OlD."Kol";

        op_kol := (
            SELECT "Kol"
            FROM "Oprema"
            WHERE "OpremaId" = OLD."OpremaId"
        );

        op_max_kol := (
            SELECT "MaxKol"
            FROM "Oprema"
            WHERE "OpremaId" = OLD."OpremaId"
        );
        IF((otp_kol + op_kol) > op_max_kol) THEN
            RAISE exception 'Nije moguce obrisati stavku otpremnice zbog maksimalne kolicine.';
		ELSE RETURN OLD;
        END IF;
        RETURN NULL;
    END
	$$;


ALTER FUNCTION public.stavke_otpremnice_max_kol() OWNER TO postgres;

--
-- TOC entry 234 (class 1255 OID 24973)
-- Name: stavke_otpremnice_min_kol(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.stavke_otpremnice_min_kol() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
	DECLARE
		otp_kol INT;
		op_kol INT;
		op_min_kol INT;
		nova_narudzbenica INT;
		op_id INT;
	BEGIN
		otp_kol = NEW."Kol";

		op_kol :=(
			SELECT "Kol"
			FROM "Oprema"
			WHERE "OpremaId" = NEW."OpremaId"
		);

		op_min_kol :=(
			SELECT "MinKol"
			FROM "Oprema"
			WHERE "OpremaId" = NEW."OpremaId"
		);

		IF ((op_kol - otp_kol) < op_min_kol) THEN
			INSERT INTO "Narudzbenica"("DatumKreiranja") VALUES (CURRENT_TIMESTAMP);

			nova_narudzbenica := (
				SELECT "NarudzbenicaId"
				FROM "Narudzbenica"
				ORDER BY "NarudzbenicaId"
				DESC
				LIMIT 1
			);

			op_id := (
				SELECT "OpremaId"
				FROM "Oprema"
				WHERE "OpremaId" = NEW."OpremaId"
			);

			INSERT INTO "StavkaNarudzbenice"("NarudzbenicaId", "OpremaId", "Kol") VALUES (nova_narudzbenica, op_id, op_min_kol);
			RAISE notice 'Kreirana je nova narudzbenica jer je kolicina presla granicu minimalne.';
		END IF;
		RETURN NEW;
	END
	$$;


ALTER FUNCTION public.stavke_otpremnice_min_kol() OWNER TO postgres;

--
-- TOC entry 217 (class 1255 OID 24975)
-- Name: stavke_otpremnice_oduzmi(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.stavke_otpremnice_oduzmi() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
		DECLARE
			otp_kol INT;
		BEGIN
			otp_kol = NEW."Kol";

			UPDATE "Oprema" SET "Kol" = "Kol" - otp_kol WHERE "OpremaId" = NEW."OpremaId";
			RETURN NEW;
		END
	$$;


ALTER FUNCTION public.stavke_otpremnice_oduzmi() OWNER TO postgres;

--
-- TOC entry 216 (class 1255 OID 24980)
-- Name: stavke_primke_dodaj(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.stavke_primke_dodaj() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
		DECLARE
			prim_kol INT;
		BEGIN
			prim_kol = NEW."Kol";
			
			UPDATE "Oprema" SET "Kol" = "Kol" + prim_kol WHERE "OpremaId" = NEW."OpremaId";
			RETURN NEW;
		END
	$$;


ALTER FUNCTION public.stavke_primke_dodaj() OWNER TO postgres;

--
-- TOC entry 232 (class 1255 OID 24989)
-- Name: stavke_primke_max_kol(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.stavke_primke_max_kol() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
		DECLARE
			prim_kol INT;
			op_kol INT;
			op_max_kol INT;
		BEGIN
			prim_kol = NEW."Kol";
			
			op_kol :=(
				SELECT "Kol"
				FROM "Oprema"
				WHERE "OpremaId" = NEW."OpremaId"
			);
			
			op_max_kol :=(
			SELECT "MaxKol"
			FROM "Oprema"
			WHERE "OpremaId" = NEW."OpremaId"
			);
			
			IF((prim_kol + op_kol) > op_max_kol) THEN
				RAISE exception 'Nova kolicina odabrane opreme prelazi granicu maksimalne kolicine.';
			ELSE RETURN NEW;
			END IF;
			RETURN NULL;
		END
	$$;


ALTER FUNCTION public.stavke_primke_max_kol() OWNER TO postgres;

--
-- TOC entry 235 (class 1255 OID 25015)
-- Name: stavke_primke_min_kol(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.stavke_primke_min_kol() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
	DECLARE
		prim_kol INT;
		op_kol INT;
		op_min_kol INT;
	BEGIN
		prim_kol = OLD."Kol";

		op_kol := (
			SELECT "Kol"
			FROM "Oprema"
			WHERE "OpremaId" = OLD."OpremaId"
		);

		op_min_kol := (
			SELECT "MinKol"
			FROM "Oprema"
			WHERE "OpremaId" = OLD."OpremaId"
		);

		IF((op_kol-prim_kol) < op_min_kol) THEN
			RAISE EXCEPTION 'Nije moguce obrisati stavku primke jer bi kolicina bila manja od dozvoljene.';
		ELSE RETURN OLD;
		END IF;
		RETURN NULL;
	END
	$$;


ALTER FUNCTION public.stavke_primke_min_kol() OWNER TO postgres;

--
-- TOC entry 218 (class 1255 OID 24982)
-- Name: stavke_primke_oduzmi(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.stavke_primke_oduzmi() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
		DECLARE
			prim_kol INT;
		BEGIN
			prim_kol = OLD."Kol";

			UPDATE "Oprema" SET "Kol" = "Kol" - prim_kol WHERE "OpremaId" = OLD."OpremaId";
			RETURN NULL;
		END
	$$;


ALTER FUNCTION public.stavke_primke_oduzmi() OWNER TO postgres;

--
-- TOC entry 215 (class 1255 OID 24956)
-- Name: zaposlenik_otkaz(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.zaposlenik_otkaz() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
			BEGIN
				INSERT INTO
				"Zaposlenik" ("ZaposlenikId", "Ime", "Prezime", "KorIme", "Lozinka", "DatumZavrsetka") 
				VALUES (OLD."ZaposlenikId", OLD."Ime", OLD."Prezime", OLD."KorIme", OLD."Lozinka", CURRENT_TIMESTAMP);
				RETURN OLD;
			END;
		$$;


ALTER FUNCTION public.zaposlenik_otkaz() OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 213 (class 1259 OID 24929)
-- Name: Narudzbenica; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Narudzbenica" (
    "NarudzbenicaId" integer NOT NULL,
    "DatumKreiranja" timestamp without time zone,
    "ZaposlenikId" integer
);


ALTER TABLE public."Narudzbenica" OWNER TO postgres;

--
-- TOC entry 212 (class 1259 OID 24927)
-- Name: Narudzbenica_NarudzbenicaId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Narudzbenica_NarudzbenicaId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Narudzbenica_NarudzbenicaId_seq" OWNER TO postgres;

--
-- TOC entry 3102 (class 0 OID 0)
-- Dependencies: 212
-- Name: Narudzbenica_NarudzbenicaId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Narudzbenica_NarudzbenicaId_seq" OWNED BY public."Narudzbenica"."NarudzbenicaId";


--
-- TOC entry 203 (class 1259 OID 24843)
-- Name: Oprema; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Oprema" (
    "OpremaId" integer NOT NULL,
    "Naziv" text,
    "MinKol" integer,
    "MaxKol" integer,
    "Kol" integer,
    "JedCijena" real,
    "VrstaOpremeId" integer
);


ALTER TABLE public."Oprema" OWNER TO postgres;

--
-- TOC entry 202 (class 1259 OID 24841)
-- Name: Oprema_OpremaId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Oprema_OpremaId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Oprema_OpremaId_seq" OWNER TO postgres;

--
-- TOC entry 3103 (class 0 OID 0)
-- Dependencies: 202
-- Name: Oprema_OpremaId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Oprema_OpremaId_seq" OWNED BY public."Oprema"."OpremaId";


--
-- TOC entry 210 (class 1259 OID 24898)
-- Name: Otpremnica; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Otpremnica" (
    "OtpremnicaId" integer NOT NULL,
    "AdresaDostave" text,
    "DatumKreiranja" timestamp without time zone,
    "ZaposlenikId" integer
);


ALTER TABLE public."Otpremnica" OWNER TO postgres;

--
-- TOC entry 209 (class 1259 OID 24896)
-- Name: Otpremnica_OtpremnicaId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Otpremnica_OtpremnicaId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Otpremnica_OtpremnicaId_seq" OWNER TO postgres;

--
-- TOC entry 3104 (class 0 OID 0)
-- Dependencies: 209
-- Name: Otpremnica_OtpremnicaId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Otpremnica_OtpremnicaId_seq" OWNED BY public."Otpremnica"."OtpremnicaId";


--
-- TOC entry 207 (class 1259 OID 24870)
-- Name: Primka; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Primka" (
    "PrimkaId" integer NOT NULL,
    "DatumKreiranja" timestamp without time zone,
    "ZaposlenikId" integer
);


ALTER TABLE public."Primka" OWNER TO postgres;

--
-- TOC entry 206 (class 1259 OID 24868)
-- Name: Primka_PrimkaId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Primka_PrimkaId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Primka_PrimkaId_seq" OWNER TO postgres;

--
-- TOC entry 3105 (class 0 OID 0)
-- Dependencies: 206
-- Name: Primka_PrimkaId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Primka_PrimkaId_seq" OWNED BY public."Primka"."PrimkaId";


--
-- TOC entry 214 (class 1259 OID 24940)
-- Name: StavkaNarudzbenice; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."StavkaNarudzbenice" (
    "NarudzbenicaId" integer NOT NULL,
    "OpremaId" integer NOT NULL,
    "Kol" integer
);


ALTER TABLE public."StavkaNarudzbenice" OWNER TO postgres;

--
-- TOC entry 211 (class 1259 OID 24912)
-- Name: StavkaOtpremnice; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."StavkaOtpremnice" (
    "OtpremnicaId" integer NOT NULL,
    "OpremaId" integer NOT NULL,
    "Kol" integer
);


ALTER TABLE public."StavkaOtpremnice" OWNER TO postgres;

--
-- TOC entry 208 (class 1259 OID 24881)
-- Name: StavkaPrimke; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."StavkaPrimke" (
    "PrimkaId" integer NOT NULL,
    "OpremaId" integer NOT NULL,
    "Kol" integer
);


ALTER TABLE public."StavkaPrimke" OWNER TO postgres;

--
-- TOC entry 201 (class 1259 OID 24832)
-- Name: VrstaOpreme; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."VrstaOpreme" (
    "VrstaOpremeId" integer NOT NULL,
    "Naziv" text
);


ALTER TABLE public."VrstaOpreme" OWNER TO postgres;

--
-- TOC entry 200 (class 1259 OID 24830)
-- Name: VrstaOpreme_VrstaOpremeId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."VrstaOpreme_VrstaOpremeId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."VrstaOpreme_VrstaOpremeId_seq" OWNER TO postgres;

--
-- TOC entry 3106 (class 0 OID 0)
-- Dependencies: 200
-- Name: VrstaOpreme_VrstaOpremeId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."VrstaOpreme_VrstaOpremeId_seq" OWNED BY public."VrstaOpreme"."VrstaOpremeId";


--
-- TOC entry 205 (class 1259 OID 24859)
-- Name: Zaposlenik; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Zaposlenik" (
    "ZaposlenikId" integer NOT NULL,
    "Ime" text,
    "Prezime" text,
    "KorIme" text,
    "Lozinka" text,
    "DatumZavrsetka" timestamp without time zone
);


ALTER TABLE public."Zaposlenik" OWNER TO postgres;

--
-- TOC entry 204 (class 1259 OID 24857)
-- Name: Zaposlenik_ZaposlenikId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Zaposlenik_ZaposlenikId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Zaposlenik_ZaposlenikId_seq" OWNER TO postgres;

--
-- TOC entry 3107 (class 0 OID 0)
-- Dependencies: 204
-- Name: Zaposlenik_ZaposlenikId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Zaposlenik_ZaposlenikId_seq" OWNED BY public."Zaposlenik"."ZaposlenikId";


--
-- TOC entry 2912 (class 2604 OID 24932)
-- Name: Narudzbenica NarudzbenicaId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Narudzbenica" ALTER COLUMN "NarudzbenicaId" SET DEFAULT nextval('public."Narudzbenica_NarudzbenicaId_seq"'::regclass);


--
-- TOC entry 2908 (class 2604 OID 24846)
-- Name: Oprema OpremaId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Oprema" ALTER COLUMN "OpremaId" SET DEFAULT nextval('public."Oprema_OpremaId_seq"'::regclass);


--
-- TOC entry 2911 (class 2604 OID 24901)
-- Name: Otpremnica OtpremnicaId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Otpremnica" ALTER COLUMN "OtpremnicaId" SET DEFAULT nextval('public."Otpremnica_OtpremnicaId_seq"'::regclass);


--
-- TOC entry 2910 (class 2604 OID 24873)
-- Name: Primka PrimkaId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Primka" ALTER COLUMN "PrimkaId" SET DEFAULT nextval('public."Primka_PrimkaId_seq"'::regclass);


--
-- TOC entry 2907 (class 2604 OID 24835)
-- Name: VrstaOpreme VrstaOpremeId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."VrstaOpreme" ALTER COLUMN "VrstaOpremeId" SET DEFAULT nextval('public."VrstaOpreme_VrstaOpremeId_seq"'::regclass);


--
-- TOC entry 2909 (class 2604 OID 24862)
-- Name: Zaposlenik ZaposlenikId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Zaposlenik" ALTER COLUMN "ZaposlenikId" SET DEFAULT nextval('public."Zaposlenik_ZaposlenikId_seq"'::regclass);


--
-- TOC entry 3095 (class 0 OID 24929)
-- Dependencies: 213
-- Data for Name: Narudzbenica; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Narudzbenica" ("NarudzbenicaId", "DatumKreiranja", "ZaposlenikId") FROM stdin;
1	2021-02-03 18:22:47.081373	1
3	2021-02-03 20:05:05.754893	12
15	2021-02-06 19:12:50.695025	\N
\.


--
-- TOC entry 3085 (class 0 OID 24843)
-- Dependencies: 203
-- Data for Name: Oprema; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Oprema" ("OpremaId", "Naziv", "MinKol", "MaxKol", "Kol", "JedCijena", "VrstaOpremeId") FROM stdin;
1	Speedlink Miš	5	20	4	149.99	5
3	Lenovo Legion	5	50	25	7999.99	2
4	Redragon Tipkovnica	10	50	20	199.99	4
\.


--
-- TOC entry 3092 (class 0 OID 24898)
-- Dependencies: 210
-- Data for Name: Otpremnica; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Otpremnica" ("OtpremnicaId", "AdresaDostave", "DatumKreiranja", "ZaposlenikId") FROM stdin;
6	Ul. S. Radića 2a, Zagreb	2021-02-03 15:52:22.939342	2
8	Trg kralja Zvonimira 1a, Zadar	2021-02-03 15:52:22.939342	2
7	Ul. M. Marulića 68, Rijeka	2021-02-03 15:52:22.939342	12
1	Kralja Tomislava 16, Zagreb	2021-02-03 15:10:25.318339	13
11	Gorička 55, Virje	2021-02-03 16:57:43.838806	13
13	Trg slobode 7, Koprivnica	2021-02-06 19:12:21.679622	13
\.


--
-- TOC entry 3089 (class 0 OID 24870)
-- Dependencies: 207
-- Data for Name: Primka; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Primka" ("PrimkaId", "DatumKreiranja", "ZaposlenikId") FROM stdin;
4	2021-02-03 18:09:49.815309	13
5	2021-02-03 18:09:56.04249	2
6	2021-02-03 18:10:08.492633	10
\.


--
-- TOC entry 3096 (class 0 OID 24940)
-- Dependencies: 214
-- Data for Name: StavkaNarudzbenice; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."StavkaNarudzbenice" ("NarudzbenicaId", "OpremaId", "Kol") FROM stdin;
3	1	5
15	1	5
\.


--
-- TOC entry 3093 (class 0 OID 24912)
-- Dependencies: 211
-- Data for Name: StavkaOtpremnice; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."StavkaOtpremnice" ("OtpremnicaId", "OpremaId", "Kol") FROM stdin;
11	1	4
13	1	16
1	1	16
\.


--
-- TOC entry 3090 (class 0 OID 24881)
-- Dependencies: 208
-- Data for Name: StavkaPrimke; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."StavkaPrimke" ("PrimkaId", "OpremaId", "Kol") FROM stdin;
6	3	25
5	4	20
6	1	7
\.


--
-- TOC entry 3083 (class 0 OID 24832)
-- Dependencies: 201
-- Data for Name: VrstaOpreme; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."VrstaOpreme" ("VrstaOpremeId", "Naziv") FROM stdin;
1	stolno računalo
2	prijenosno računalo
3	monitor
4	tipkovnica
5	miš
6	slušalice
7	zvučnici
\.


--
-- TOC entry 3087 (class 0 OID 24859)
-- Dependencies: 205
-- Data for Name: Zaposlenik; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Zaposlenik" ("ZaposlenikId", "Ime", "Prezime", "KorIme", "Lozinka", "DatumZavrsetka") FROM stdin;
2	Ivo	Ivic	iivic	lozinka	2021-02-02 17:45:13.419359
9	Pero	Peric	pperic	lozinka1	\N
10	Marko	Markic	mmarkic	lozinka2	\N
12	Duro	Duric	dduric	lozinka3	\N
11	Iva	Ivic	iivic1	lozinkaivic	2021-02-03 14:36:08.685319
13	Luka	Jakovic	ljakovic	lozinka	\N
1	Luka	Jakovic	ljakovic	lozinka	2021-02-03 16:52:58.075968
14	Luka	Jakovic	ljakovic	lozinka	2021-02-03 16:57:16.098818
\.


--
-- TOC entry 3108 (class 0 OID 0)
-- Dependencies: 212
-- Name: Narudzbenica_NarudzbenicaId_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Narudzbenica_NarudzbenicaId_seq"', 16, true);


--
-- TOC entry 3109 (class 0 OID 0)
-- Dependencies: 202
-- Name: Oprema_OpremaId_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Oprema_OpremaId_seq"', 4, true);


--
-- TOC entry 3110 (class 0 OID 0)
-- Dependencies: 209
-- Name: Otpremnica_OtpremnicaId_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Otpremnica_OtpremnicaId_seq"', 13, true);


--
-- TOC entry 3111 (class 0 OID 0)
-- Dependencies: 206
-- Name: Primka_PrimkaId_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Primka_PrimkaId_seq"', 10, true);


--
-- TOC entry 3112 (class 0 OID 0)
-- Dependencies: 200
-- Name: VrstaOpreme_VrstaOpremeId_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."VrstaOpreme_VrstaOpremeId_seq"', 7, true);


--
-- TOC entry 3113 (class 0 OID 0)
-- Dependencies: 204
-- Name: Zaposlenik_ZaposlenikId_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Zaposlenik_ZaposlenikId_seq"', 14, true);


--
-- TOC entry 2928 (class 2606 OID 24934)
-- Name: Narudzbenica Narudzbenica_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Narudzbenica"
    ADD CONSTRAINT "Narudzbenica_pkey" PRIMARY KEY ("NarudzbenicaId");


--
-- TOC entry 2916 (class 2606 OID 24851)
-- Name: Oprema Oprema_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Oprema"
    ADD CONSTRAINT "Oprema_pkey" PRIMARY KEY ("OpremaId");


--
-- TOC entry 2924 (class 2606 OID 24906)
-- Name: Otpremnica Otpremnica_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Otpremnica"
    ADD CONSTRAINT "Otpremnica_pkey" PRIMARY KEY ("OtpremnicaId");


--
-- TOC entry 2920 (class 2606 OID 24875)
-- Name: Primka Primka_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Primka"
    ADD CONSTRAINT "Primka_pkey" PRIMARY KEY ("PrimkaId");


--
-- TOC entry 2930 (class 2606 OID 24944)
-- Name: StavkaNarudzbenice StavkaNarudzbenice_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."StavkaNarudzbenice"
    ADD CONSTRAINT "StavkaNarudzbenice_pkey" PRIMARY KEY ("NarudzbenicaId", "OpremaId");


--
-- TOC entry 2926 (class 2606 OID 24916)
-- Name: StavkaOtpremnice StavkaOtpremnice_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."StavkaOtpremnice"
    ADD CONSTRAINT "StavkaOtpremnice_pkey" PRIMARY KEY ("OtpremnicaId", "OpremaId");


--
-- TOC entry 2922 (class 2606 OID 24885)
-- Name: StavkaPrimke StavkaPrimke_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."StavkaPrimke"
    ADD CONSTRAINT "StavkaPrimke_pkey" PRIMARY KEY ("PrimkaId", "OpremaId");


--
-- TOC entry 2914 (class 2606 OID 24840)
-- Name: VrstaOpreme VrstaOpreme_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."VrstaOpreme"
    ADD CONSTRAINT "VrstaOpreme_pkey" PRIMARY KEY ("VrstaOpremeId");


--
-- TOC entry 2918 (class 2606 OID 24867)
-- Name: Zaposlenik Zaposlenik_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Zaposlenik"
    ADD CONSTRAINT "Zaposlenik_pkey" PRIMARY KEY ("ZaposlenikId");


--
-- TOC entry 2947 (class 2620 OID 24999)
-- Name: StavkaOtpremnice dodaj_kol_oprema_otp; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER dodaj_kol_oprema_otp AFTER DELETE ON public."StavkaOtpremnice" FOR EACH ROW EXECUTE FUNCTION public.stavke_otpremnice_dodaj();


--
-- TOC entry 2942 (class 2620 OID 25002)
-- Name: StavkaPrimke dodaj_kol_oprema_prim; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER dodaj_kol_oprema_prim AFTER INSERT ON public."StavkaPrimke" FOR EACH ROW EXECUTE FUNCTION public.stavke_primke_dodaj();


--
-- TOC entry 2951 (class 2620 OID 25020)
-- Name: StavkaOtpremnice kol_opreme_max_otp; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER kol_opreme_max_otp BEFORE DELETE ON public."StavkaOtpremnice" FOR EACH ROW EXECUTE FUNCTION public.stavke_otpremnice_max_kol();


--
-- TOC entry 2944 (class 2620 OID 25004)
-- Name: StavkaPrimke kol_opreme_max_prim; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER kol_opreme_max_prim BEFORE INSERT OR UPDATE ON public."StavkaPrimke" FOR EACH ROW EXECUTE FUNCTION public.stavke_primke_max_kol();


--
-- TOC entry 2949 (class 2620 OID 25001)
-- Name: StavkaOtpremnice kol_opreme_min_otp; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER kol_opreme_min_otp AFTER INSERT OR UPDATE ON public."StavkaOtpremnice" FOR EACH ROW EXECUTE FUNCTION public.stavke_otpremnice_min_kol();


--
-- TOC entry 2945 (class 2620 OID 25021)
-- Name: StavkaPrimke kol_opreme_min_prim; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER kol_opreme_min_prim BEFORE DELETE ON public."StavkaPrimke" FOR EACH ROW EXECUTE FUNCTION public.stavke_primke_min_kol();


--
-- TOC entry 2950 (class 2620 OID 25019)
-- Name: StavkaOtpremnice kol_opreme_min_trenutna; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER kol_opreme_min_trenutna BEFORE INSERT OR UPDATE ON public."StavkaOtpremnice" FOR EACH ROW EXECUTE FUNCTION public.stavke_otpremnice_kol_manja_min();


--
-- TOC entry 2948 (class 2620 OID 25000)
-- Name: StavkaOtpremnice kol_opreme_nula_otp; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER kol_opreme_nula_otp BEFORE INSERT OR UPDATE ON public."StavkaOtpremnice" FOR EACH ROW EXECUTE FUNCTION public.stavke_otpremnice_kol();


--
-- TOC entry 2946 (class 2620 OID 24998)
-- Name: StavkaOtpremnice oduzmi_kol_oprema_otp; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER oduzmi_kol_oprema_otp AFTER INSERT ON public."StavkaOtpremnice" FOR EACH ROW EXECUTE FUNCTION public.stavke_otpremnice_oduzmi();


--
-- TOC entry 2943 (class 2620 OID 25003)
-- Name: StavkaPrimke oduzmi_kol_oprema_prim; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER oduzmi_kol_oprema_prim AFTER DELETE ON public."StavkaPrimke" FOR EACH ROW EXECUTE FUNCTION public.stavke_primke_oduzmi();


--
-- TOC entry 2941 (class 2620 OID 24967)
-- Name: Zaposlenik temp_zaposlenik; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER temp_zaposlenik AFTER DELETE ON public."Zaposlenik" FOR EACH ROW EXECUTE FUNCTION public.zaposlenik_otkaz();


--
-- TOC entry 2938 (class 2606 OID 24935)
-- Name: Narudzbenica Narudzbenica_ZaposlenikId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Narudzbenica"
    ADD CONSTRAINT "Narudzbenica_ZaposlenikId_fkey" FOREIGN KEY ("ZaposlenikId") REFERENCES public."Zaposlenik"("ZaposlenikId") ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 2931 (class 2606 OID 24852)
-- Name: Oprema Oprema_VrstaOpremeId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Oprema"
    ADD CONSTRAINT "Oprema_VrstaOpremeId_fkey" FOREIGN KEY ("VrstaOpremeId") REFERENCES public."VrstaOpreme"("VrstaOpremeId") ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 2935 (class 2606 OID 24907)
-- Name: Otpremnica Otpremnica_ZaposlenikId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Otpremnica"
    ADD CONSTRAINT "Otpremnica_ZaposlenikId_fkey" FOREIGN KEY ("ZaposlenikId") REFERENCES public."Zaposlenik"("ZaposlenikId") ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 2932 (class 2606 OID 24876)
-- Name: Primka Primka_ZaposlenikId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Primka"
    ADD CONSTRAINT "Primka_ZaposlenikId_fkey" FOREIGN KEY ("ZaposlenikId") REFERENCES public."Zaposlenik"("ZaposlenikId") ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 2939 (class 2606 OID 24945)
-- Name: StavkaNarudzbenice StavkaNarudzbenice_NarudzbenicaId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."StavkaNarudzbenice"
    ADD CONSTRAINT "StavkaNarudzbenice_NarudzbenicaId_fkey" FOREIGN KEY ("NarudzbenicaId") REFERENCES public."Narudzbenica"("NarudzbenicaId") ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 2940 (class 2606 OID 24950)
-- Name: StavkaNarudzbenice StavkaNarudzbenice_OpremaId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."StavkaNarudzbenice"
    ADD CONSTRAINT "StavkaNarudzbenice_OpremaId_fkey" FOREIGN KEY ("OpremaId") REFERENCES public."Oprema"("OpremaId") ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 2937 (class 2606 OID 24922)
-- Name: StavkaOtpremnice StavkaOtpremnice_OpremaId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."StavkaOtpremnice"
    ADD CONSTRAINT "StavkaOtpremnice_OpremaId_fkey" FOREIGN KEY ("OpremaId") REFERENCES public."Oprema"("OpremaId") ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 2936 (class 2606 OID 24917)
-- Name: StavkaOtpremnice StavkaOtpremnice_OtpremnicaId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."StavkaOtpremnice"
    ADD CONSTRAINT "StavkaOtpremnice_OtpremnicaId_fkey" FOREIGN KEY ("OtpremnicaId") REFERENCES public."Otpremnica"("OtpremnicaId") ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 2934 (class 2606 OID 24891)
-- Name: StavkaPrimke StavkaPrimke_OpremaId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."StavkaPrimke"
    ADD CONSTRAINT "StavkaPrimke_OpremaId_fkey" FOREIGN KEY ("OpremaId") REFERENCES public."Oprema"("OpremaId") ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 2933 (class 2606 OID 24886)
-- Name: StavkaPrimke StavkaPrimke_PrimkaId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."StavkaPrimke"
    ADD CONSTRAINT "StavkaPrimke_PrimkaId_fkey" FOREIGN KEY ("PrimkaId") REFERENCES public."Primka"("PrimkaId") ON UPDATE CASCADE ON DELETE RESTRICT;


-- Completed on 2021-02-07 17:15:41

--
-- PostgreSQL database dump complete
--

