-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 01-Jul-2023 às 09:37
-- Versão do servidor: 10.4.27-MariaDB
-- versão do PHP: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `bdguizzo`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_cliente`
--

CREATE TABLE `tb_cliente` (
  `idcliente` int(10) NOT NULL,
  `idendereco` int(10) NOT NULL,
  `cnpj` varchar(45) NOT NULL,
  `razao_social` varchar(45) NOT NULL,
  `inscricao_estadual` varchar(45) NOT NULL,
  `statuscadastro` varchar(20) NOT NULL DEFAULT 'PENDENTE',
  `logo` varchar(150) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Extraindo dados da tabela `tb_cliente`
--

INSERT INTO `tb_cliente` (`idcliente`, `idendereco`, `cnpj`, `razao_social`, `inscricao_estadual`, `statuscadastro`, `logo`) VALUES
(3, 3, '122', 'Guizzo', '122', 'Aprovada', 'C:\\Users\\guifo\\Source\\Repos\\GuinaF2\\GuizzoLtdaRepo\\GuizzoLtda\\IMAGES\\GuiZzo Logo.png');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_endereco`
--

CREATE TABLE `tb_endereco` (
  `idendereco` int(10) NOT NULL,
  `rua` varchar(100) NOT NULL,
  `bairro` varchar(45) NOT NULL,
  `cep` varchar(10) NOT NULL,
  `cidade` varchar(15) NOT NULL,
  `estado` varchar(15) NOT NULL,
  `numero` varchar(10) NOT NULL,
  `complemento` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Extraindo dados da tabela `tb_endereco`
--

INSERT INTO `tb_endereco` (`idendereco`, `rua`, `bairro`, `cep`, `cidade`, `estado`, `numero`, `complemento`) VALUES
(3, 'a', 'a', '1', 'a', 'a', '1', 'a');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_funcionario`
--

CREATE TABLE `tb_funcionario` (
  `idfuncionario` int(10) NOT NULL,
  `NomeUser` varchar(50) NOT NULL,
  `SenhaUser` varchar(50) NOT NULL,
  `cargo` int(10) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Extraindo dados da tabela `tb_funcionario`
--

INSERT INTO `tb_funcionario` (`idfuncionario`, `NomeUser`, `SenhaUser`, `cargo`) VALUES
(1, 'Guina', '2', 2),
(2, 'Tizzo', '9', 2),
(3, 'g', '1', 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_motorista`
--

CREATE TABLE `tb_motorista` (
  `idmotorista` int(10) NOT NULL,
  `idveiculo` int(10) NOT NULL,
  `cpf` varchar(20) NOT NULL,
  `registrogeral` varchar(50) DEFAULT NULL,
  `carteiramotorista` varchar(10) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `tipocarteira` varchar(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Extraindo dados da tabela `tb_motorista`
--

INSERT INTO `tb_motorista` (`idmotorista`, `idveiculo`, `cpf`, `registrogeral`, `carteiramotorista`, `nome`, `tipocarteira`) VALUES
(1, 2, '12345678910', '123456789', '1234567890', 'Guilherme', 'A');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_pedido`
--

CREATE TABLE `tb_pedido` (
  `idpedido` int(10) NOT NULL,
  `idmotorista` int(10) NOT NULL,
  `idcliente` int(10) NOT NULL,
  `nmrvolumes` int(10) NOT NULL,
  `statuspedido` varchar(45) NOT NULL DEFAULT 'PENDENTE',
  `valorpedido` float NOT NULL,
  `dtpedido` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_solicitacao`
--

CREATE TABLE `tb_solicitacao` (
  `idsolicitacao` int(10) NOT NULL,
  `tipo_solicit` varchar(50) NOT NULL,
  `descricao` varchar(200) NOT NULL,
  `condicao` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_veiculo`
--

CREATE TABLE `tb_veiculo` (
  `idveiculo` int(10) NOT NULL,
  `placa_motorista` varchar(7) NOT NULL,
  `tipo_veiculo` varchar(15) NOT NULL,
  `seguro_data` varchar(10) NOT NULL,
  `renavam` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Extraindo dados da tabela `tb_veiculo`
--

INSERT INTO `tb_veiculo` (`idveiculo`, `placa_motorista`, `tipo_veiculo`, `seguro_data`, `renavam`) VALUES
(2, 'AAA1234', 'Carro', '26062023', '12345678900'),
(3, 'AYS6692', 'Caminhão', '28052022', '12345678910');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `tb_cliente`
--
ALTER TABLE `tb_cliente`
  ADD PRIMARY KEY (`idcliente`),
  ADD UNIQUE KEY `cnpj` (`cnpj`),
  ADD UNIQUE KEY `inscricao_estadual` (`inscricao_estadual`),
  ADD KEY `fk_endereco2` (`idendereco`);

--
-- Índices para tabela `tb_endereco`
--
ALTER TABLE `tb_endereco`
  ADD PRIMARY KEY (`idendereco`);

--
-- Índices para tabela `tb_funcionario`
--
ALTER TABLE `tb_funcionario`
  ADD PRIMARY KEY (`idfuncionario`),
  ADD UNIQUE KEY `NomeUser` (`NomeUser`);

--
-- Índices para tabela `tb_motorista`
--
ALTER TABLE `tb_motorista`
  ADD PRIMARY KEY (`idmotorista`),
  ADD UNIQUE KEY `cpf` (`cpf`),
  ADD UNIQUE KEY `carteiramotorista` (`carteiramotorista`),
  ADD UNIQUE KEY `registrogeral` (`registrogeral`),
  ADD KEY `fk_veiculo` (`idveiculo`);

--
-- Índices para tabela `tb_pedido`
--
ALTER TABLE `tb_pedido`
  ADD PRIMARY KEY (`idpedido`),
  ADD KEY `fk_motorista` (`idmotorista`),
  ADD KEY `fk_cliente` (`idcliente`);

--
-- Índices para tabela `tb_solicitacao`
--
ALTER TABLE `tb_solicitacao`
  ADD PRIMARY KEY (`idsolicitacao`);

--
-- Índices para tabela `tb_veiculo`
--
ALTER TABLE `tb_veiculo`
  ADD PRIMARY KEY (`idveiculo`),
  ADD UNIQUE KEY `placa_motorista` (`placa_motorista`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tb_cliente`
--
ALTER TABLE `tb_cliente`
  MODIFY `idcliente` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `tb_endereco`
--
ALTER TABLE `tb_endereco`
  MODIFY `idendereco` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `tb_funcionario`
--
ALTER TABLE `tb_funcionario`
  MODIFY `idfuncionario` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `tb_motorista`
--
ALTER TABLE `tb_motorista`
  MODIFY `idmotorista` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `tb_pedido`
--
ALTER TABLE `tb_pedido`
  MODIFY `idpedido` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `tb_solicitacao`
--
ALTER TABLE `tb_solicitacao`
  MODIFY `idsolicitacao` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `tb_veiculo`
--
ALTER TABLE `tb_veiculo`
  MODIFY `idveiculo` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `tb_cliente`
--
ALTER TABLE `tb_cliente`
  ADD CONSTRAINT `fk_endereco2` FOREIGN KEY (`idendereco`) REFERENCES `tb_endereco` (`idendereco`) ON UPDATE CASCADE;

--
-- Limitadores para a tabela `tb_motorista`
--
ALTER TABLE `tb_motorista`
  ADD CONSTRAINT `fk_veiculo` FOREIGN KEY (`idveiculo`) REFERENCES `tb_veiculo` (`idveiculo`) ON UPDATE CASCADE;

--
-- Limitadores para a tabela `tb_pedido`
--
ALTER TABLE `tb_pedido`
  ADD CONSTRAINT `fk_cliente` FOREIGN KEY (`idcliente`) REFERENCES `tb_cliente` (`idcliente`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_motorista` FOREIGN KEY (`idmotorista`) REFERENCES `tb_motorista` (`idmotorista`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
