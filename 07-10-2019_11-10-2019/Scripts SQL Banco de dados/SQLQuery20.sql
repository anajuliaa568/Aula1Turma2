update Livros set ativo = 0 where Id = (select Id from Livros order By Id desc offset 
1 rows fetch next 1 rows only)