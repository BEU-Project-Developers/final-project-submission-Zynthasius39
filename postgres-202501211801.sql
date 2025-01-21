--
-- PostgreSQL database cluster dump
--

-- Started on 2025-01-21 18:01:51

SET default_transaction_read_only = off;

SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;

--
-- Roles
--

CREATE ROLE postgres;
ALTER ROLE postgres WITH SUPERUSER INHERIT CREATEROLE CREATEDB LOGIN REPLICATION BYPASSRLS;

--
-- User Configurations
--






--
-- Databases
--

--
-- Database "template1" dump
--

\connect template1

--
-- PostgreSQL database dump
--

-- Dumped from database version 17.2 (Debian 17.2-1.pgdg120+1)
-- Dumped by pg_dump version 17.0

-- Started on 2025-01-21 18:01:51

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET transaction_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

-- Completed on 2025-01-21 18:01:53

--
-- PostgreSQL database dump complete
--

--
-- Database "postgres" dump
--

\connect postgres

--
-- PostgreSQL database dump
--

-- Dumped from database version 17.2 (Debian 17.2-1.pgdg120+1)
-- Dumped by pg_dump version 17.0

-- Started on 2025-01-21 18:01:53

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET transaction_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 862 (class 1247 OID 16394)
-- Name: accountt; Type: TYPE; Schema: public; Owner: -
--

CREATE TYPE public.accountt AS ENUM (
    'savings',
    'credit',
    'debit',
    'investing'
);


--
-- TOC entry 859 (class 1247 OID 16389)
-- Name: contractt; Type: TYPE; Schema: public; Owner: -
--

CREATE TYPE public.contractt AS ENUM (
    'mortgage',
    'loan'
);


--
-- TOC entry 892 (class 1247 OID 49178)
-- Name: currency; Type: TYPE; Schema: public; Owner: -
--

CREATE TYPE public.currency AS ENUM (
    'azn',
    'usd',
    'eur',
    'gold',
    'try'
);


--
-- TOC entry 865 (class 1247 OID 16404)
-- Name: resourcet; Type: TYPE; Schema: public; Owner: -
--

CREATE TYPE public.resourcet AS ENUM (
    'cash',
    'metal',
    'share',
    'fund',
    'crypto'
);


--
-- TOC entry 871 (class 1247 OID 16436)
-- Name: rolet; Type: TYPE; Schema: public; Owner: -
--

CREATE TYPE public.rolet AS ENUM (
    'visitor',
    'member',
    'business',
    'enterprise',
    'mod',
    'admin'
);


--
-- TOC entry 868 (class 1247 OID 16416)
-- Name: transactiont; Type: TYPE; Schema: public; Owner: -
--

CREATE TYPE public.transactiont AS ENUM (
    'withdrawal',
    'deposit',
    'exchange'
);


--
-- TOC entry 230 (class 1255 OID 32768)
-- Name: generate_random_credit_card(); Type: FUNCTION; Schema: public; Owner: -
--

CREATE FUNCTION public.generate_random_credit_card() RETURNS bigint
    LANGUAGE plpgsql
    AS $$
DECLARE
    random_number BIGINT;
BEGIN
    -- Generate a random number in the range of 16-digit numbers
    random_number := 4000000000000000 + (RANDOM() * 99999999999999)::BIGINT;  -- Example starting with 4000
    RETURN random_number;
END;
$$;


SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 222 (class 1259 OID 16464)
-- Name: accounts; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.accounts (
    accid integer NOT NULL,
    acctype public.accountt NOT NULL,
    cids integer[] NOT NULL,
    currency public.currency NOT NULL,
    expiration_date timestamp without time zone NOT NULL,
    creation_date timestamp without time zone NOT NULL,
    amount numeric NOT NULL,
    accnumber bigint NOT NULL,
    cvv integer NOT NULL
);


--
-- TOC entry 221 (class 1259 OID 16463)
-- Name: accounts_accid_seq; Type: SEQUENCE; Schema: public; Owner: -
--

CREATE SEQUENCE public.accounts_accid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


--
-- TOC entry 3428 (class 0 OID 0)
-- Dependencies: 221
-- Name: accounts_accid_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: -
--

ALTER SEQUENCE public.accounts_accid_seq OWNED BY public.accounts.accid;


--
-- TOC entry 220 (class 1259 OID 16457)
-- Name: contracts; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.contracts (
    contid integer NOT NULL,
    cid integer,
    ctype public.contractt,
    currency public.currency,
    expiration_date timestamp without time zone,
    creation_date timestamp without time zone,
    amount numeric
);


