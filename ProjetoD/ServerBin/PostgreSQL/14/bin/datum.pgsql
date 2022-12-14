--
-- PostgreSQL database dump
--

-- Dumped from database version 14.4
-- Dumped by pg_dump version 14.4

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

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: categorias_objetos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.categorias_objetos (
    id integer NOT NULL,
    ativo boolean DEFAULT true,
    categoria character varying(64)
);


ALTER TABLE public.categorias_objetos OWNER TO postgres;

--
-- Name: categoriasObjetos_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."categoriasObjetos_id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."categoriasObjetos_id_seq" OWNER TO postgres;

--
-- Name: categoriasObjetos_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."categoriasObjetos_id_seq" OWNED BY public.categorias_objetos.id;


--
-- Name: contatos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.contatos (
    id integer NOT NULL,
    "idPessoa" bigint NOT NULL,
    "tipoContato" character varying(32),
    contato character varying(128)
);


ALTER TABLE public.contatos OWNER TO postgres;

--
-- Name: contatos_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.contatos_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.contatos_id_seq OWNER TO postgres;

--
-- Name: contatos_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.contatos_id_seq OWNED BY public.contatos.id;


--
-- Name: enderecos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.enderecos (
    id integer NOT NULL,
    "idPessoa" bigint NOT NULL,
    "tipoEndereco" character varying(32),
    endereco character varying(128),
    bairro character varying(128),
    cidade character varying(128),
    estado character varying(128)
);


ALTER TABLE public.enderecos OWNER TO postgres;

--
-- Name: enderecos_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.enderecos_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.enderecos_id_seq OWNER TO postgres;

--
-- Name: enderecos_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.enderecos_id_seq OWNED BY public.enderecos.id;


--
-- Name: log; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.log (
    id integer NOT NULL,
    "idPessoaDoando" bigint NOT NULL,
    "idPessoaRecebendo" bigint,
    "idObjeto" bigint,
    "idUsuarioResponsavel" bigint,
    status character varying(64)
);


ALTER TABLE public.log OWNER TO postgres;

--
-- Name: log_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.log_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.log_id_seq OWNER TO postgres;

--
-- Name: log_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.log_id_seq OWNED BY public.log.id;


--
-- Name: objeto_necessario; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.objeto_necessario (
    id integer NOT NULL,
    "idPessoa" bigint NOT NULL,
    "idCategoria" bigint,
    "idUsuario" bigint
);


ALTER TABLE public.objeto_necessario OWNER TO postgres;

--
-- Name: objNecessario_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."objNecessario_id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."objNecessario_id_seq" OWNER TO postgres;

--
-- Name: objNecessario_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."objNecessario_id_seq" OWNED BY public.objeto_necessario.id;


--
-- Name: objeto_doando; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.objeto_doando (
    id integer NOT NULL,
    "idPessoa" bigint NOT NULL,
    "idObjeto" bigint,
    "idCategoria" bigint,
    "idUsuario" bigint
);


ALTER TABLE public.objeto_doando OWNER TO postgres;

--
-- Name: objeto_doando_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.objeto_doando_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.objeto_doando_id_seq OWNER TO postgres;

--
-- Name: objeto_doando_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.objeto_doando_id_seq OWNED BY public.objeto_doando.id;


--
-- Name: objetos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.objetos (
    id integer NOT NULL,
    "idCategoria" bigint NOT NULL,
    objeto character varying(128),
    imagem bytea,
    descricao character varying(256)
);


ALTER TABLE public.objetos OWNER TO postgres;

--
-- Name: objetos_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.objetos_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.objetos_id_seq OWNER TO postgres;

--
-- Name: objetos_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.objetos_id_seq OWNED BY public.objetos.id;


--
-- Name: ongs; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.ongs (
    id integer NOT NULL,
    nome character varying(128),
    ativa boolean NOT NULL,
    endereco character varying(128),
    cidade character varying(128),
    estado character varying(128),
    fone character varying(32)
);


ALTER TABLE public.ongs OWNER TO postgres;

--
-- Name: ongs_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.ongs_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.ongs_id_seq OWNER TO postgres;

--
-- Name: ongs_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.ongs_id_seq OWNED BY public.ongs.id;


--
-- Name: pessoas; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.pessoas (
    id integer NOT NULL,
    nome character varying(128),
    cpf character varying(128)
);


ALTER TABLE public.pessoas OWNER TO postgres;

--
-- Name: pessoas_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.pessoas_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.pessoas_id_seq OWNER TO postgres;

