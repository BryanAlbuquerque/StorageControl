USE Storage
GO


CREATE TABLE Baixas_Realizadas(
ID_RegistroEmpresarial INT NOT NULL,
PalletID INT NOT NULL, 
Quantidade INT
)

CREATE TABLE Historico_enderecos(
ID_RegistroEmpresarial INT NOT NULL,
PalletID INT NOT NULL,
Endereco NVARCHAR(50)
)

SELECT * FROM Baixas_Realizadas