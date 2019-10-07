insert into Usuarios
(Nome, Login, Senha) 
values 
('Adagoberto', 'Uridneldson', 'GGtapanasoreia')
GO
select * from Usuarios
update Usuarios set Ativo = 0 where Id = 3 