--
-- TOC entry 219 (class 1259 OID 16456)
-- Name: contracts_contid_seq; Type: SEQUENCE; Schema: public; Owner: -
--

CREATE SEQUENCE public.contracts_contid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


--
-- TOC entry 3429 (class 0 OID 0)
-- Dependencies: 219
-- Name: contracts_contid_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: -
--

ALTER SEQUENCE public.contracts_contid_seq OWNED BY public.contracts.contid;


--
-- TOC entry 218 (class 1259 OID 16450)
-- Name: customers; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.customers (
    cid integer NOT NULL,
    name text NOT NULL,
    surname text NOT NULL,
    email character varying(64) NOT NULL,
    phone character varying(15) NOT NULL,
    password character varying(64) NOT NULL,
    role public.rolet NOT NULL,
    tids integer[] DEFAULT ARRAY[]::integer[] NOT NULL,
    register_date timestamp without time zone NOT NULL
);


--
-- TOC entry 217 (class 1259 OID 16449)
-- Name: customers_cid_seq; Type: SEQUENCE; Schema: public; Owner: -
--

CREATE SEQUENCE public.customers_cid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


--
-- TOC entry 3430 (class 0 OID 0)
-- Dependencies: 217
-- Name: customers_cid_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: -
--

ALTER SEQUENCE public.customers_cid_seq OWNED BY public.customers.cid;


--
-- TOC entry 229 (class 1259 OID 49218)
-- Name: payments; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.payments (
    id integer NOT NULL,
    name text NOT NULL,
    destination bigint NOT NULL,
    amount numeric NOT NULL,
    img_path text,
    currency public.currency NOT NULL
);


--
-- TOC entry 228 (class 1259 OID 49217)
-- Name: payments_id_seq; Type: SEQUENCE; Schema: public; Owner: -
--

CREATE SEQUENCE public.payments_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


--
-- TOC entry 3431 (class 0 OID 0)
-- Dependencies: 228
-- Name: payments_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: -
--

ALTER SEQUENCE public.payments_id_seq OWNED BY public.payments.id;


--
-- TOC entry 226 (class 1259 OID 16478)
-- Name: resources; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.resources (
    resid integer NOT NULL,
    restype public.resourcet,
    currency public.currency,
    amount numeric
);


--
-- TOC entry 225 (class 1259 OID 16477)
-- Name: resource_resid_seq; Type: SEQUENCE; Schema: public; Owner: -
--

CREATE SEQUENCE public.resource_resid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


--
-- TOC entry 3432 (class 0 OID 0)
-- Dependencies: 225
-- Name: resource_resid_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: -
--

ALTER SEQUENCE public.resource_resid_seq OWNED BY public.resources.resid;


--
-- TOC entry 224 (class 1259 OID 16471)
-- Name: transactions; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.transactions (
    tid integer NOT NULL,
    ttype public.transactiont,
    currency public.currency,
    date timestamp without time zone,
    amount numeric
);


--
-- TOC entry 223 (class 1259 OID 16470)
-- Name: transactions_tid_seq; Type: SEQUENCE; Schema: public; Owner: -
--

CREATE SEQUENCE public.transactions_tid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


--
-- TOC entry 3433 (class 0 OID 0)
-- Dependencies: 223
-- Name: transactions_tid_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: -
--

ALTER SEQUENCE public.transactions_tid_seq OWNED BY public.transactions.tid;


--
-- TOC entry 227 (class 1259 OID 16484)
-- Name: ui_preferences; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.ui_preferences (
    cid integer,
    preferences text[]
);


--
-- TOC entry 3261 (class 2604 OID 16467)
-- Name: accounts accid; Type: DEFAULT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.accounts ALTER COLUMN accid SET DEFAULT nextval('public.accounts_accid_seq'::regclass);


--
-- TOC entry 3260 (class 2604 OID 16460)
-- Name: contracts contid; Type: DEFAULT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.contracts ALTER COLUMN contid SET DEFAULT nextval('public.contracts_contid_seq'::regclass);


--
-- TOC entry 3258 (class 2604 OID 16453)
-- Name: customers cid; Type: DEFAULT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.customers ALTER COLUMN cid SET DEFAULT nextval('public.customers_cid_seq'::regclass);


--
-- TOC entry 3264 (class 2604 OID 49221)
-- Name: payments id; Type: DEFAULT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.payments ALTER COLUMN id SET DEFAULT nextval('public.payments_id_seq'::regclass);


