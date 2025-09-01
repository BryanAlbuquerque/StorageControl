USE Storage
GO


CREATE TABLE Baixas_Realizadas(
Data_Realizada DATETIME,
ID_RegistroEmpresarial INT NOT NULL,
PalletID INT NOT NULL, 
Setor_Solicitante NVARCHAR(50),
Quantidade INT
)


SELECT * FROM Baixas_Realizadas
