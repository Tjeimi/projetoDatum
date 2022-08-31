@ECHO OFF
@SET PATH="%~dp0\bin";%PATH%
@SET PGDATA=%~dp0\data
@SET PGDATABASE=postgres
@SET PGUSER=postgres
@SET PGPORT=5432
@SET PGLOCALEDIR=%~dp0\share\locale
"%~dp0\bin\initdb" -U postgres -A trust
"%~dp0\bin\pg_ctl" -D "%~dp0/data" -l logfile start