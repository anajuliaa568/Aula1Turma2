select gen.Nome, art.Nome,can.Nome from Generos gen 
inner join Artistas art on gen.Id =  Art.GeneroId
inner join Cancoes can on art.Id = can.ArtistasId

select gen.Nome as 'Genero',
Count(art.Nome) as 'Quantidade Artistas'
from Generos gen 
inner join Artistas art on gen.Id = art.GeneroId 
group by gen.Nome

select  gen.Nome as 'Genero',
Count(can.Nome) as 'Quantidade de cancoes'
from Generos gen
inner join Artistas art on gen.Id = art.GeneroId
inner join Cancoes can on art.Id = csn.ArtistaId 
group by gen.Nome