--
-- TOC entry 3263 (class 2604 OID 16481)
-- Name: resources resid; Type: DEFAULT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.resources ALTER COLUMN resid SET DEFAULT nextval('public.resource_resid_seq'::regclass);


--
-- TOC entry 3262 (class 2604 OID 16474)
-- Name: transactions tid; Type: DEFAULT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.transactions ALTER COLUMN tid SET DEFAULT nextval('public.transactions_tid_seq'::regclass);


--
-- TOC entry 3415 (class 0 OID 16464)
-- Dependencies: 222
-- Data for Name: accounts; Type: TABLE DATA; Schema: public; Owner: -
--

COPY public.accounts (accid, acctype, cids, currency, expiration_date, creation_date, amount, accnumber, cvv) FROM stdin;
4	credit	{254,0}	usd	2038-01-19 01:00:00	2024-11-26 00:00:00	20199378	6468634822589073	123
3	investing	{254,0}	eur	2027-02-28 01:00:00	2024-11-26 00:00:00	2198802	4994223476156262	194
1	debit	{254,0}	try	2025-11-26 01:00:00	2024-11-26 00:00:00	270	4097980880844333	854
2	savings	{254,0}	azn	2026-12-27 01:00:00	2024-11-26 00:00:00	101000	7895560464384117	966
\.


--
-- TOC entry 3413 (class 0 OID 16457)
-- Dependencies: 220
-- Data for Name: contracts; Type: TABLE DATA; Schema: public; Owner: -
--

COPY public.contracts (contid, cid, ctype, currency, expiration_date, creation_date, amount) FROM stdin;
1	1	mortgage	try	2025-03-02 09:29:17	2024-06-07 09:29:17	35921.89
2	2	loan	azn	2025-09-27 09:29:17	2024-10-06 09:29:17	94850.88
3	3	loan	try	2025-12-04 09:29:17	2024-06-24 09:29:17	52305.91
4	4	mortgage	usd	2025-08-18 09:29:17	2024-09-14 09:29:17	25620.49
5	5	loan	usd	2025-08-30 09:29:17	2024-09-22 09:29:17	52385.26
6	6	mortgage	gold	2025-12-05 09:29:17	2024-06-21 09:29:17	41212.33
7	7	mortgage	azn	2025-11-30 09:29:17	2024-06-25 09:29:17	60112.24
8	8	mortgage	try	2025-04-24 09:29:17	2024-04-16 09:29:17	34758.46
9	9	mortgage	try	2025-02-12 09:29:17	2024-05-19 09:29:17	74543.36
10	10	mortgage	try	2025-10-05 09:29:17	2024-01-31 09:29:17	14963.26
11	11	mortgage	gold	2025-12-10 09:29:17	2024-08-14 09:29:17	77933.23
12	12	loan	azn	2025-03-22 09:29:17	2024-02-19 09:29:17	97572.59
13	13	mortgage	usd	2025-11-12 09:29:17	2024-10-10 09:29:17	6610.28
14	14	mortgage	usd	2025-11-24 09:29:17	2024-11-28 09:29:17	40212.62
15	15	mortgage	eur	2025-10-08 09:29:17	2024-06-25 09:29:17	93332.58
16	16	loan	azn	2025-10-05 09:29:17	2024-03-09 09:29:17	37544.38
17	17	loan	gold	2025-12-07 09:29:17	2024-04-06 09:29:17	43441.98
18	18	loan	azn	2025-03-21 09:29:17	2024-06-18 09:29:17	51025.54
19	19	loan	eur	2025-04-30 09:29:17	2024-03-04 09:29:17	35345.34
20	20	mortgage	try	2025-10-18 09:29:17	2024-12-03 09:29:17	28527.45
21	21	mortgage	usd	2025-03-15 09:29:17	2024-10-14 09:29:17	46394.82
22	22	mortgage	eur	2025-11-06 09:29:17	2025-01-08 09:29:17	53812.03
23	23	loan	gold	2025-04-23 09:29:17	2024-10-07 09:29:17	91214.67
24	24	mortgage	gold	2026-01-09 09:29:17	2025-01-10 09:29:17	19974.76
25	25	mortgage	gold	2025-12-03 09:29:17	2024-05-22 09:29:17	67825.07
26	26	mortgage	gold	2025-06-23 09:29:17	2024-11-27 09:29:17	11757.93
27	27	loan	eur	2025-09-16 09:29:17	2024-11-02 09:29:17	93926.85
28	28	loan	usd	2025-03-12 09:29:17	2024-12-02 09:29:17	11979.32
29	29	loan	azn	2025-08-04 09:29:17	2024-04-25 09:29:17	24408.11
30	30	mortgage	azn	2025-09-29 09:29:17	2024-12-20 09:29:17	99049.02
\.