--
-- Name: pessoas_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.pessoas_id_seq OWNED BY public.pessoas.id;


--
-- Name: usuarios; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.usuarios (
    id integer NOT NULL,
    "idOng" bigint NOT NULL,
    username character varying(128),
    password character varying(128),
    nome character varying(128),
    fone character varying(128)
);


ALTER TABLE public.usuarios OWNER TO postgres;

--
-- Name: usuarios_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.usuarios_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.usuarios_id_seq OWNER TO postgres;

--
-- Name: usuarios_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.usuarios_id_seq OWNED BY public.usuarios.id;


--
-- Name: categorias_objetos id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.categorias_objetos ALTER COLUMN id SET DEFAULT nextval('public."categoriasObjetos_id_seq"'::regclass);


--
-- Name: contatos id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.contatos ALTER COLUMN id SET DEFAULT nextval('public.contatos_id_seq'::regclass);


--
-- Name: enderecos id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.enderecos ALTER COLUMN id SET DEFAULT nextval('public.enderecos_id_seq'::regclass);


--
-- Name: log id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.log ALTER COLUMN id SET DEFAULT nextval('public.log_id_seq'::regclass);


--
-- Name: objeto_doando id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.objeto_doando ALTER COLUMN id SET DEFAULT nextval('public.objeto_doando_id_seq'::regclass);


--
-- Name: objeto_necessario id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.objeto_necessario ALTER COLUMN id SET DEFAULT nextval('public."objNecessario_id_seq"'::regclass);


--
-- Name: objetos id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.objetos ALTER COLUMN id SET DEFAULT nextval('public.objetos_id_seq'::regclass);


--
-- Name: ongs id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ongs ALTER COLUMN id SET DEFAULT nextval('public.ongs_id_seq'::regclass);


--
-- Name: pessoas id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pessoas ALTER COLUMN id SET DEFAULT nextval('public.pessoas_id_seq'::regclass);


--
-- Name: usuarios id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.usuarios ALTER COLUMN id SET DEFAULT nextval('public.usuarios_id_seq'::regclass);


--
-- Data for Name: categorias_objetos; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.categorias_objetos (id, ativo, categoria) FROM stdin;
\.


--
-- Data for Name: contatos; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.contatos (id, "idPessoa", "tipoContato", contato) FROM stdin;
\.


--
-- Data for Name: enderecos; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.enderecos (id, "idPessoa", "tipoEndereco", endereco, bairro, cidade, estado) FROM stdin;
\.


--
-- Data for Name: log; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.log (id, "idPessoaDoando", "idPessoaRecebendo", "idObjeto", "idUsuarioResponsavel", status) FROM stdin;
\.


--
-- Data for Name: objeto_doando; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.objeto_doando (id, "idPessoa", "idObjeto", "idCategoria", "idUsuario") FROM stdin;
\.


--
-- Data for Name: objeto_necessario; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.objeto_necessario (id, "idPessoa", "idCategoria", "idUsuario") FROM stdin;
\.


--
-- Data for Name: objetos; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.objetos (id, "idCategoria", objeto, imagem, descricao) FROM stdin;
\.


--
-- Data for Name: ongs; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.ongs (id, nome, ativa, endereco, cidade, estado, fone) FROM stdin;
\.


--
-- Data for Name: pessoas; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.pessoas (id, nome, cpf) FROM stdin;
\.


--
-- Data for Name: usuarios; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.usuarios (id, "idOng", username, password, nome, fone) FROM stdin;
\.


--
-- Name: categoriasObjetos_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."categoriasObjetos_id_seq"', 1, false);


--
-- Name: contatos_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.contatos_id_seq', 1, false);


--
-- Name: enderecos_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.enderecos_id_seq', 1, false);


--
-- Name: log_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.log_id_seq', 1, false);


--
-- Name: objNecessario_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."objNecessario_id_seq"', 1, false);


--
-- Name: objeto_doando_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.objeto_doando_id_seq', 1, false);


--
-- Name: objetos_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.objetos_id_seq', 1, false);


--
-- Name: ongs_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.ongs_id_seq', 1, false);


--
-- Name: pessoas_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.pessoas_id_seq', 1, false);


--
-- Name: usuarios_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.usuarios_id_seq', 1, false);


--
-- Name: categorias_objetos categoriasObjetos_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.categorias_objetos
    ADD CONSTRAINT "categoriasObjetos_pkey" PRIMARY KEY (id);


--
-- Name: contatos contatos_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.contatos
    ADD CONSTRAINT contatos_pkey PRIMARY KEY (id);


