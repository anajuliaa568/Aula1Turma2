create database BaseSistemaLocacao --CRIAMOS NOSSA BASE DE DADOS 
GO
USE BaseSistemaLocacao -- INDICAMOS QUE ESTAMOS UTILIZANDO ELA PARA OS COMANDOS ABAIXO
GO
CREATE TABLE [dbo].[Carros] (
    [Id]               INT        NOT NULL,
    [Modelo ]          NCHAR (50) NULL,
    [Marca]            INT NOT NULL,
    [Placa]            NCHAR (7)  NULL,
    [Ano ]             INT        NULL,
    [Ativo]            BIT        NULL,
    [UsuarioCriacao]   INT        NULL,
    [UsuarioAlteracao] INT        NULL,
    [DataCriacao]      DATETIME   DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME   DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO

CREATE TABLE [dbo].[locacao] (
    [Id]               INT      IDENTITY (1, 1) NOT NULL,
    [UsuarioId]        INT      NULL,
    [CarroId]          INT      NULL,
    [Valor ]           MONEY    NULL,
    [DataInicial]      DATETIME DEFAULT (getdate()) NULL,
    [DataDevolucao]    DATETIME DEFAULT (dateadd(day,(5),getdate())) NULL,
    [Ativo]            BIT      NULL,
    [UsuarioCriacao]   INT      NULL,
    [UsuarioAlteracao] INT      NULL,
    [DataCriacao]      DATETIME DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO
CREATE TABLE [dbo].[Marcas] (
    [Id]     INT        IDENTITY (1, 1) NOT NULL,
    [Codigo] INT        NULL,
    [Nome]   NCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO
CREATE TABLE [dbo].[Usuarios] (
    [Id]               INT         NOT NULL,
    [Nome]             NCHAR (100) NULL,
    [Login]            NCHAR (50)  NULL,
    [Senha]            NCHAR (50)  NULL,
    [Ativo ]           BIT         NULL,
    [UsuarioCriacao]   INT         NULL,
    [UsuarioAlteracao] INT         NULL,
    [DataCriacao]      DATETIME    DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME    DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO
insert into Usuarios (Login,Senha)
values ('Admin', 'Admin')
GO
insert into Marcas (Codigo,Nome)
values (1,'Volkswagen'),
(2,'Chevralet'),
(3,'HONDA')