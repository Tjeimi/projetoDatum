@ECHO OFF
@SET PATH="%~dp0\bin";%PATH%
@SET PGDATA=%~dp0\data
@SET PGDATABASE=postgres
@SET PGUSER=postgres
@SET PGPORT=5434
@SET PGLOCALEDIR=%~dp0\share\locale
"%~dp0\bin\initdb" -U postgres -A trust -E 'UTF-8' --lc-collate=pt_BR.UTF-8
"%~dp0\bin\pg_ctl" -D "%~dp0/data" -l logfile start