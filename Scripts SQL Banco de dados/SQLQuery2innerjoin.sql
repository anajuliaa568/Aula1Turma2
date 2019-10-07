select mar.Nome from Marcas mar
inner join Usuarios usu on mar.UsuInc = usu.Id
where usu.Usuario like 'Felipe%'

select mar.Nome from Marcas mar 
inner join Usuarios usu on mar.UsuInc = usu.Id
where usu.Usuario like 'Giomar%'


/*select USU.Usuario,count (mar.Id) as 'Quntidade'
from Usuarios usu
inner join Marcas mar on usu.Id = mar.UsuInc
where usu.Usuario like 'Felipe%' 
group by usu.Usuario
order by 'Total de marcas' desc;*/
 
/* select USU.Usuario,count (mar.Id) as 'Quntidade'
from Usuarios usu
inner join Marcas mar on usu.Id = mar.UsuInc
where usu.Usuario like 'Giomar%' 
group by usu.Usuario
order by 'Total de marcas' asc;*/

 select USU.Usuario, COUNT(mar.Id) as 'Quantidade' 
from Usuarios usu
inner join Marcas mar on usu.Id = mar.UsuInc
group by usu.Usuario 
order by 'Quantidade' asc;


select usu.Usuario,mar.Id,mar.Nome,car.Modelo
from Usuarios usu
inner join Marcas mar on usu.Id = mar.UsuInc
inner join Carros car on mar.Id = car.Marca
where usu.Usuario like 'Felipe%'

select usu.Usuario,mar.Id,mar.Nome,car.Modelo
from Usuarios usu
inner join Marcas mar on usu.Id = mar.UsuInc
inner join Carros car on mar.Id = car.Marca
where usu.Usuario like 'Giomar%'


select sum(v.valor) as 'Total'
from Vendas as v
where year(DatInc) = '2019'



select
sum(Valor) as 'Total',
year(DatInc)
from Vendas as v
group by year(DatInc);

select
count(quantidade) as 'Total',
Month(DatInc) as 'mes'
from Vendas as v
group by month(DatInc)
order by 'mes' desc;

/*select
count(quantidade) as 'Total'
year (DatAlt)
Month(DatInc) as 'mes' 
from Vendas as v
group by month(DatInc)
order by 'mes' asc;*/

select USU.Usuario, COUNT(v.Id) as 'total' 
from v.vendas 
inner join vendas v on usu.Id = mar.UsuInc
where usu.Usuario like 'Felipe%'
group by vendas 
