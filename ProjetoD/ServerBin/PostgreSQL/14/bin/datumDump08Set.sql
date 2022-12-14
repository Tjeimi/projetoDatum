PGDMP         -                z            datum    14.4    14.4                 0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            !           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            "           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            #           1262    16384    datum    DATABASE     ?   CREATE DATABASE datum WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'pt_BR.UTF-8' LC_CTYPE = 'Portuguese_Brazil.1252';
    DROP DATABASE datum;
                postgres    false            ?            1259    16385    categoriasobjetos    TABLE     {   CREATE TABLE public.categoriasobjetos (
    id bigint NOT NULL,
    categoria character varying(128),
    ativo boolean
);
 %   DROP TABLE public.categoriasobjetos;
       public         heap    postgres    false            ?            1259    16448    cidades    TABLE     n   CREATE TABLE public.cidades (
    id bigint NOT NULL,
    idestado bigint,
    nome character varying(128)
);
    DROP TABLE public.cidades;
       public         heap    postgres    false            ?            1259    16390    contatos    TABLE     ?   CREATE TABLE public.contatos (
    id bigint NOT NULL,
    idpessoa bigint,
    tipocontato character varying(128),
    contato character varying(128)
);
    DROP TABLE public.contatos;
       public         heap    postgres    false            ?            1259    16403    dadosong    TABLE     8  CREATE TABLE public.dadosong (
    id bigint NOT NULL,
    ativo boolean,
    nome character varying(128),
    endereco character varying(128),
    cidade character varying(128),
    estado character varying(128),
    fone character varying(128),
    email character varying(128),
    idcidadeparceria bigint
);
    DROP TABLE public.dadosong;
       public         heap    postgres    false            ?            1259    16393 	   enderecos    TABLE       CREATE TABLE public.enderecos (
    id bigint NOT NULL,
    idpessoa bigint,
    tipoendereco character varying(128),
    endereco character varying(128),
    bairro character varying(128),
    cidade character varying(128),
    estado character varying(128)
);
    DROP TABLE public.enderecos;
       public         heap    postgres    false            ?            1259    16445    estados    TABLE     z   CREATE TABLE public.estados (
    id bigint NOT NULL,
    nome character varying(128),
    sigla character varying(32)
);
    DROP TABLE public.estados;
       public         heap    postgres    false            ?            1259    16422    log    TABLE     ?   CREATE TABLE public.log (
    id bigint NOT NULL,
    idpessoadoando bigint,
    idpessoarecebendo bigint,
    idobjeto bigint,
    idusuarioresponsavel bigint,
    status character varying(64)
);
    DROP TABLE public.log;
       public         heap    postgres    false            ?            1259    16398    objetos    TABLE     ?   CREATE TABLE public.objetos (
    id bigint NOT NULL,
    idcategoria bigint,
    objeto character varying(128),
    imagem character varying(128),
    descricao character varying(128),
    status character varying(128)
);
    DROP TABLE public.objetos;
       public         heap    postgres    false            ?            1259    16419    objetosdoando    TABLE     ?   CREATE TABLE public.objetosdoando (
    id bigint NOT NULL,
    idpessoa bigint,
    idcategoria bigint,
    idusuario bigint,
    idobjeto bigint,
    status bit varying(128)
);
 !   DROP TABLE public.objetosdoando;
       public         heap    postgres    false            ?            1259    16425    objetosnecessarios    TABLE     ?   CREATE TABLE public.objetosnecessarios (
    id bigint NOT NULL,
    idpessoa bigint,
    idcategoria bigint,
    idusuario bigint,
    status character varying(128)
);
 &   DROP TABLE public.objetosnecessarios;
       public         heap    postgres    false            ?            1259    16408    pessoas    TABLE     ~   CREATE TABLE public.pessoas (
    id bigint NOT NULL,
    idong bigint,
    nome character varying(128),
    ativo boolean
);
    DROP TABLE public.pessoas;
       public         heap    postgres    false            ?            1259    16411    usuarios    TABLE     ?   CREATE TABLE public.usuarios (
    id bigint NOT NULL,
    idong bigint,
    username character varying(128),
    password character varying(128),
    nome character varying(128),
    fone character varying(128),
    ativo character varying(128)
);
    DROP TABLE public.usuarios;
       public         heap    postgres    false                      0    16385    categoriasobjetos 
   TABLE DATA                 public          postgres    false    209   G                 0    16448    cidades 
   TABLE DATA                 public          postgres    false    220   a                 0    16390    contatos 
   TABLE DATA                 public          postgres    false    210   {                 0    16403    dadosong 
   TABLE DATA                 public          postgres    false    213   ?                 0    16393 	   enderecos 
   TABLE DATA                 public          postgres    false    211   ?                 0    16445    estados 
   TABLE DATA                 public          postgres    false    219   ?                 0    16422    log 
   TABLE DATA                 public          postgres    false    217   ?                 0    16398    objetos 
   TABLE DATA                 public          postgres    false    212   ?                 0    16419    objetosdoando 
   TABLE DATA                 public          postgres    false    216                    0    16425    objetosnecessarios 
   TABLE DATA                 public          postgres    false    218   1                 0    16408    pessoas 
   TABLE DATA                 public          postgres    false    214   K                 0    16411    usuarios 
   TABLE DATA                 public          postgres    false    215   e          
   x???             
   x???             
   x???             
   x???             
   x???             
   x???             
   x???             
   x???             
   x???             
   x???             
   x???             
   x???         