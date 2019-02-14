#!/bin/bash
set -e

psql -v ON_ERROR_STOP=1 --username "$POSTGRES_USER" --dbname "$POSTGRES_DB" <<-EOSQL
    CREATE DATABASE ${PROD_DB};
    CREATE DATABASE ${DEV_DB};
    CREATE DATABASE ${TEST_DB};
EOSQL
