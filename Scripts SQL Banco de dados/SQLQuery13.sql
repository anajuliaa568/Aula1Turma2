DROP TABLE LIVROS

CREATE TABLE LIVRO(
ID INTEGER PRIMARY KEY,
NOME VARCHAR(60),
ativo bit, 
UsuarioCriacao int, 
UsuarioAlteracao int,
datacriacao datetime,
dataalteracao datetime
)