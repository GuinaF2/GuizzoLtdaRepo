-- phpMyAdmin SQL Dump
-- version 4.8.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 20-Maio-2023 às 21:32
-- Versão do servidor: 10.1.32-MariaDB
-- PHP Version: 7.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bdguizzo`
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
  `logo` varchar(150) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_endereco`
--

CREATE TABLE `tb_endereco` (
  `idendereco` int(10) NOT NULL,
  `rua` varchar(100) NOT NULL,
  `bairro` varchar(45) NOT NULL,
  `cep` varchar(10) NOT NULL,
  `numero` varchar(10) NOT NULL,
  `complemento` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_funcionario`
--

CREATE TABLE `tb_funcionario` (
  `idfuncionario` int(10) NOT NULL,
  `NomeUser` varchar(50) NOT NULL,
  `SenhaUser` varchar(50) NOT NULL,
  `cargo` int(10) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_funcionario`
--

INSERT INTO `tb_funcionario` (`idfuncionario`, `NomeUser`, `SenhaUser`, `cargo`) VALUES
(6, 'G', 'g', 1),
(9, 'p', 'p', 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_motoristas`
--

CREATE TABLE `tb_motoristas` (
  `idmotorista` int(10) NOT NULL,
  `idveiculo` int(10) NOT NULL,
  `idfuncionario` int(10) NOT NULL,
  `carteira_de_motorista` varchar(20) NOT NULL,
  `roteiro_viagem` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_pedido`
--

CREATE TABLE `tb_pedido` (
  `idpedido` int(10) NOT NULL,
  `idendereco` int(10) NOT NULL,
  `idcliente` int(10) NOT NULL,
  `idmotorista` int(10) NOT NULL,
  `tipopedido` varchar(45) NOT NULL,
  `est_pedido` varchar(45) NOT NULL,
  `dtpedido` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_veiculo`
--

CREATE TABLE `tb_veiculo` (
  `idveiculo` int(10) NOT NULL,
  `placa_mototorista` varchar(7) NOT NULL,
  `tipo_veiculo` varchar(40) NOT NULL,
  `rota_veiculo` int(3) NOT NULL,
  `seguro_data` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_cliente`
--
ALTER TABLE `tb_cliente`
  ADD PRIMARY KEY (`idcliente`),
  ADD KEY `fk_endereco2` (`idendereco`);

--
-- Indexes for table `tb_endereco`
--
ALTER TABLE `tb_endereco`
  ADD PRIMARY KEY (`idendereco`);

--
-- Indexes for table `tb_funcionario`
--
ALTER TABLE `tb_funcionario`
  ADD PRIMARY KEY (`idfuncionario`);

--
-- Indexes for table `tb_motoristas`
--
ALTER TABLE `tb_motoristas`
  ADD PRIMARY KEY (`idmotorista`),
  ADD KEY `fk_veiculo` (`idveiculo`),
  ADD KEY `fk_funcionario` (`idfuncionario`);

--
-- Indexes for table `tb_pedido`
--
ALTER TABLE `tb_pedido`
  ADD PRIMARY KEY (`idpedido`),
  ADD KEY `fk_endereco3` (`idendereco`),
  ADD KEY `fk_cliente` (`idcliente`),
  ADD KEY `fk_motorista` (`idmotorista`);

--
-- Indexes for table `tb_veiculo`
--
ALTER TABLE `tb_veiculo`
  ADD PRIMARY KEY (`idveiculo`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_cliente`
--
ALTER TABLE `tb_cliente`
  MODIFY `idcliente` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tb_endereco`
--
ALTER TABLE `tb_endereco`
  MODIFY `idendereco` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tb_funcionario`
--
ALTER TABLE `tb_funcionario`
  MODIFY `idfuncionario` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tb_motoristas`
--
ALTER TABLE `tb_motoristas`
  MODIFY `idmotorista` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tb_pedido`
--
ALTER TABLE `tb_pedido`
  MODIFY `idpedido` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tb_veiculo`
--
ALTER TABLE `tb_veiculo`
  MODIFY `idveiculo` int(10) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `tb_cliente`
--
ALTER TABLE `tb_cliente`
  ADD CONSTRAINT `fk_endereco2` FOREIGN KEY (`idendereco`) REFERENCES `tb_endereco` (`idendereco`) ON UPDATE CASCADE;

--
-- Limitadores para a tabela `tb_motoristas`
--
ALTER TABLE `tb_motoristas`
  ADD CONSTRAINT `fk_funcionario` FOREIGN KEY (`idfuncionario`) REFERENCES `tb_funcionario` (`idfuncionario`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_veiculo` FOREIGN KEY (`idveiculo`) REFERENCES `tb_veiculo` (`idveiculo`) ON UPDATE CASCADE;

--
-- Limitadores para a tabela `tb_pedido`
--
ALTER TABLE `tb_pedido`
  ADD CONSTRAINT `fk_cliente` FOREIGN KEY (`idcliente`) REFERENCES `tb_cliente` (`idcliente`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_endereco3` FOREIGN KEY (`idendereco`) REFERENCES `tb_endereco` (`idendereco`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_motorista` FOREIGN KEY (`idmotorista`) REFERENCES `tb_motoristas` (`idmotorista`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
