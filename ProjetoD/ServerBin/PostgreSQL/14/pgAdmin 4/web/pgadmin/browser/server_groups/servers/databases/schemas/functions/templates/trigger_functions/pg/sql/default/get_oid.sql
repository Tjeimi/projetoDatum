SELECT
    pr.oid, pr.proname || '(' || COALESCE(pg_catalog
    .pg_get_function_identity_arguments(pr.oid), '') || ')' as name,
    lanname, pg_catalog.pg_get_userbyid(proowner) as funcowner, pr.pronamespace AS nsp
FROM
    pg_catalog.pg_proc pr
JOIN
    pg_catalog.pg_type typ ON typ.oid=prorettype
JOIN
    pg_catalog.pg_language lng ON lng.oid=prolang
JOIN
    pg_catalog.pg_namespace nsp ON nsp.oid=pr.pronamespace
    AND nsp.nspname={{ nspname|qtLiteral }}
WHERE
    proisagg = FALSE
    AND typname = 'trigger' AND lanname != 'edbspl'
    AND pr.proname = {{ name|qtLiteral }};