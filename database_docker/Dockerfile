From mysql

LABEL description="This is docker container which deploy database for dotnet application"

MAINTAINER Mateusz Chmielewski 

ENV MYSQL_ROOT_PASSWORD=qwerty

COPY ./src/ /docker-entrypoint-initdb.d/
