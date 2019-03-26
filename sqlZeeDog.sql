CREATE DATABASE bdZeeDog
GO
USE bdZeeDog
GO
CREATE TABLE Servico(
	codServico  CHAR(7) PRIMARY KEY  NOT NULL,
	nome		VARCHAR(80) NOT NULL,
	descricao	VARCHAR(100) NOT NULL,
	valorServico DECIMAL(9,2) NOT NULL,
	);

CREATE TABLE Cliente (
	codCliente CHAR(7) PRIMARY KEY NOT NULL,
	dataCadastro	CHAR(20) NOT NULL,
	dataNascimento	CHAR(12) NOT NULL,
	nome			VARCHAR(80) NOT NULL,
	rg				CHAR(10) NOT NULL,
	telefone		CHAR(10) NOT NULL,
	email			VARCHAR(50) NOT NULL,
	endereco		VARCHAR(50) NULL,
	cidade			VARCHAR(30) NOT NULL,
	estado			VARCHAR(30) NOT NULL,
	pais			VARCHAR(20) NOT NULL,
	);

CREATE TABLE Animal(
	codAnimal CHAR(7) PRIMARY KEY NOT NULL,
	cliente_codCliente CHAR(7) NOT NULL,
	FOREIGN KEY (cliente_codCliente) 
		REFERENCES cliente(codCliente),
	nome	VARCHAR(80) NOT NULL,
	anoNascimento	INT NOT NULL,
	peso	FLOAT NOT NULL,
	grupo	VARCHAR(30) NOT NULL,
	raca	VARCHAR(30) NOT NULL,
	genero	CHAR(5) NULL,
	vacinacao CHAR(3) NULL,
	comportamento VARCHAR(20) NULL 
);

CREATE TABLE Agendamento(
	codAgendamento CHAR(7) PRIMARY KEY NOT NULL,
	animal_codAnimal	   CHAR(7) NOT NULL,
	FOREIGN KEY (animal_codAnimal)
		REFERENCES Animal(codAnimal),
	servico_codServico	   CHAR(7) NOT NULL,
	FOREIGN KEY(servico_codServico)
		REFERENCES Servico(codServico),
	codVeterinario INT NOT NULL,
	dataPrevista CHAR(20) NOT NULL,
	horaPrevista CHAR(5) NOT NULL,	
	dataExecucao CHAR(20) NOT NULL,
	horaExecucao CHAR(20) NOT NULL,
	observacoes  VARCHAR(100) NULL
);


CREATE TABLE Funcionario(
	codFuncionario CHAR(7) PRIMARY KEY NOT NULL,
	dataCadastro	CHAR(20) NOT NULL,
	dataNascimento  CHAR(20) NOT NULL,
	nome			VARCHAR(80) NOT NULL,
	rg				CHAR(10) NOT NULL,
	telefone		CHAR(20) NULL,
	email			VARCHAR(40) NULL,
	endereco		VARCHAR(50) NOT NULL,
	cidade			VARCHAR(30) NOT NULL,
	estado			VARCHAR(30) NOT NULL,
	pais			VARCHAR(20) NOT NULL,
	codTipo			INT NOT NULL,
	senha			VARCHAR (30) NOT NULL,
	);

CREATE TABLE ExecucaoServico(
	codExecucao CHAR(7) PRIMARY KEY NOT NULL,
	animal_codAnimal CHAR(7) NOT NULL,
	FOREIGN KEY (animal_codAnimal)
		REFERENCES Animal(codAnimal),
	servico_codServico CHAR(7) NOT NULL,
	FOREIGN KEY (servico_codServico)
		REFERENCES Servico(codServico),
	funcionario_codFuncionario CHAR(7) NOT NULL,
	FOREIGN KEY (funcionario_codFuncionario)
		REFERENCES Funcionario(codFuncionario),
	dataPrevista CHAR(12) NOT NULL,
	horaPrevista CHAR(5) NOT NULL,
	);

	CREATE TABLE ExecucaoAgendamento(
	codExecucaoA CHAR(7) PRIMARY KEY NOT NULL,
	animal_codAnimal CHAR(7) NOT NULL,
	FOREIGN KEY (animal_codAnimal)
		REFERENCES Animal(codAnimal),
	servico_codServico CHAR(7) NOT NULL,
	FOREIGN KEY (servico_codServico)
		REFERENCES Servico(codServico),
	funcionario_codFuncionario CHAR(7) NOT NULL,
	FOREIGN KEY (funcionario_codFuncionario)
		REFERENCES Funcionario(codFuncionario),
	dataExecucao CHAR(12) NOT NULL,
	horaExecucao CHAR(5) NOT NULL,
	);
	-- drop database bdZeeDog
	-- select * from Funcionario
	-- select * from ExecucaoServico
	-- select * from Servico
	-- select * from Agendamento
		--use master

	-- INSERT INTO Funcionario (dataCadastro,dataNascimento,nome,rg,telefone,email,endereco,cidade,estado,pais,codTipo,senha) VALUES ('2002/01/21 13:58:07','21/01/2002','Thales','12345678','991408741','admin@gmail.com','Rua João Dornas Filho','Belo Horizonte','Minas Gerais','Brasil','1','adm123')
    -- INSERT INTO Funcionario (dataCadastro,dataNascimento,nome,rg,telefone,email,endereco,cidade,estado,pais,codTipo,senha) VALUES ('2002/01/21 13:58:07','21/01/2002','Thales','87654321','991408741','admin2@gmail.com','Rua João Dornas Filho','Belo Horizonte','Minas Gerais','Brasil','2','adm123')

	-- DROP TABLE ExecucaoServico
	-- SELECT  E.dataPrevista,E.horaPrevista,F.codFuncionario,F.nome  FROM ExecucaoServico AS E INNER JOIN Funcionario AS F ON E.funcionario_codFuncionario = F.codFuncionario WHERE F.codTipo = 3
	-- SELECT A.nome, C.nome, C.telefone FROM Animal AS A INNER JOIN Cliente AS C ON A.cliente_codCliente = C.codCliente
	-- SELECT SUM(S.valorServico) FROM Servico AS S INNER JOIN ExecucaoAgendamento AS E ON S.codServico = E.servico_codServico WHERE E.dataExecucao = '21/%'
INSERT INTO Funcionario(codFuncionario,dataNascimento,dataCadastro,nome,rg,telefone,email,endereco,cidade,estado,pais,codTipo,senha) 
	VALUES ('FUNC001','21/01/2002','26/11/2018','Admnistrador','12345678','31991408741','adm@gmail.com','Rua João Dornas 109','Belo Horizonte','Minas Gerais','Brasil',1,'adm');
INSERT INTO Funcionario(codFuncionario,dataNascimento,dataCadastro,nome,rg,telefone,email,endereco,cidade,estado,pais,codTipo,senha) 
	VALUES ('FUNC002','21/01/2002','26/11/2018','Balconista','12345678','31991408741','balconista@gmail.com','Rua João Dornas 109','Belo Horizonte','Minas Gerais','Brasil',2,'balconista');

	SELECT * FROM Funcionario;