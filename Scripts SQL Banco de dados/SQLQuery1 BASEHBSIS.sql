create database BaseDeDadosHbsis 
GO
USE BaseDeDadosHbsis 
GO
CREATE TABLE [UsuarioLocacao] (
    [Id]               INT        NOT NULL,
    [Login]            NCHAR (50) NULL,
    [Senha]            NCHAR (50) NULL,
    [Ativo]            BIT        NULL,
    [UsuarioCriacao]   INT        NULL,
    [UsuarioAlteracao] INT        NULL,
    [DataCriacao]      DATETIME   DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME   DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO
CREATE TABLE [MARCAS] (
    [ID]     INT           IDENTITY (1, 1) NOT NULL,
    [CODIGO] INT           NOT NULL,
    [NOME]   NVARCHAR (60) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
)
GO
CREATE TABLE [Automoveis] (
    [Id]          INT        NOT NULL,
    [NomeTipoVeiculo] NCHAR(10)        NOT NULL,
    [CodigoTipoVeiculo]     INT        NULL,
    [Placa ]      NCHAR (10) NULL,
    [NomeModelo]     NCHAR (50) NULL,
    [Ano]     INT        NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)




