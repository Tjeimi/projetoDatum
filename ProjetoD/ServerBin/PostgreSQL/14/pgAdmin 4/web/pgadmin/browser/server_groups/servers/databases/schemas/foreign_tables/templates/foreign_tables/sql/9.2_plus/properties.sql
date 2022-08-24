SELECT
    c.oid, c.relname AS name, c.relacl, pg_catalog.pg_get_userbyid(relowner) AS owner,
    ftoptions, srvname AS ftsrvname, description, nspname as basensp, consrc,
    (SELECT
        pg_catalog.array_agg(provider || '=' || label)
    FROM
        pg_catalog.pg_seclabel sl1
    WHERE
        sl1.objoid=c.oid) AS seclabels
FROM
    pg_catalog.pg_class c
JOIN
    pg_catalog.pg_foreign_table ft ON c.oid=ft.ftrelid
LEFT OUTER JOIN
    pg_catalog.pg_foreign_server fs ON ft.ftserver=fs.oid
LEFT OUTER JOIN
    pg_catalog.pg_description des ON (des.objoid=c.oid AND des.classoid='pg_class'::regclass)
LEFT OUTER JOIN
    pg_catalog.pg_namespace nsp ON (nsp.oid=c.relnamespace)
LEFT OUTER JOIN
    pg_catalog.pg_constraint cn ON (cn.conrelid=c.oid)
WHERE
    c.relnamespace = {{scid}}::oid
    {% if foid %}
    AND c.oid = {{foid}}::oid
    {% endif %}
ORDER BY c.relname;
