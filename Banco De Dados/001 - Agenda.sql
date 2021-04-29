CREATE DATABASE Agenda


CREATE TABLE tblcontato(
idcodigo int not null primary key,
nome varchar(75) not null,
email varchar(75) not null,
cep varchar(10) not null,
estados varchar(25) not null,
cidades varchar(35) not null,
celular varchar(15) not null,
telefone varchar (15) null,
anotacap varchar (500) null,)