--
-- Name: enderecos enderecos_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.enderecos
    ADD CONSTRAINT enderecos_pkey PRIMARY KEY (id);


--
-- Name: log log_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.log
    ADD CONSTRAINT log_pkey PRIMARY KEY (id);


--
-- Name: objeto_doando objeto_doando_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.objeto_doando
    ADD CONSTRAINT objeto_doando_pkey PRIMARY KEY (id);


--
-- Name: objeto_necessario objeto_necessario_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.objeto_necessario
    ADD CONSTRAINT objeto_necessario_pkey PRIMARY KEY (id);


--
-- Name: objetos objetos_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.objetos
    ADD CONSTRAINT objetos_pkey PRIMARY KEY (id);


--
-- Name: ongs ongs_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ongs
    ADD CONSTRAINT ongs_pkey PRIMARY KEY (id);


--
-- Name: pessoas pessoas_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pessoas
    ADD CONSTRAINT pessoas_pkey PRIMARY KEY (id);


--
-- Name: usuarios usuarios_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.usuarios
    ADD CONSTRAINT usuarios_pkey PRIMARY KEY (id);


--
-- Name: objeto_doando idCategoria_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.objeto_doando
    ADD CONSTRAINT "idCategoria_fkey" FOREIGN KEY ("idCategoria") REFERENCES public.categorias_objetos(id) NOT VALID;


--
-- Name: objeto_necessario idCategoria_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.objeto_necessario
    ADD CONSTRAINT "idCategoria_fkey" FOREIGN KEY ("idCategoria") REFERENCES public.categorias_objetos(id) NOT VALID;


--
-- Name: objetos idCategoria_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.objetos
    ADD CONSTRAINT "idCategoria_fkey" FOREIGN KEY ("idCategoria") REFERENCES public.categorias_objetos(id) NOT VALID;


--
-- Name: log idObjeto_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.log
    ADD CONSTRAINT "idObjeto_fkey" FOREIGN KEY ("idObjeto") REFERENCES public.objetos(id) NOT VALID;


--
-- Name: objeto_doando idObjeto_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.objeto_doando
    ADD CONSTRAINT "idObjeto_fkey" FOREIGN KEY ("idObjeto") REFERENCES public.categorias_objetos(id) NOT VALID;


--
-- Name: usuarios idOng_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.usuarios
    ADD CONSTRAINT "idOng_fkey" FOREIGN KEY ("idOng") REFERENCES public.ongs(id) NOT VALID;


--
-- Name: log idPessoaDoando_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.log
    ADD CONSTRAINT "idPessoaDoando_fkey" FOREIGN KEY ("idPessoaDoando") REFERENCES public.pessoas(id) NOT VALID;


--
-- Name: log idPessoaRecebendo_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.log
    ADD CONSTRAINT "idPessoaRecebendo_fkey" FOREIGN KEY ("idPessoaRecebendo") REFERENCES public.pessoas(id) NOT VALID;


--
-- Name: contatos idPessoa_fKey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.contatos
    ADD CONSTRAINT "idPessoa_fKey" FOREIGN KEY ("idPessoa") REFERENCES public.pessoas(id) NOT VALID;


--
-- Name: enderecos idPessoa_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.enderecos
    ADD CONSTRAINT "idPessoa_fkey" FOREIGN KEY ("idPessoa") REFERENCES public.pessoas(id) NOT VALID;


--
-- Name: objeto_doando idPessoa_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.objeto_doando
    ADD CONSTRAINT "idPessoa_fkey" FOREIGN KEY ("idPessoa") REFERENCES public.pessoas(id) NOT VALID;


--
-- Name: objeto_necessario idPessoa_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.objeto_necessario
    ADD CONSTRAINT "idPessoa_fkey" FOREIGN KEY ("idPessoa") REFERENCES public.pessoas(id) NOT VALID;


--
-- Name: log idUsuarioResponsavel_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.log
    ADD CONSTRAINT "idUsuarioResponsavel_fkey" FOREIGN KEY ("idUsuarioResponsavel") REFERENCES public.usuarios(id) NOT VALID;


--
-- Name: objeto_doando idUsuario_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.objeto_doando
    ADD CONSTRAINT "idUsuario_fkey" FOREIGN KEY ("idUsuario") REFERENCES public.usuarios(id) NOT VALID;


--
-- Name: objeto_necessario idUsuario_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.objeto_necessario
    ADD CONSTRAINT "idUsuario_fkey" FOREIGN KEY ("idUsuario") REFERENCES public.usuarios(id) NOT VALID;


--
-- PostgreSQL database dump complete
--

