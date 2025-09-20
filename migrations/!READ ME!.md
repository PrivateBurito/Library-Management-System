## How to migrate DB to your local machine:



**1. Open Terminal inside the migrations directory.**

**2. Input this inside the Terminal:** 

psql -U postgres -d librarymanage -f [.sql file name]
*note: be sure the password to your postgreSQL is also 12345678 in order for the scripts to work



**2.1 Explantion:**

*psgl* = command to call PostgreSQL

*-U postgre*s = input your username, change "postgres" if you use different username in your postgres installation

*-d librarymanage* = the database to be inserted, just create a new database named "librarymanage" or just change the name in the command

*-f \[.sql file name]* = the file containing sql command to be used. example file: "-f 001\_create\_users.sql"



**3 Error found!**

If it says: "psql is not recognized", that means PostgreSQL is not inserted to the environment variables, just google "how to put postgres to env" or something like that, just dont delete random variables there



**Example Command:**

psql -U postgres -d librarymanage -f 001\_create\_users.sql

