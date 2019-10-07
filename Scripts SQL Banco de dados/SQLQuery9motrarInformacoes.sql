select * from Cliente
insert into Pedidos  (Numero,ClienteID,Valor) values 
('N0000001',1,395),
('N0000002',1, 400),
('N0000003',1, 400),
('N0000004',2, 400),
('N0000005',2, 400),
('N0000006',2, 400),
('N0000007',3, 400),
('N0000008',3, 400),
('N0000009',3, 400)

SELECT * FROM Pedidos ped
inner join -- terminador sql que junta as duas informaçoes 
Cliente cli on ped.ClienteID = cli.Id
where cli.Id = 2 -- aqui aplicamos um filtro para estas informaçoes 

SELECT SUM(ped.Valor) FROM Pedidos ped
inner join  Cliente cli on ped.ClienteID = cli.Id
where cli.Id = 2

