USE Storage
GO


CREATE TABLE Baixas_Realizadas(
Data_Atual DATETIME,
ID_RegistroEmpresarial INT NOT NULL,
PalletID INT NOT NULL, 
Quantidade INT
)


SELECT * FROM Baixas_Realizadas