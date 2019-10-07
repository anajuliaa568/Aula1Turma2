insert into Livros
(Nome)
values 
('Guia dos mochileiros da galaxia'),
('O pequeno anão gigante'),
('As longas tranças de um careca'),
('poeira em alto mar'),
('GG easy wp')
GO
select * from Livros


update Livros set Ativo = 0 where Id = 24