--
-- TOC entry 3411 (class 0 OID 16450)
-- Dependencies: 218
-- Data for Name: customers; Type: TABLE DATA; Schema: public; Owner: -
--

COPY public.customers (cid, name, surname, email, phone, password, role, tids, register_date) FROM stdin;
268	Gringott	the goblin	admin@home.alak	+994000000000	a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3	admin	{}	2025-11-26 00:00:00
272	Test	Surname	test@gmail.com	+994703166875	5994471ABB01112AFCC18159F6CC74B4F511B99806DA59B3CAF5A9C173CACFC5	business	{}	2025-01-21 03:52:51.436326
259	Səidə	Ələkbərova	itssaidapvp@inbox.ru	+994559999999	097f069426a8792ca09536a6137b45970759aa55d93637563af0c570dac99555	mod	{}	2025-11-26 00:00:00
258	İlhamə	Qadalova	ilhame.qadalova@box.az	+994505555555	88c2e85e79a39e3efdf3d033a5a6d948912cca9c015273a9cb93df632a54ddde	enterprise	{}	2025-11-26 00:00:00
265	Gülafər	Əzizli	gulafer.azizli@outlook.com	+944513377227	8947e92ac952d5480b84a14617b22e325067c2bf6f8563f11faa653e32170808	admin	{}	2025-11-26 00:00:00
255	Alidə	İsmayılova	alide.ismayilova@protonmail.com	+994508246544	e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855	mod	{}	2025-11-26 00:00:00
257	Pərvin	Müslümova	pervin.muslumova@box.az	+994703021234	03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4	mod	{}	2025-11-26 00:00:00
254	Züleyxa	Ələkbərova	zuleyxa@proton.me	+994553168682	03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4	member	{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42}	2025-11-26 00:00:00
\.


--
-- TOC entry 3422 (class 0 OID 49218)
-- Dependencies: 229
-- Data for Name: payments; Type: TABLE DATA; Schema: public; Owner: -
--

COPY public.payments (id, name, destination, amount, img_path, currency) FROM stdin;
10	Türkcell	1234567891022	600	turkcell	try
4	Baku Transport Agency	1234567891014	0	bta	azn
1	Aztelecom	1234567891011	30	aztelekom	azn
2	Azercell	1234567891012	4	azercell	azn
3	BakıKart	1234567891013	10	bakukart	azn
5	Bakcell	1234567891015	4	bakcell	azn
6	Baktelecom	1234567891016	25	baktelecom	azn
7	Bolt	1234567891017	12	bolt	azn
8	KATV	1234567891018	22	katv	azn
9	Wolt	1234567891021	13	wolt	azn
11	SNTV	1234567891023	18	sntv	azn
12	Azərbaycan Diasporuna Dəstək Fondu	1234567891024	10	addf	azn
13	Qarabağ Dirçəliş Fondu	1234567891026	10	qdf	azn
14	YAŞAT Fondu	1234567891027	10	yf	azn
15	Azərişıq	1234567891090	20	azelectric	azn
17	AzəriQaz	1234567891090	30	azgas	azn
18	AzərSu	1234567891091	25	azwater	azn
19	Azərİstilik Təchizat	1234567891091	20	azheat	azn
20	Azərbaycan Dəmir Yolları	1234567891094	16	azrails	azn
21	SumqayıtKart	1234567891095	8	sumgaitcard	azn
\.


--
-- TOC entry 3419 (class 0 OID 16478)
-- Dependencies: 226
-- Data for Name: resources; Type: TABLE DATA; Schema: public; Owner: -
--

COPY public.resources (resid, restype, currency, amount) FROM stdin;
\.


--
-- TOC entry 3417 (class 0 OID 16471)
-- Dependencies: 224
-- Data for Name: transactions; Type: TABLE DATA; Schema: public; Owner: -
--

