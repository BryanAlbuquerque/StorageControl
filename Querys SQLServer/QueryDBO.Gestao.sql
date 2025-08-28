USE Storage
GO

CREATE TABLE Gestao(
    Endereco VARCHAR(20),
    PalletID INT PRIMARY KEY NOT NULL,
    DataEntrada DATE NOT NULL,
    NomeInsumo VARCHAR(50) NOT NULL,
    Fornecedor VARCHAR(50) NOT NULL,
    Quantidade INT NOT NULL,
    ValorUnitario VARCHAR(20) NOT NULL,
    ValorTotal VARCHAR(20) NOT NULL,
    NumeroNotaFiscal BIGINT NOT NULL,
    NumeroPedido VARCHAR(20) NOT NULL,
    Consumo INT,
    QuantidadeAtual INT,
	RE_Colaborador INT NOT NULL
)



SELECT * FROM Gestao


ALTER TABLE Gestao
ALTER COLUMN  QuantidadeAtual int;


ALTER TABLE Gestao
ADD RE_Colaborador INT NOT NULL


UPDATE Gestao
SET Quantidade = 125
WHERE PalletID = 304491;

