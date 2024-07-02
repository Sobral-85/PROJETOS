CREATE TABLE FUNCIONARIOS (
[CODIGO] INT PRIMARY KEY IDENTITY,
[PRIMEIRO NOME] VARCHAR(45) NOT NULL,
[SEGUNDO NOME] VARCHAR(45) NOT NULL,
[ULTIMO NOME] VARCHAR(45) NOT NULL,
[DATA NASCIMENTO] DATE,
[CPF] VARCHAR(15) NOT NULL,
[RG] VARCHAR(15)NOT NULL,
[ENDERECO] VARCHAR(50)NOT NULL,
[CEP] VARCHAR(12)NOT NULL,
[CIDADE] VARCHAR(50)NOT NULL,
[FONE]VARCHAR(15) NOT NULL,
[FUNCAO]VARCHAR(50) NOT NULL,
[C�DIGO DEPARTAMENTO] VARCHAR(50) NOT NULL,
[FUNC�O] VARCHAR(50)NOT NULL,
[SALARIO] DECIMAL(18,2)NOT NULL);

CREATE TABLE DEPARTAMENTOS(
[C�DIGO DEPARTAMENTO] INT PRIMARY KEY,
[NOME] VARCHAR(50) NOT NULL,
[C�DIGO FUNCION�RIO GERENTE] INT NOT NULL,
);

ALTER TABLE[FUNCIONARIOS] ALTER COLUMN [C�DIGO DEPARTAMENTO] INT;

ALTER TABLE IDE
ADD CONSTRAINT IDE_UF_FK FOREIGN KEY (Cod_UF) REFERENCES UF (ID_UF);

ALTER TABLE FUNCIONARIOS
ADD CONSTRAINT [C�DIGO DEPARTAMENTO_FK] FOREIGN KEY ([C�DIGO DEPARTAMENTO]) REFERENCES DEPARTAMENTOS([C�DIGO DEPARTAMENTO]);

