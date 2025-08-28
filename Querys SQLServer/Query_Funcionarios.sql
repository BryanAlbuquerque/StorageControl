CREATE DATABASE Storage

USE Storage
GO

CREATE TABLE Funcionarios(
ID_RegistroEmpresarial INT PRIMARY KEY IDENTITY (1,1),
Nome VARCHAR (100) NOT NULL,
CPF CHAR(11) NOT NULL UNIQUE,
RG VARCHAR (15) NOT NULL UNIQUE,
Data_Nascimento DATE NOT NULL,
Email NVARCHAR(50) NOT NULL,
Telefone BIGINT NOT NULL,
Endereco NVARCHAR (50) NOT NULL,
Cargo VARCHAR(50) NOT NULL,
Situacao VARCHAR(20)
)


INSERT INTO Funcionarios
(Nome, CPF, RG, Data_Nascimento, Email, Telefone, Endereco, Cargo, Situacao)
VALUES
('Bryan Albuquerque', '52341546889', '509464956', '2005-05-07', 'bryanalburquerque2@gmail.com', 11974217641, 'Rua Palmira crepaldi', 'Dev Junior', 'Ativo'),
('Ana Souza', '12345678901', 'MG1234567', '1985-04-12', 'ana.souza@email.com', 31987654321, 'Rua das Flores, 123', 'Analista', 'Ativo'),
('Bruno Lima', '23456789012', 'SP2345678', '1990-07-23', 'bruno.lima@email.com', 11998765432, 'Av. Paulista, 1000', 'Gerente', 'Ativo'),
('Carla Mendes', '34567890123', 'RJ3456789', '1988-02-05', 'carla.mendes@email.com', 21987654321, 'Rua das Laranjeiras, 50', 'Assistente', 'Ativo'),
('Diego Santos', '45678901234', 'MG4567890', '1995-09-15', 'diego.santos@email.com', 31912345678, 'Rua do Sol, 200', 'Supervisor', 'Inativo'),
('Eduarda Ribeiro', '56789012345', 'SP5678901', '1982-12-30', 'eduarda.ribeiro@email.com', 11912345678, 'Av. Brasil, 300', 'Analista', 'Ativo'),
('Fernando Costa', '67890123456', 'RJ6789012', '1991-03-22', 'fernando.costa@email.com', 21912345678, 'Rua da Paz, 400', 'Assistente', 'Ativo'),
('Gabriela Alves', '78901234567', 'MG7890123', '1987-06-18', 'gabriela.alves@email.com', 31987651234, 'Rua das Acácias, 500', 'Gerente', 'Ativo'),
('Hugo Ferreira', '89012345678', 'SP8901234', '1993-11-11', 'hugo.ferreira@email.com', 11987654321, 'Av. Liberdade, 600', 'Analista', 'Inativo'),
('Isabela Martins', '90123456789', 'RJ9012345', '1990-01-25', 'isabela.martins@email.com', 21987651234, 'Rua das Palmeiras, 700', 'Assistente', 'Ativo'),
('João Pedro', '01234567890', 'MG0123456', '1985-08-08', 'joao.pedro@email.com', 31912349876, 'Rua dos Lírios, 800', 'Supervisor', 'Ativo');

SELECT * FROM Funcionarios
