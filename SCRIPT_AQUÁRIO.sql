CREATE DATABASE GERENCIAMENTOAQUARIO;

CREATE TABLE lancamento(
id_lancamento INT PRIMARY KEY IDENTITY,
tipo NVARCHAR(50) NOT NULL,
descricao NVARCHAR(50) NOT NULL, 
valor DECIMAL(18,2) NOT NULL,
mes NVARCHAR(50) NOT NULL,
id_ano int NOT NULL,
CONSTRAINT FK_anoLancamento FOREIGN KEY (id_ano) REFERENCES ano (id_ano)
);

ALTER TABLE lancamento
ADD CONSTRAINT FK_anoLancamento FOREIGN KEY (id_ano) REFERENCES ano (id_ano);


CREATE TABLE ano(
id_ano int PRIMARY KEY IDENTITY NOT NULL,
ano int NOT NULL,
);


DROP TABLE lancamento;

id_lancamento