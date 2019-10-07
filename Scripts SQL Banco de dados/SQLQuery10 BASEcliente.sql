select * from Cliente;
select * from Pedidos;


SELECT * FROM Pedidos ped 
where ped.ClienteID in
(select cli.Id from Cliente cli 
           inner join Pedidos ped on cli.Id = ped.ClienteID
where ped.Numero in ('N0000001','N0000006','N0000008')) order by 
ped.Valor desc