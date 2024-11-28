use projeto;

DELIMITER $$
CREATE TRIGGER t1 AFTER INSERT on emprestimo FOR EACH ROW
BEGIN
UPDATE livro SET
status = 'e'
Where idLivro = NEW.Livro_idLivro;
END $$
DELIMITER ;

DELIMITER $$
CREATE TRIGGER t2 AFTER DELETE on emprestimo FOR EACH ROW
BEGIN
UPDATE livro SET
status = 'd'
Where idLivro = OLD.Livro_idLivro;
END $$
DELIMITER ;

DELIMITER $$

CREATE TRIGGER t3 BEFORE INSERT on emprestimo FOR EACH ROW
BEGIN
DECLARE Y DATE;
SELECT dataDevolucao into Y from emprestimo where Cliente_idCliente=NEW.Cliente_idCliente;
IF(Y<current_date())
THEN
SIGNAL SQLSTATE '02000'
SET MESSAGE_TEXT = 'Empréstimo inválido. O cliente deve devolver o livro com a devolução atrasada';
END IF;
END $$
DELIMITER ;
-- ALEXANDRE BLANK LOPES, EDUARDO GODIO RODRIGUES, PEDRO HENRIQUE SEMENSATO DENADAI, 
-- RICKSON MÉDICI TOMÉ, WELINGTON CARVALHO BRANCO SALDANHA JUNIOR