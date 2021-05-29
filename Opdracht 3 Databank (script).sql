-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema FitnessReservatie
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema FitnessReservatie
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `FitnessReservatie` DEFAULT CHARACTER SET utf8 ;
USE `FitnessReservatie` ;

-- -----------------------------------------------------
-- Table `FitnessReservatie`.`Lid`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `FitnessReservatie`.`Lid` (
  `idLid` INT NOT NULL AUTO_INCREMENT,
  `FamilieNaam` VARCHAR(45) NOT NULL,
  `VoorNaam` VARCHAR(45) NOT NULL,
  `GeboorteDatum` DATE NOT NULL,
  `Adres` MEDIUMTEXT NOT NULL,
  `Postcode` int NOT NULL,
  `Gemeente` MEDIUMTEXT NOT NULL,
  `Telefoonnummer` VARCHAR(45) NOT NULL,
  `Emailadres` VARCHAR(45) NOT NULL,
  `Rijksregisternummer` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idLid`),
  UNIQUE INDEX `Rijksregisternummer_UNIQUE` (`Rijksregisternummer` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `FitnessReservatie`.`Categorie`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `FitnessReservatie`.`Categorie` (
  `idCategorie` INT NOT NULL AUTO_INCREMENT,
  `Naam` VARCHAR(45) NOT NULL,
  `Omschrijving` MEDIUMTEXT NOT NULL,
  PRIMARY KEY (`idCategorie`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `FitnessReservatie`.`Les`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `FitnessReservatie`.`Les` (
  `idLes` INT NOT NULL AUTO_INCREMENT,
  `Naam` VARCHAR(45) NOT NULL,
  `MaximumAantalPersonen` INT NOT NULL,
  `Omschrijving` MEDIUMTEXT NOT NULL,
  `FKCategorie` INT NOT NULL,
  PRIMARY KEY (`idLes`),
  INDEX `fk_Les_Categorie1_idx` (`FKCategorie` ASC) VISIBLE,
  CONSTRAINT `fk_Les_Categorie1`
    FOREIGN KEY (`FKCategorie`)
    REFERENCES `FitnessReservatie`.`Categorie` (`idCategorie`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `FitnessReservatie`.`Reservatie`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `FitnessReservatie`.`Reservatie` (
  `idReservatie` INT NOT NULL AUTO_INCREMENT,
  `Datum` DATE NOT NULL,
  `Tijdstip` TIME NOT NULL, 
  `FKLid` INT NULL,
  `FKLes` INT NOT NULL,
  `Beschikbaar` TINYINT NULL,
  PRIMARY KEY (`idReservatie`),
  INDEX `fk_Reservatie_Lid1_idx` (`FKLid` ASC) VISIBLE,
  INDEX `fk_Reservatie_Les1_idx` (`FKLes` ASC) VISIBLE,
  CONSTRAINT `fk_Reservatie_Lid1`
    FOREIGN KEY (`FKLid`)
    REFERENCES `FitnessReservatie`.`Lid` (`idLid`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Reservatie_Les1`
    FOREIGN KEY (`FKLes`)
    REFERENCES `FitnessReservatie`.`Les` (`idLes`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `FitnessReservatie`.`FitnessClub`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `FitnessReservatie`.`FitnessClub` (
  `idFitnessClub` INT NOT NULL AUTO_INCREMENT,
  `Naam` VARCHAR(45) NOT NULL,
  `Adres` MEDIUMTEXT NOT NULL,
  `Telefoonnummer` VARCHAR(45) NOT NULL,
  `Emailadres` VARCHAR(45) NOT NULL,
  `Openingsuren` VARCHAR(300) NOT NULL,
  PRIMARY KEY (`idFitnessClub`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `FitnessReservatie`.`FitnessClubGeeftLes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `FitnessReservatie`.`FitnessClubGeeftLes` (
  `FKFitnessClub` INT NOT NULL,
  `FKLes` INT NOT NULL,
  INDEX `fk_FitnessClub_has_Les_Les1_idx` (`FKLes` ASC) VISIBLE,
  INDEX `fk_FitnessClub_has_Les_FitnessClub1_idx` (`FKFitnessClub` ASC) VISIBLE,
  CONSTRAINT `fk_FitnessClub_has_Les_FitnessClub1`
    FOREIGN KEY (`FKFitnessClub`)
    REFERENCES `FitnessReservatie`.`FitnessClub` (`idFitnessClub`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_FitnessClub_has_Les_Les1`
    FOREIGN KEY (`FKLes`)
    REFERENCES `FitnessReservatie`.`Les` (`idLes`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

INSERT INTO fitnessreservatie.lid (`FamilieNaam`, `VoorNaam`, `GeboorteDatum`, `Adres`, `Postcode`,`Gemeente`,`Telefoonnummer`, `Emailadres`, `Rijksregisternummer`) VALUES 
('Linsen', 'Arthur', '2003-05-19', 'Vlierbessstraat 8', '2200', 'Noorderwijk', '0477 67 10 14', 'arthur.linsen@gmail.com', '03.05.19-063.11'),
('Jeugmans', 'Vince', '2002-09-24', 'Romeroplein 8 bus 102', '2200', 'Herentals', '0479 38 50 29', 'vinceke911@gmail.com', '02.09.24-123.01'),
('Haeverans', 'Sander', '2003-03-03', 'Doornestraat 8', '2200', 'Morkhoven', '0468 27 38 91', 'sander.heaverans@gmail.com', '03.03.03-854.92'),
('Vleugels', 'Nicolas', '2003-01-14', 'Parklaan 1A', '2280', 'Grobbendonk', '0470 67 10 38', 'Nicolas.vleugels@hotmail.com', '03.01.14-307.33'),
('Engelen', 'Ward', '2003-12-4', 'Zandkapelweg 2', '2200', 'Nooderwijk', '0471 48 92 62', 'wardengelen@yahoo.com', '03.12.04-145.08'),
('Van Peer', 'Siebe', '2003-02-03', 'Herentalsesteenweg 106', '2280', 'Grobbendonk', '0494 30 91 67', 'siebevanpeer@gmail.com', '03.02.11-199.62'),
('Van der Linden', 'Bram', '2003-06-19', 'Wygerberg 9', '2460', 'Lichtaart', '0476 61 80 45', 'bram.vanderlinden@hotmail.com', '03.06.19-269.14'),
('Vanuxem', 'Laly', '2003-01-27', 'Zandhoevestraat 20', '2200', 'Noorderwijk', '0492 75 66 31', 'laly_vanuxem@hotmail.COM', '03.01.27-154.58'),
('Daneels', 'Wannes', '2003-07-18', 'Heiblokken', '2250', 'Olen', '0491 59 10 67', 'wannes.daneels@gmail.com', '03.07.18-587.59');

INSERT INTO fitnessreservatie.reservatie (`Datum`, `Tijdstip`, `FKLid`, `FKLes`, `Beschikbaar`) VALUES 
('2021-05-01', '16:00:00', '1', '1', '1');

INSERT INTO `fitnessreservatie`.`reservatie` (`Datum`, `Tijdstip`, `FKLes`,  `Beschikbaar`) VALUES 
('2021-05-01', '16:00:00', '1', '0'),
('2021-05-01', '16:00:00', '1', '0'),
('2021-05-01', '16:00:00', '1', '0'),
('2021-05-01', '16:00:00', '1', '0'),
('2021-05-01', '16:00:00', '1', '0'),
('2021-05-01', '16:00:00', '1', '0'),
('2021-05-01', '16:00:00', '1', '0'),
('2021-05-01', '16:00:00', '1', '0'),
('2021-05-01', '16:00:00', '1', '0'),
('2021-05-01', '16:00:00', '1', '0');

INSERT INTO fitnessreservatie.les (`Naam`, `MaximumAantalPersonen`, `FKCategorie`, `Omschrijving`) VALUES 
('Fitness', '30', '1', 'Als lid kan je gebruik maken van alle toestellen, je kan altijd aan een trainer vragen voor uitleg/ondersteuning'),
('Spinning', '20', '2', 'Effectieve cardiotraining in groepsverband'),
('Yoga', '20', '2', 'Meditatie a.d.h.v. ademhalingsoefeningen en concentratie om je lichaam en geest te ontspannen'),
('Zumba', '20', '2', 'Swingende workout op Latijns Amerikaanse muziek'),
('Small group training', '5', '3', 'een trainers geeft continue uitleg/hulp aan max 5 leden '),
('Personal training', '1', '4', 'Je krijgt continue uitleg/hulp van een trainer');

INSERT INTO fitnessreservatie.fitnessclubgeeftles (FKFitnessclub, FKLes) VALUES
('1', '1'),
('1', '2'),
('1', '3'),
('1', '4'),
('1', '5'),
('1', '6');

INSERT INTO `fitnessreservatie`.`categorie` (`Naam`, `Omschrijving`) VALUES 
('Fitness', '1 lid sport alleen of samen in de fitness, er mogen maximaal 30 leden in de fitness op dezelfde tijd'),
('Groepsles', '1-2 trainers geven les aan een groep van 10-20 leden'),
('Small group training', 'Groep van 5 leden die ondersteund worden door een trainer'),
('Personal training', 'Een trainer helpt je terwijl je sport');

INSERT INTO `fitnessreservatie`.`fitnessclub` (`Naam`, `Adres`, `Telefoonnummer`, `Emailadres`, `Openingsuren`) VALUES 
('Rtalsmove', 'Lierseweg 230, 2200 Herentals', '014 89 84 68', 'info@rtalsmove.be', 'Ma-Vr 9:00-13:00 16:00-22:00 / Za-Zo 9:00-13:00');

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
