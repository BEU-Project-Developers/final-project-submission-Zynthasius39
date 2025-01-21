--
-- PostgreSQL database cluster dump
--

-- Started on 2025-01-21 18:01:35

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

-- Started on 2025-01-21 18:01:35

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

-- Completed on 2025-01-21 18:01:38

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

-- Started on 2025-01-21 18:01:38

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
-- TOC entry 3415 (class 0 OID 0)
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
-- TOC entry 3416 (class 0 OID 0)
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
-- TOC entry 3417 (class 0 OID 0)
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
-- TOC entry 3418 (class 0 OID 0)
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
-- TOC entry 3419 (class 0 OID 0)
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
-- TOC entry 3420 (class 0 OID 0)
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


-- Completed on 2025-01-21 18:01:40

--
-- PostgreSQL database dump complete
--

-- Completed on 2025-01-21 18:01:40

--
-- PostgreSQL database cluster dump complete
--