COPY public.transactions (tid, ttype, currency, date, amount) FROM stdin;
1	deposit	try	2020-06-04 02:53:33	383.62
2	withdrawal	gold	2020-08-01 14:22:13	520.12
3	deposit	eur	2021-11-29 08:12:48	241.52
4	deposit	eur	2023-01-05 18:56:29	586.91
5	withdrawal	azn	2021-07-07 10:29:35	938.34
6	withdrawal	try	2022-09-04 01:50:31	527.23
7	deposit	usd	2020-04-03 11:33:26	45.38
8	withdrawal	try	2022-10-09 20:40:52	681.51
9	withdrawal	eur	2021-10-06 22:11:54	704.32
10	deposit	usd	2020-02-23 07:25:48	827.06
11	deposit	usd	2020-12-02 23:22:03	289.51
12	deposit	eur	2022-07-15 01:19:04	556.76
13	withdrawal	try	2020-03-30 10:02:45	842.76
14	withdrawal	usd	2021-06-14 19:52:11	85.57
15	withdrawal	try	2022-05-11 00:03:12	658.71
16	withdrawal	eur	2021-04-29 22:26:58	736.59
17	deposit	eur	2023-01-14 13:47:12	849.14
18	deposit	try	2021-06-12 02:38:35	167.48
19	withdrawal	try	2020-11-03 00:48:55	894.18
20	withdrawal	try	2022-04-04 16:57:58	381.99
21	deposit	try	2020-12-07 03:57:38	66.88
22	withdrawal	try	2022-09-25 11:34:11	227.01
23	deposit	gold	2022-01-14 23:55:16	907.22
24	withdrawal	gold	2020-04-02 01:53:14	408.38
25	withdrawal	eur	2020-10-04 19:15:12	212.13
26	withdrawal	gold	2020-01-17 08:25:14	853.17
27	deposit	usd	2020-08-12 09:44:03	182.51
28	deposit	usd	2022-02-28 23:56:51	297.87
29	withdrawal	usd	2022-04-10 17:59:40	312.51
30	withdrawal	eur	2020-04-16 11:18:56	684.06
31	deposit	gold	2022-07-24 12:03:37	984.51
32	deposit	try	2020-06-13 18:51:42	658.24
33	deposit	gold	2022-01-20 03:24:29	651.49
34	withdrawal	try	2021-03-14 19:44:24	426.94
35	deposit	eur	2020-02-13 16:30:42	593.78
36	deposit	eur	2022-12-04 20:56:02	780.52
37	withdrawal	gold	2021-09-18 11:40:14	71.93
38	withdrawal	try	2021-08-12 06:04:31	117.92
39	withdrawal	try	2020-07-16 00:27:59	313.76
40	withdrawal	usd	2020-11-21 03:47:02	510.96
41	deposit	eur	2021-06-09 18:12:53	577.27
42	deposit	usd	2020-09-06 08:15:48	934.58
\.


--
-- TOC entry 3420 (class 0 OID 16484)
-- Dependencies: 227
-- Data for Name: ui_preferences; Type: TABLE DATA; Schema: public; Owner: -
--

COPY public.ui_preferences (cid, preferences) FROM stdin;
\.


--
-- TOC entry 3434 (class 0 OID 0)
-- Dependencies: 221
-- Name: accounts_accid_seq; Type: SEQUENCE SET; Schema: public; Owner: -
--

SELECT pg_catalog.setval('public.accounts_accid_seq', 4, true);


--
-- TOC entry 3435 (class 0 OID 0)
-- Dependencies: 219
-- Name: contracts_contid_seq; Type: SEQUENCE SET; Schema: public; Owner: -
--

SELECT pg_catalog.setval('public.contracts_contid_seq', 30, true);


--
-- TOC entry 3436 (class 0 OID 0)
-- Dependencies: 217
-- Name: customers_cid_seq; Type: SEQUENCE SET; Schema: public; Owner: -
--

SELECT pg_catalog.setval('public.customers_cid_seq', 274, true);


--
-- TOC entry 3437 (class 0 OID 0)
-- Dependencies: 228
-- Name: payments_id_seq; Type: SEQUENCE SET; Schema: public; Owner: -
--

SELECT pg_catalog.setval('public.payments_id_seq', 21, true);


--
-- TOC entry 3438 (class 0 OID 0)
-- Dependencies: 225
-- Name: resource_resid_seq; Type: SEQUENCE SET; Schema: public; Owner: -
--

SELECT pg_catalog.setval('public.resource_resid_seq', 1, false);


--
-- TOC entry 3439 (class 0 OID 0)
-- Dependencies: 223
-- Name: transactions_tid_seq; Type: SEQUENCE SET; Schema: public; Owner: -
--

SELECT pg_catalog.setval('public.transactions_tid_seq', 42, true);


-- Completed on 2025-01-21 18:01:55

--
-- PostgreSQL database dump complete
--

-- Completed on 2025-01-21 18:01:55

--
-- PostgreSQL database cluster dump complete
--

