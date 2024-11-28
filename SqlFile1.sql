-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, 
	SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,
    NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- ----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema projeto
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema projeto
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `projeto` ;
USE `projeto` ;

-- -----------------------------------------------------
-- Table `projeto`.`Cliente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `projeto`.`Cliente` (
  `idCliente` INT(4) ZEROFILL NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `sobrenome` VARCHAR(255) NULL,
  `cpf` VARCHAR(11) NOT NULL,
  `email` VARCHAR(255) NULL,
  `telefone` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idCliente`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `projeto`.`Funcionario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `projeto`.`Funcionario` (
  `idFuncionario` INT(4) ZEROFILL NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(255) NOT NULL,
  `sobrenome` VARCHAR(255) NOT NULL,
  `cpf` VARCHAR(11) NOT NULL,
  `email` VARCHAR(255) NULL,
  `telefone` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idFuncionario`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `projeto`.`Livro`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `projeto`.`Livro` (
  `idLivro` INT(5) ZEROFILL NOT NULL AUTO_INCREMENT,
  `titulo` VARCHAR(255) NOT NULL,
  `exemplar` INT(3) NOT NULL,
  `isbn` VARCHAR(13) NOT NULL,
  `autor` VARCHAR(255) NULL,
  `anoPublicacao` INT(4) NULL,
  `edicao` INT(3) NULL,
  `status` VARCHAR(45) NOT NULL,
  `paginas` INT(5) NULL,
  PRIMARY KEY (`idLivro`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `projeto`.`Emprestimo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `projeto`.`Emprestimo` (
  `Livro_idLivro` INT(5) ZEROFILL NOT NULL,
  `Cliente_idCliente` INT(4) ZEROFILL NOT NULL,
  `Funcionario_idFuncionario` INT(4) ZEROFILL NOT NULL,
  `dataEmprestimo` DATE NOT NULL,
  `dataDevolucao` DATE GENERATED ALWAYS AS (timestampadd(DAY,7,dataEmprestimo)) VIRTUAL,
  PRIMARY KEY (`Livro_idLivro`),
  INDEX `fk_Emprestimo_Cliente1_idx` (`Cliente_idCliente` ASC) VISIBLE,
  INDEX `fk_Emprestimo_Funcionario1_idx` (`Funcionario_idFuncionario` ASC) VISIBLE,
  CONSTRAINT `fk_Emprestimo_Livro`
    FOREIGN KEY (`Livro_idLivro`)
    REFERENCES `projeto`.`Livro` (`idLivro`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Emprestimo_Cliente1`
    FOREIGN KEY (`Cliente_idCliente`)
    REFERENCES `projeto`.`Cliente` (`idCliente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Emprestimo_Funcionario1`
    FOREIGN KEY (`Funcionario_idFuncionario`)
    REFERENCES `projeto`.`Funcionario` (`idFuncionario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;





SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
