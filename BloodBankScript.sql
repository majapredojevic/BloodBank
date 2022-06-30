-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema BloodBankDB
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema BloodBankDB
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `BloodBankDB` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci ;
USE `BloodBankDB` ;

-- -----------------------------------------------------
-- Table `BloodBankDB`.`ADRESA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`ADRESA` (
  `IdAdresa` INT NOT NULL AUTO_INCREMENT,
  `Drzava` VARCHAR(45) NOT NULL,
  `Grad` VARCHAR(45) NOT NULL,
  `PostanskiBroj` VARCHAR(15) NOT NULL,
  `Ulica` VARCHAR(80) NOT NULL,
  `Broj` VARCHAR(6) NOT NULL,
  PRIMARY KEY (`IdAdresa`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`OSOBA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`OSOBA` (
  `IdOsoba` INT NOT NULL AUTO_INCREMENT,
  `Ime` VARCHAR(45) NOT NULL,
  `Prezime` VARCHAR(45) NOT NULL,
  `JMBG` CHAR(13) NOT NULL,
  `Email` VARCHAR(45) NULL,
  `Telefon` VARCHAR(20) NULL,
  `ADRESA_IdAdresa` INT NOT NULL,
  PRIMARY KEY (`IdOsoba`),
  UNIQUE INDEX `JMBG_UNIQUE` (`JMBG` ASC) VISIBLE,
  INDEX `fk_OSOBA_ADRESA1_idx` (`ADRESA_IdAdresa` ASC) VISIBLE,
  CONSTRAINT `fk_OSOBA_ADRESA1`
    FOREIGN KEY (`ADRESA_IdAdresa`)
    REFERENCES `BloodBankDB`.`ADRESA` (`IdAdresa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`BANKA_KRVI`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`BANKA_KRVI` (
  `IdBankaKrvi` INT NOT NULL AUTO_INCREMENT,
  `Naziv` VARCHAR(45) NOT NULL,
  `Email` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`IdBankaKrvi`),
  UNIQUE INDEX `Naziv_UNIQUE` (`Naziv` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`POSLOVNICA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`POSLOVNICA` (
  `Naziv` VARCHAR(45) NOT NULL,
  `Email` VARCHAR(45) NULL,
  `BANKA_KRVI_IdBankaKrvi` INT NOT NULL,
  `ADRESA_IdAdresa` INT NOT NULL,
  `IdPoslovnica` INT NOT NULL AUTO_INCREMENT,
  INDEX `fk_SLUZBA_BANKA_KRVI1_idx` (`BANKA_KRVI_IdBankaKrvi` ASC) VISIBLE,
  INDEX `fk_SLUZBA_ADRESA1_idx` (`ADRESA_IdAdresa` ASC) VISIBLE,
  UNIQUE INDEX `Naziv_UNIQUE` (`Naziv` ASC) VISIBLE,
  PRIMARY KEY (`IdPoslovnica`),
  CONSTRAINT `fk_SLUZBA_BANKA_KRVI1`
    FOREIGN KEY (`BANKA_KRVI_IdBankaKrvi`)
    REFERENCES `BloodBankDB`.`BANKA_KRVI` (`IdBankaKrvi`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_SLUZBA_ADRESA1`
    FOREIGN KEY (`ADRESA_IdAdresa`)
    REFERENCES `BloodBankDB`.`ADRESA` (`IdAdresa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`ZAPOSLENI`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`ZAPOSLENI` (
  `IdOsoba` INT NOT NULL,
  `Plata` DECIMAL(6,2) NOT NULL,
  `Zvanje` VARCHAR(45) NULL,
  `IdPoslovnica` INT NOT NULL,
  PRIMARY KEY (`IdOsoba`),
  INDEX `fk_ZAPOSLENI_OSOBA1_idx` (`IdOsoba` ASC) VISIBLE,
  INDEX `fk_ZAPOSLENI_POSLOVNICA1_idx` (`IdPoslovnica` ASC) VISIBLE,
  CONSTRAINT `fk_ZAPOSLENI_OSOBA1`
    FOREIGN KEY (`IdOsoba`)
    REFERENCES `BloodBankDB`.`OSOBA` (`IdOsoba`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ZAPOSLENI_POSLOVNICA1`
    FOREIGN KEY (`IdPoslovnica`)
    REFERENCES `BloodBankDB`.`POSLOVNICA` (`IdPoslovnica`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`DOKTOR`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`DOKTOR` (
  `IdZaposleni` INT NOT NULL,
  PRIMARY KEY (`IdZaposleni`),
  INDEX `fk_DOKTOR_ZAPOSLENI1_idx` (`IdZaposleni` ASC) VISIBLE,
  CONSTRAINT `fk_DOKTOR_ZAPOSLENI1`
    FOREIGN KEY (`IdZaposleni`)
    REFERENCES `BloodBankDB`.`ZAPOSLENI` (`IdOsoba`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`RH_FAKTOR`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`RH_FAKTOR` (
  `Naziv` CHAR(1) NOT NULL,
  PRIMARY KEY (`Naziv`),
  UNIQUE INDEX `Naziv_UNIQUE` (`Naziv` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`KRVNA_GRUPA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`KRVNA_GRUPA` (
  `Naziv` VARCHAR(2) NOT NULL,
  UNIQUE INDEX `Naziv_UNIQUE` (`Naziv` ASC) VISIBLE,
  PRIMARY KEY (`Naziv`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`DAVALAC_KRVI`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`DAVALAC_KRVI` (
  `IdOsoba` INT NOT NULL,
  `ImeOca` VARCHAR(45) NULL,
  `RHFaktor` CHAR(1) NULL,
  `KrvnaGrupa` VARCHAR(2) NULL,
  PRIMARY KEY (`IdOsoba`),
  INDEX `fk_DAVALAC_KRVI_OSOBA1_idx` (`IdOsoba` ASC) VISIBLE,
  INDEX `fk_DAVALAC_KRVI_RHFaktor1_idx` (`RHFaktor` ASC) VISIBLE,
  INDEX `fk_DAVALAC_KRVI_KRVNA_GRUPA1_idx` (`KrvnaGrupa` ASC) VISIBLE,
  CONSTRAINT `fk_DAVALAC_KRVI_OSOBA1`
    FOREIGN KEY (`IdOsoba`)
    REFERENCES `BloodBankDB`.`OSOBA` (`IdOsoba`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_DAVALAC_KRVI_RHFaktor1`
    FOREIGN KEY (`RHFaktor`)
    REFERENCES `BloodBankDB`.`RH_FAKTOR` (`Naziv`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_DAVALAC_KRVI_KRVNA_GRUPA1`
    FOREIGN KEY (`KrvnaGrupa`)
    REFERENCES `BloodBankDB`.`KRVNA_GRUPA` (`Naziv`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`BOLNICA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`BOLNICA` (
  `IdBolnica` INT NOT NULL AUTO_INCREMENT,
  `Naziv` VARCHAR(100) NULL,
  `ADRESA_IdAdresa` INT NOT NULL,
  PRIMARY KEY (`IdBolnica`),
  INDEX `fk_BOLNICA_ADRESA1_idx` (`ADRESA_IdAdresa` ASC) VISIBLE,
  CONSTRAINT `fk_BOLNICA_ADRESA1`
    FOREIGN KEY (`ADRESA_IdAdresa`)
    REFERENCES `BloodBankDB`.`ADRESA` (`IdAdresa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`KORISNICKI_NALOG`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`KORISNICKI_NALOG` (
  `IdKorisnickiNalog` INT NOT NULL AUTO_INCREMENT,
  `KorisnickoIme` VARCHAR(55) NOT NULL,
  `Lozinka` VARCHAR(55) NOT NULL,
  `IdZaposleni` INT NOT NULL,
  UNIQUE INDEX `KorisnickoIme_UNIQUE` (`KorisnickoIme` ASC) VISIBLE,
  PRIMARY KEY (`IdKorisnickiNalog`),
  INDEX `fk_KORISNICKI_NALOG_ZAPOSLENI1_idx` (`IdZaposleni` ASC) VISIBLE,
  CONSTRAINT `fk_KORISNICKI_NALOG_ZAPOSLENI1`
    FOREIGN KEY (`IdZaposleni`)
    REFERENCES `BloodBankDB`.`ZAPOSLENI` (`IdOsoba`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`SKLADISTE`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`SKLADISTE` (
  `IdSkladiste` INT NOT NULL,
  `NazivSkladista` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`IdSkladiste`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`RECEPCIONER`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`RECEPCIONER` (
  `ZAPOSLENI_IdOsoba` INT NOT NULL,
  `SKLADISTE_IdSkladiste` INT NULL,
  PRIMARY KEY (`ZAPOSLENI_IdOsoba`),
  INDEX `fk_RECEPCIONER_SKLADISTE1_idx` (`SKLADISTE_IdSkladiste` ASC) VISIBLE,
  INDEX `fk_RECEPCIONER_ZAPOSLENI1_idx` (`ZAPOSLENI_IdOsoba` ASC) VISIBLE,
  CONSTRAINT `fk_RECEPCIONER_SKLADISTE1`
    FOREIGN KEY (`SKLADISTE_IdSkladiste`)
    REFERENCES `BloodBankDB`.`SKLADISTE` (`IdSkladiste`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_RECEPCIONER_ZAPOSLENI1`
    FOREIGN KEY (`ZAPOSLENI_IdOsoba`)
    REFERENCES `BloodBankDB`.`ZAPOSLENI` (`IdOsoba`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`NARUDZBA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`NARUDZBA` (
  `IdNarudzba` INT NOT NULL AUTO_INCREMENT,
  `Datum` DATE NOT NULL,
  `BOLNICA_IdBolnica` INT NOT NULL,
  `RECEPCIONER_ZAPOSLENI_IdOsoba` INT NOT NULL,
  PRIMARY KEY (`IdNarudzba`),
  INDEX `fk_ZAHTJEV_ZA_DOZE_BOLNICA1_idx` (`BOLNICA_IdBolnica` ASC) VISIBLE,
  INDEX `fk_NARUDZBA_RECEPCIONER1_idx` (`RECEPCIONER_ZAPOSLENI_IdOsoba` ASC) VISIBLE,
  CONSTRAINT `fk_ZAHTJEV_ZA_DOZE_BOLNICA1`
    FOREIGN KEY (`BOLNICA_IdBolnica`)
    REFERENCES `BloodBankDB`.`BOLNICA` (`IdBolnica`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_NARUDZBA_RECEPCIONER1`
    FOREIGN KEY (`RECEPCIONER_ZAPOSLENI_IdOsoba`)
    REFERENCES `BloodBankDB`.`RECEPCIONER` (`ZAPOSLENI_IdOsoba`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`IZVJESTAJ_ISPORUKE`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`IZVJESTAJ_ISPORUKE` (
  `IdIzvjestajIsporuke` INT NOT NULL AUTO_INCREMENT,
  `BOLNICA_IdBolnica` INT NOT NULL,
  `DatumVrijemeIzdavanja` DATETIME NOT NULL,
  `RECEPCIONER_ZAPOSLENI_IdOsoba` INT NOT NULL,
  PRIMARY KEY (`IdIzvjestajIsporuke`),
  INDEX `fk_IZVJESTAJ_ISPORUKE_BOLNICA1_idx` (`BOLNICA_IdBolnica` ASC) VISIBLE,
  INDEX `fk_IZVJESTAJ_ISPORUKE_RECEPCIONER1_idx` (`RECEPCIONER_ZAPOSLENI_IdOsoba` ASC) VISIBLE,
  CONSTRAINT `fk_IZVJESTAJ_ISPORUKE_BOLNICA1`
    FOREIGN KEY (`BOLNICA_IdBolnica`)
    REFERENCES `BloodBankDB`.`BOLNICA` (`IdBolnica`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_IZVJESTAJ_ISPORUKE_RECEPCIONER1`
    FOREIGN KEY (`RECEPCIONER_ZAPOSLENI_IdOsoba`)
    REFERENCES `BloodBankDB`.`RECEPCIONER` (`ZAPOSLENI_IdOsoba`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`JEDINICA_KRVI`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`JEDINICA_KRVI` (
  `IdJedinicaKrvi` INT NOT NULL AUTO_INCREMENT,
  `Kolicina` INT NOT NULL,
  `IZVJESTAJ_ISPORUKE_IdIzvjestajIsporuke` INT NULL,
  PRIMARY KEY (`IdJedinicaKrvi`),
  INDEX `fk_JEDINICA_KRVI_IZVJESTAJ_ISPORUKE1_idx` (`IZVJESTAJ_ISPORUKE_IdIzvjestajIsporuke` ASC) VISIBLE,
  CONSTRAINT `fk_JEDINICA_KRVI_IZVJESTAJ_ISPORUKE1`
    FOREIGN KEY (`IZVJESTAJ_ISPORUKE_IdIzvjestajIsporuke`)
    REFERENCES `BloodBankDB`.`IZVJESTAJ_ISPORUKE` (`IdIzvjestajIsporuke`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`DONIRANJE_KRVI`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`DONIRANJE_KRVI` (
  `IdDoniranjeKrvi` INT NOT NULL AUTO_INCREMENT,
  `Datum` DATETIME NOT NULL,
  `Hemoglobin` INT NOT NULL,
  `KrvniPritisak` VARCHAR(45) NOT NULL,
  `Puls` INT NOT NULL,
  `ZdravstvenoStanje` VARCHAR(100) NULL,
  `IdDavalac` INT NOT NULL,
  `IdDoktor` INT NOT NULL,
  `IdPoslovnica` INT NOT NULL,
  `IdJedinicaKrvi` INT NULL,
  PRIMARY KEY (`IdDoniranjeKrvi`),
  INDEX `fk_DONIRANJE_KRVI_DAVALAC_KRVI1_idx` (`IdDavalac` ASC) VISIBLE,
  INDEX `fk_DONIRANJE_KRVI_DOKTOR1_idx` (`IdDoktor` ASC) VISIBLE,
  INDEX `fk_DONIRANJE_KRVI_POSLOVNICA1_idx` (`IdPoslovnica` ASC) VISIBLE,
  INDEX `fk_DONIRANJE_KRVI_JEDINICA_KRVI2_idx` (`IdJedinicaKrvi` ASC) VISIBLE,
  CONSTRAINT `fk_DONIRANJE_KRVI_DAVALAC_KRVI1`
    FOREIGN KEY (`IdDavalac`)
    REFERENCES `BloodBankDB`.`DAVALAC_KRVI` (`IdOsoba`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_DONIRANJE_KRVI_DOKTOR1`
    FOREIGN KEY (`IdDoktor`)
    REFERENCES `BloodBankDB`.`DOKTOR` (`IdZaposleni`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_DONIRANJE_KRVI_POSLOVNICA1`
    FOREIGN KEY (`IdPoslovnica`)
    REFERENCES `BloodBankDB`.`POSLOVNICA` (`IdPoslovnica`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_DONIRANJE_KRVI_JEDINICA_KRVI2`
    FOREIGN KEY (`IdJedinicaKrvi`)
    REFERENCES `BloodBankDB`.`JEDINICA_KRVI` (`IdJedinicaKrvi`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`LABORANT`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`LABORANT` (
  `IdZaposleni` INT NOT NULL,
  PRIMARY KEY (`IdZaposleni`),
  INDEX `fk_LABORANT_ZAPOSLENI1_idx` (`IdZaposleni` ASC) VISIBLE,
  CONSTRAINT `fk_LABORANT_ZAPOSLENI1`
    FOREIGN KEY (`IdZaposleni`)
    REFERENCES `BloodBankDB`.`ZAPOSLENI` (`IdOsoba`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`IZVJESTAJ_ANALIZE`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`IZVJESTAJ_ANALIZE` (
  `IdJedinicaKrvi` INT NOT NULL,
  `Datum` DATETIME NOT NULL,
  `LABORANT_IdOsoba` INT NOT NULL,
  `RHFaktor_Naziv` CHAR(1) NOT NULL,
  `KRVNA_GRUPA_Naziv` VARCHAR(2) NOT NULL,
  INDEX `fk_IZVJESTAJ_ANALIZE_LABORANT1_idx` (`LABORANT_IdOsoba` ASC) VISIBLE,
  INDEX `fk_IZVJESTAJ_ANALIZE_RHFaktor1_idx` (`RHFaktor_Naziv` ASC) VISIBLE,
  INDEX `fk_IZVJESTAJ_ANALIZE_KRVNA_GRUPA1_idx` (`KRVNA_GRUPA_Naziv` ASC) VISIBLE,
  PRIMARY KEY (`IdJedinicaKrvi`),
  CONSTRAINT `fk_IZVJESTAJ_ANALIZE_LABORANT1`
    FOREIGN KEY (`LABORANT_IdOsoba`)
    REFERENCES `BloodBankDB`.`LABORANT` (`IdZaposleni`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_IZVJESTAJ_ANALIZE_RHFaktor1`
    FOREIGN KEY (`RHFaktor_Naziv`)
    REFERENCES `BloodBankDB`.`RH_FAKTOR` (`Naziv`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_IZVJESTAJ_ANALIZE_KRVNA_GRUPA1`
    FOREIGN KEY (`KRVNA_GRUPA_Naziv`)
    REFERENCES `BloodBankDB`.`KRVNA_GRUPA` (`Naziv`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_IZVJESTAJ_ANALIZE_JEDINICA_KRVI1`
    FOREIGN KEY (`IdJedinicaKrvi`)
    REFERENCES `BloodBankDB`.`JEDINICA_KRVI` (`IdJedinicaKrvi`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`TELEFON_POSLOVNICA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`TELEFON_POSLOVNICA` (
  `Telefon` VARCHAR(20) NOT NULL,
  `IdPoslovnica` INT NOT NULL,
  PRIMARY KEY (`Telefon`, `IdPoslovnica`),
  INDEX `fk_TELEFON_POSLOVNICA_POSLOVNICA1_idx` (`IdPoslovnica` ASC) VISIBLE,
  CONSTRAINT `fk_TELEFON_POSLOVNICA_POSLOVNICA1`
    FOREIGN KEY (`IdPoslovnica`)
    REFERENCES `BloodBankDB`.`POSLOVNICA` (`IdPoslovnica`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`TELEFON_BOLNICA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`TELEFON_BOLNICA` (
  `Telefon` VARCHAR(20) NOT NULL,
  `BOLNICA_IdBolnica` INT NOT NULL,
  PRIMARY KEY (`Telefon`, `BOLNICA_IdBolnica`),
  INDEX `fk_TELEFON_BOLNICA_BOLNICA1_idx` (`BOLNICA_IdBolnica` ASC) VISIBLE,
  CONSTRAINT `fk_TELEFON_BOLNICA_BOLNICA1`
    FOREIGN KEY (`BOLNICA_IdBolnica`)
    REFERENCES `BloodBankDB`.`BOLNICA` (`IdBolnica`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`STAVKA_NARUDZBE`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`STAVKA_NARUDZBE` (
  `NARUDZBA_IdNarudzba` INT NOT NULL,
  `KRVNA_GRUPA_Naziv` VARCHAR(2) NOT NULL,
  `RH_FAKTOR_Naziv` CHAR(1) NOT NULL,
  `BrojJedinica` INT NOT NULL,
  PRIMARY KEY (`NARUDZBA_IdNarudzba`, `KRVNA_GRUPA_Naziv`, `RH_FAKTOR_Naziv`),
  INDEX `fk_STAVKA_NARUDZBE_KRVNA_GRUPA1_idx` (`KRVNA_GRUPA_Naziv` ASC) VISIBLE,
  INDEX `fk_STAVKA_NARUDZBE_RH_FAKTOR1_idx` (`RH_FAKTOR_Naziv` ASC) VISIBLE,
  CONSTRAINT `fk_STAVKA_NARUDZBE_NARUDZBA1`
    FOREIGN KEY (`NARUDZBA_IdNarudzba`)
    REFERENCES `BloodBankDB`.`NARUDZBA` (`IdNarudzba`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_STAVKA_NARUDZBE_KRVNA_GRUPA1`
    FOREIGN KEY (`KRVNA_GRUPA_Naziv`)
    REFERENCES `BloodBankDB`.`KRVNA_GRUPA` (`Naziv`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_STAVKA_NARUDZBE_RH_FAKTOR1`
    FOREIGN KEY (`RH_FAKTOR_Naziv`)
    REFERENCES `BloodBankDB`.`RH_FAKTOR` (`Naziv`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`SEKTOR`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`SEKTOR` (
  `Naziv` VARCHAR(45) NOT NULL,
  `BrojJedinicaUSektoru` INT NOT NULL,
  `SKLADISTE_IdSkladiste` INT NOT NULL,
  `KRVNA_GRUPA_Naziv` VARCHAR(2) NOT NULL,
  `RH_FAKTOR_Naziv` CHAR(1) NOT NULL,
  UNIQUE INDEX `Naziv_UNIQUE` (`Naziv` ASC) VISIBLE,
  PRIMARY KEY (`SKLADISTE_IdSkladiste`, `KRVNA_GRUPA_Naziv`, `RH_FAKTOR_Naziv`),
  INDEX `fk_SEKTOR_SKLADISTE1_idx` (`SKLADISTE_IdSkladiste` ASC) VISIBLE,
  INDEX `fk_SEKTOR_KRVNA_GRUPA1_idx` (`KRVNA_GRUPA_Naziv` ASC) VISIBLE,
  INDEX `fk_SEKTOR_RH_FAKTOR1_idx` (`RH_FAKTOR_Naziv` ASC) VISIBLE,
  CONSTRAINT `fk_SEKTOR_SKLADISTE1`
    FOREIGN KEY (`SKLADISTE_IdSkladiste`)
    REFERENCES `BloodBankDB`.`SKLADISTE` (`IdSkladiste`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_SEKTOR_KRVNA_GRUPA1`
    FOREIGN KEY (`KRVNA_GRUPA_Naziv`)
    REFERENCES `BloodBankDB`.`KRVNA_GRUPA` (`Naziv`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_SEKTOR_RH_FAKTOR1`
    FOREIGN KEY (`RH_FAKTOR_Naziv`)
    REFERENCES `BloodBankDB`.`RH_FAKTOR` (`Naziv`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`VIRUS`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`VIRUS` (
  `IdVirus` INT NOT NULL AUTO_INCREMENT,
  `Naziv` VARCHAR(45) NOT NULL,
  `ReferentnaVrijednost` VARCHAR(45) NOT NULL,
  `MjernaJedinica` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`IdVirus`),
  UNIQUE INDEX `Naziv_UNIQUE` (`Naziv` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`IZVJESTAJ_ANALIZE_VIRUS`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`IZVJESTAJ_ANALIZE_VIRUS` (
  `IdIzvjestaj` INT NOT NULL,
  `IdVirus` INT NOT NULL,
  `Vrijednost` DECIMAL(6,2) NULL,
  PRIMARY KEY (`IdIzvjestaj`, `IdVirus`),
  INDEX `fk_IZVJESTAJ_ANALIZE_has_VIRUS_VIRUS1_idx` (`IdVirus` ASC) VISIBLE,
  INDEX `fk_IZVJESTAJ_ANALIZE_VIRUS_IZVJESTAJ_ANALIZE1_idx` (`IdIzvjestaj` ASC) VISIBLE,
  CONSTRAINT `fk_IZVJESTAJ_ANALIZE_has_VIRUS_VIRUS1`
    FOREIGN KEY (`IdVirus`)
    REFERENCES `BloodBankDB`.`VIRUS` (`IdVirus`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_IZVJESTAJ_ANALIZE_VIRUS_IZVJESTAJ_ANALIZE1`
    FOREIGN KEY (`IdIzvjestaj`)
    REFERENCES `BloodBankDB`.`IZVJESTAJ_ANALIZE` (`IdJedinicaKrvi`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`TELEFON_BANKA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`TELEFON_BANKA` (
  `TELEFON` VARCHAR(20) NOT NULL,
  `IdBankaKrvi` INT NOT NULL,
  PRIMARY KEY (`TELEFON`, `IdBankaKrvi`),
  INDEX `fk_TELEFON_BANKA_BANKA_KRVI1_idx` (`IdBankaKrvi` ASC) VISIBLE,
  CONSTRAINT `fk_TELEFON_BANKA_BANKA_KRVI1`
    FOREIGN KEY (`IdBankaKrvi`)
    REFERENCES `BloodBankDB`.`BANKA_KRVI` (`IdBankaKrvi`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`KRVNI_PARAMETAR`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`KRVNI_PARAMETAR` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Naziv` VARCHAR(45) NOT NULL,
  `ReferentnaVrijednost` VARCHAR(45) NOT NULL,
  `MjernaJedinica` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Naziv_UNIQUE` (`Naziv` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`IZVJESTAJ_ANALIZE_KRVNI_PARAMETAR`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`IZVJESTAJ_ANALIZE_KRVNI_PARAMETAR` (
  `IdIzvjestajAnalize` INT NOT NULL,
  `IdKrvniParametar` INT NOT NULL,
  `Vrijednost` DECIMAL(6,2) NOT NULL,
  PRIMARY KEY (`IdIzvjestajAnalize`, `IdKrvniParametar`),
  INDEX `fk_IZVJESTAJ_ANALIZE_has_KRVNI_PARAMETAR_KRVNI_PARAMETAR1_idx` (`IdKrvniParametar` ASC) VISIBLE,
  INDEX `fk_IZVJESTAJ_ANALIZE_has_KRVNI_PARAMETAR_IZVJESTAJ_ANALIZE1_idx` (`IdIzvjestajAnalize` ASC) VISIBLE,
  CONSTRAINT `fk_IZVJESTAJ_ANALIZE_has_KRVNI_PARAMETAR_IZVJESTAJ_ANALIZE1`
    FOREIGN KEY (`IdIzvjestajAnalize`)
    REFERENCES `BloodBankDB`.`IZVJESTAJ_ANALIZE` (`IdJedinicaKrvi`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_IZVJESTAJ_ANALIZE_has_KRVNI_PARAMETAR_KRVNI_PARAMETAR1`
    FOREIGN KEY (`IdKrvniParametar`)
    REFERENCES `BloodBankDB`.`KRVNI_PARAMETAR` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BloodBankDB`.`MENADZER`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BloodBankDB`.`MENADZER` (
  `IdZaposleni` INT NOT NULL,
  PRIMARY KEY (`IdZaposleni`),
  CONSTRAINT `fk_MENADZER_ZAPOSLENI1`
    FOREIGN KEY (`IdZaposleni`)
    REFERENCES `BloodBankDB`.`ZAPOSLENI` (`IdOsoba`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;


-- -----------------------------------------------------
-- Pogledi, trigeri i procedure 
-- -----------------------------------------------------



-- pogled - infomacije o banci
DROP VIEW IF EXISTS banka_info;
CREATE VIEW banka_info as 
SELECT b.IdBankaKrvi, b.Naziv, b.Email, group_concat(DISTINCT t.Telefon SEPARATOR ', ') AS 'Telefon' 
FROM banka_krvi b 
INNER JOIN telefon_banka t ON b.IdBankaKrvi=t.IdBankaKrvi
GROUP BY  b.Naziv;



-- pogled informacije o poslovnicama
DROP VIEW IF EXISTS poslovnice_info;
CREATE VIEW poslovnice_info AS
SELECT  p.IdPoslovnica,p.Naziv, p.Email,group_concat(t.Telefon SEPARATOR ', ') AS 'Telefon',a.IdAdresa, a.Drzava, a.Grad, a.PostanskiBroj, a.Ulica, a.Broj, b.IdBankaKrvi,b.Naziv as 'NazivBanke', b.Email as 'EmailBanka', b.Telefon as 'TelefonBanka'
FROM poslovnica p
INNER JOIN banka_info b ON b.IdBankaKrvi= p.BANKA_KRVI_IdBankaKrvi
INNER JOIN adresa a ON a.IdAdresa= p.ADRESA_IdAdresa
INNER JOIN telefon_poslovnica t ON t.IdPoslovnica=p.IdPoslovnica
GROUP BY p.Naziv;

-- funkcija broj_Doniranja davaoca
DELIMITER $$
CREATE FUNCTION broj_Doniranja (pIdDavalac int)
RETURNS int
reads sql data
BEGIN
	DECLARE Count int;
	SELECT count(*) INTO Count
	FROM doniranje_krvi d WHERE d.IdDavalac=pIdDavalac;
    return Count;
END$$
DELIMITER ;


DELIMITER $$
create trigger brisanje_izvjestaja before delete
on izvjestaj_analize
for each row
begin
delete from izvjestaj_analize_krvni_parametar p where p.IdIzvjestajAnalize = old.IdJedinicaKrvi;
delete from izvjestaj_analize_virus v where v.IdIzvjestaj = old.IdJedinicaKrvi;
end $$
DELIMITER ;

DELIMITER $$
	create trigger brisanje_zaposlenog before delete
    on zaposleni
    for each row
    begin
    delete from korisnicki_nalog n where n.IdZaposleni = old.IdOsoba;
    end$$
DELIMITER ;

-- pogled izvjestaj_analize_detaljno
drop view if exists izvjestaj_analize_detaljno;
create view izvjestaj_analize_detaljno as
select i.IdJedinicaKrvi, j.Kolicina, i.Datum, r.Naziv as 'RHFaktor', k.Naziv as 'KrvnaGrupa', z.Zvanje, o.Ime, o.Prezime
from izvjestaj_analize i 
inner join jedinica_krvi j on j.IdJedinicaKrvi = i.IdJedinicaKrvi
inner join laborant l on l.IdZaposleni = i.LABORANT_IdOsoba
inner join zaposleni z on z.IdOsoba = l.IdZaposleni
inner join osoba o on o.IdOsoba = z.IdOsoba
inner join rh_faktor r on r.Naziv = i.RHFaktor_Naziv
inner join krvna_grupa k on k.Naziv = i.KRVNA_GRUPA_Naziv;
select * from izvjestaj_analize_detaljno;

-- pogled davaoci_krvi_detaljno
drop view if exists davaoci_krvi_detaljno;
create view davaoci_krvi_detaljno as
 SELECT o.IdOsoba, o.Ime, o.Prezime,o.JMBG, o.Telefon, o.Email,a.IdAdresa, a.Drzava, a.Grad, a.PostanskiBroj, a.Ulica, a.Broj, d.ImeOca, d.KrvnaGrupa, d.RHFaktor, broj_Doniranja(d.IdOsoba) as 'BrojDoniranja'
                                                FROM davalac_krvi d
                                                INNER JOIN osoba o ON o.IdOsoba=d.IdOsoba
                                                INNER JOIN adresa a ON a.IdAdresa= o.ADRESA_IdAdresa
                                                LEFT JOIN rh_faktor r ON r.Naziv= d.RHFaktor
                                                LEFT JOIN krvna_grupa k ON k.Naziv= d.KrvnaGrupa;
                                               select * from davaoci_krvi_detaljno;
                                                      
                                                      

-- pogled doniranje_krvi_detaljno

drop view if exists doniranje_krvi_detaljno;
create view doniranje_krvi_detaljno as
select b.IdDoniranjeKrvi, b.Datum, b.Hemoglobin, b.KrvniPritisak, b.Puls, b.ZdravstvenoStanje,o1.IdOsoba, o1.Ime as 'ImeDavaoca', o1.Prezime as 'PrezimeDavaoca', o1.JMBG, d.ImeOca, j.IdJedinicaKrvi, j.Kolicina, p.Naziv,z.Zvanje,o2.Ime, o2.Prezime
 from doniranje_krvi b
 inner join davalac_krvi d on d.IdOsoba = b.IdDavalac
 inner join osoba o1 on o1.IdOsoba = d.IdOsoba
 inner join doktor on doktor.IdZaposleni = b.IdDoktor
 inner join zaposleni z on z.IdOsoba = doktor.IdZaposleni
 inner join osoba o2 on z.IdOsoba=o2.IdOsoba
 inner join poslovnica p on p.IdPoslovnica =b.IdPoslovnica
 inner join jedinica_krvi j on j.IdJedinicaKrvi=b.IdJedinicaKrvi;

select * from doniranje_krvi_detaljno;



DELIMITER $$
CREATE PROCEDURE vrsta_korisnika (in pId int, out pVrsta int)
BEGIN
	declare vDoktor, vLaborant bool default false;
    set pVrsta=-1;
	
	SELECT COUNT(*) > 0 INTO vDoktor
	FROM doktor d WHERE d.IdZaposleni = pId;
    
    SELECT COUNT(*) > 0 INTO vLaborant
	FROM laborant l WHERE l.IdZaposleni = pId;
	
    if vDoktor and not vLaborant then set pVrsta=1; end if;
    if not vDoktor and vLaborant then set pVrsta=2; end if;
END$$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE broj_referenci_na_adresu (in pId int, out pBroj int)
BEGIN
	declare vBolnica, vPoslovnica, vOsoba int default 0;
    set pBroj=0;
	
	SELECT COUNT(*) INTO vBolnica
	FROM bolnica b WHERE b.ADRESA_IdAdresa = pId;
    
    		SELECT COUNT(*) INTO vPoslovnica
	FROM poslovnica p WHERE p.ADRESA_IdAdresa = pId;
    
    	SELECT COUNT(*) INTO vOsoba
	FROM osoba o WHERE o.ADRESA_IdAdresa = pId;
	
     set pBroj=vOsoba+vBolnica+vPoslovnica; 
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE provjeri_da_li_je_davalac_zaposleni (in pId int, out pBroj int)
BEGIN
    set pBroj=0;
	
	SELECT COUNT(*) INTO pBroj
	FROM zaposleni z WHERE z.IdOsoba = pId;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE provjeri_adresu (in pDrzava varchar(45),in pGrad varchar(45),in pPostanskiBroj varchar(15), in pUlica varchar(80), in pBroj varchar(6), out pId int )
BEGIN
    set pId=-1;
	
	SELECT a.IdAdresa INTO pId
	FROM adresa a WHERE a.Drzava=pDrzava and a.Grad=pGrad and a.PostanskiBroj=pPostanskiBroj and a.Ulica=pUlica and a.Broj=pBroj;
END$$
DELIMITER ;

DELIMITER $$
create procedure obrisi_davaoca (in pId int)
begin
declare vZaposleni boolean default false;
declare  IdAdresa int;

 delete from davalac_krvi where davalac_krvi.IdOsoba=pId;
 
    SELECT COUNT(*)>0 INTO vZaposleni
	FROM zaposleni z WHERE z.IdOsoba = pId;
    
    select ADRESA_IdAdresa into IdAdresa
    from osoba
    where pId=osoba.IdOsoba;
    
    set @pBroj=0;
    CALL broj_referenci_na_adresu(IdAdresa,@pBroj);
    SELECT @pBroj;
    
IF NOT vZaposleni THEN 
        delete from osoba where osoba.IdOsoba=pId;
	END IF;
    
     IF NOT (SELECT @pBroj>1) THEN
       delete from adresa where adresa.IdAdresa=IdAdresa;
    END IF;
end$$
DELIMITER ;



DELIMITER $$
CREATE PROCEDURE provjeri_JMBG (in pJMBG varchar(13), out pId int)
BEGIN
    set pId= -1;
	
	SELECT o.IdOsoba INTO pId
	FROM osoba o WHERE o.JMBG = pJMBG;
END$$
DELIMITER ;


-- -----------------------------------------------------
-- Testni podaci
-- -----------------------------------------------------

-- adrese
INSERT INTO `bloodbankdb`.`adresa`(`Drzava`,`Grad`,`PostanskiBroj`,`Ulica`,`Broj`) VALUE  ('BiH', 'Banja Luka', '78000', 'Carice Milice', '22');
INSERT INTO `bloodbankdb`.`adresa`(`Drzava`,`Grad`,`PostanskiBroj`,`Ulica`,`Broj`) VALUE  ('BiH', 'Novi Grad', '79220', 'Miće Šurlana', '12');
INSERT INTO `bloodbankdb`.`adresa`(`Drzava`,`Grad`,`PostanskiBroj`,`Ulica`,`Broj`) VALUE  ('BiH', 'Prijedor', '79101', 'Cara Lazara', '26');
INSERT INTO `bloodbankdb`.`adresa`(`Drzava`,`Grad`,`PostanskiBroj`,`Ulica`,`Broj`) VALUE  ('BiH', 'Bijeljina', '76300', 'Stepe Stepanovića', '54');
INSERT INTO `bloodbankdb`.`adresa`(`Drzava`,`Grad`,`PostanskiBroj`,`Ulica`,`Broj`) VALUE  ('BiH', 'Doboj', '74000', 'Patre', '25');
INSERT INTO `bloodbankdb`.`adresa`(`Drzava`,`Grad`,`PostanskiBroj`,`Ulica`,`Broj`) VALUE  ('BiH', 'Trebinje', '89101', 'Ravnogorska', '24');
INSERT INTO `bloodbankdb`.`adresa`(`Drzava`,`Grad`,`PostanskiBroj`,`Ulica`,`Broj`) VALUE  ('BiH', 'Trebinje', '89101', 'Moja ulica', '28');

-- banka
INSERT INTO `bloodbankdb`.`banka_krvi`(`Naziv`, `Email`) VALUE ('Zavod za transfuzijsku medicinu RS','info@zztmrs.rs.ba');


-- telefon_banka
INSERT INTO `bloodbankdb`.`telefon_banka`(`Telefon`,`IdBankaKrvi`) VALUE ('065123456','1');
INSERT INTO `bloodbankdb`.`telefon_banka`(`Telefon`,`IdBankaKrvi`) VALUE ('065987654','1');
INSERT INTO `bloodbankdb`.`telefon_banka`(`Telefon`,`IdBankaKrvi`) VALUE ('065123457','1');





-- poslovnica
INSERT INTO `bloodbankdb`.`poslovnica`(`Naziv`,`Email`,`BANKA_KRVI_IdBankaKrvi`,`ADRESA_IdAdresa`) VALUE ('Banja Luka','banjaluka@zztmrs.rs.ba','1','1');
INSERT INTO `bloodbankdb`.`poslovnica`(`Naziv`,`Email`,`BANKA_KRVI_IdBankaKrvi`,`ADRESA_IdAdresa`) VALUE ('Novi Grad','novigrad@zztmrs.rs.ba','1','2');
INSERT INTO `bloodbankdb`.`poslovnica`(`Naziv`,`Email`,`BANKA_KRVI_IdBankaKrvi`,`ADRESA_IdAdresa`) VALUE ('Prijedor','prijedor@zztmrs.rs.ba','1','3');
INSERT INTO `bloodbankdb`.`poslovnica`(`Naziv`,`Email`,`BANKA_KRVI_IdBankaKrvi`,`ADRESA_IdAdresa`) VALUE ('Bijeljina','bijeljina@zztmrs.rs.ba','1','4');
INSERT INTO `bloodbankdb`.`poslovnica`(`Naziv`,`Email`,`BANKA_KRVI_IdBankaKrvi`,`ADRESA_IdAdresa`) VALUE ('Doboj','doboj@zztmrs.rs.ba','1','5');
INSERT INTO `bloodbankdb`.`poslovnica`(`Naziv`,`Email`,`BANKA_KRVI_IdBankaKrvi`,`ADRESA_IdAdresa`) VALUE ('Trebinje','trebinje@zztmrs.rs.ba','1','6');


-- telefon_poslovnica
INSERT INTO `bloodbankdb`.`telefon_poslovnica`(`Telefon`,`IdPoslovnica`) VALUE ('065123456','1');
INSERT INTO `bloodbankdb`.`telefon_poslovnica`(`Telefon`,`IdPoslovnica`) VALUE ('065987654','2');
INSERT INTO `bloodbankdb`.`telefon_poslovnica`(`Telefon`,`IdPoslovnica`) VALUE ('065123457','3');
INSERT INTO `bloodbankdb`.`telefon_poslovnica`(`Telefon`,`IdPoslovnica`) VALUE ('065123456','4');
INSERT INTO `bloodbankdb`.`telefon_poslovnica`(`Telefon`,`IdPoslovnica`) VALUE ('065987654','5');
INSERT INTO `bloodbankdb`.`telefon_poslovnica`(`Telefon`,`IdPoslovnica`) VALUE ('065123457','6');
INSERT INTO `bloodbankdb`.`telefon_poslovnica`(`Telefon`,`IdPoslovnica`) VALUE ('065123346','3');
INSERT INTO `bloodbankdb`.`telefon_poslovnica`(`Telefon`,`IdPoslovnica`) VALUE ('065987034','2');
INSERT INTO `bloodbankdb`.`telefon_poslovnica`(`Telefon`,`IdPoslovnica`) VALUE ('065123057','1');
INSERT INTO `bloodbankdb`.`telefon_poslovnica`(`Telefon`,`IdPoslovnica`) VALUE ('065122256','1');

-- RHFaktor

insert into `bloodbankdb`.`rh_faktor` value ('+');
insert into `bloodbankdb`.`rh_faktor` value ('-');

-- Krvne_grupe

insert into `bloodbankdb`.`krvna_grupa` value ('A');
insert into `bloodbankdb`.`krvna_grupa` value ('B');
insert into `bloodbankdb`.`krvna_grupa` value ('AB');
insert into `bloodbankdb`.`krvna_grupa` value ('0');

-- Osobe

insert into `bloodbankdb`.`osoba` value (null,'Marko','Marković','1111111111111','marko@mail.com','065111111','1');
insert into `bloodbankdb`.`osoba` value (null,'Ivana','Ivanović','2222222222222','ivana@mail.com','066222222','2');
insert into `bloodbankdb`.`osoba` value (null,'Janko','Janković','3333333333333','janko@mail.com','000333333','3');
insert into `bloodbankdb`.`osoba` value (null,'Maja','Majić','4444444444444','maja@mail.com','000444444','4');
insert into `bloodbankdb`.`osoba` value (null,'Slavko','Slavković','5555555555555','slavko@mail.com','065555555','5');
insert into `bloodbankdb`.`osoba` value (null,'Petar','Petrović','6666666666666','petar@mail.com','066666666','6');
insert into `bloodbankdb`.`osoba` value (null,'Tajana','Janković','7777777777777','tajana@mail.com','000777777','3');
insert into `bloodbankdb`.`osoba` value (null,'Dajana','Dajić','8888888888888','dajana@mail.com','000888888','2');

-- Zaposleni

insert into `bloodbankdb`.`zaposleni` value ('1','1800','Prof. dr','1'); 
insert into `bloodbankdb`.`zaposleni` value ('2','1400','Dr', '1'); 
insert into `bloodbankdb`.`zaposleni` value ('3','1200','Doc. dr', '1'); 
insert into `bloodbankdb`.`zaposleni` value ('4','1800', null,'1'); 


-- Doktor
insert into `bloodbankdb`.`doktor` value ('1'); 
insert into `bloodbankdb`.`doktor` value ('2'); 

-- Laborant
insert into `bloodbankdb`.`laborant` value ('3'); 
insert into `bloodbankdb`.`laborant` value ('4'); 

-- Korisnicki nalog
insert into `bloodbankdb`.`korisnicki_nalog` value (null,'doktor1','doktor1','1'); 
insert into `bloodbankdb`.`korisnicki_nalog` value (null,'doktor2','doktor2','2'); 
insert into `bloodbankdb`.`korisnicki_nalog` value (null,'laborant1','laborant1','3'); 
insert into `bloodbankdb`.`korisnicki_nalog` value (null,'laborant2','laborant2','4'); 

-- krvni paramteri

insert into `bloodbankdb`.`krvni_parametar` value (null, 'Hemoglobin','130-180','mg/dl');
insert into `bloodbankdb`.`krvni_parametar` value (null, 'Eritrociti','4.5-6.5','mmol/L');
insert into `bloodbankdb`.`krvni_parametar` value (null, 'CRP','<5','µg/dL');
insert into `bloodbankdb`.`krvni_parametar` value (null, 'Clot retraction','>40','µg/dL');

-- Virusi

insert into `bloodbankdb`.`virus` value (null, 'CMV','130-180','mg/dl');
insert into `bloodbankdb`.`virus` value (null, 'Covid19','4.5-6.5','g/L');
insert into `bloodbankdb`.`virus` value (null, 'HIV','<5','mg/dl');
insert into `bloodbankdb`.`virus` value (null, 'Covi21','>40','%');


-- Davaoci_krvi

insert into `bloodbankdb`.`davalac_krvi` value ('1','Marinko','+','A');
insert into `bloodbankdb`.`davalac_krvi` value ('2','Darko','-','B');
insert into `bloodbankdb`.`davalac_krvi` value ('3','Zarko','+','AB');
insert into `bloodbankdb`.`davalac_krvi` value ('4','Rajko','+','AB');
insert into `bloodbankdb`.`davalac_krvi` value ('5','Mirko','+','A');
insert into `bloodbankdb`.`davalac_krvi` value ('6', null, '-','B');
insert into `bloodbankdb`.`davalac_krvi` value ('7','Saša','+','AB');
insert into `bloodbankdb`.`davalac_krvi` value ('8','Janko','+','AB');

-- Jedinica_krvi

insert into `bloodbankdb`.`jedinica_krvi` value (null,'450',null);
insert into `bloodbankdb`.`jedinica_krvi` value (null,'350',null);
insert into `bloodbankdb`.`jedinica_krvi` value (null,'250',null);
insert into `bloodbankdb`.`jedinica_krvi` value (null,'450',null);

-- Doniranje

insert into `bloodbankdb`.`doniranje_krvi` value (null,sysdate(),'120','120/80','80',null,'1','2','1','1');
insert into `bloodbankdb`.`doniranje_krvi` value (null,sysdate(),'121','122/80','80','Tahikardija','1','2','1','2');
insert into `bloodbankdb`.`doniranje_krvi` value (null,sysdate(),'120','120/70','90',null,'2','2','2','3');
insert into `bloodbankdb`.`doniranje_krvi` value (null,sysdate(),'126','126/80','80',null,'5','2','2','4');

-- Izvjestaj_analize
insert into `bloodbankdb`.`izvjestaj_analize` value ('1',sysdate(),'3','+','AB');
insert into `bloodbankdb`.`izvjestaj_analize` value ('2',sysdate(),'3','-','B');
insert into `bloodbankdb`.`izvjestaj_analize` value ('3',sysdate(),'4','+','A');
insert into `bloodbankdb`.`izvjestaj_analize` value ('4',sysdate(),'4','-','0');

-- Izvjestaj_analize_Krvni_parametri
insert into `bloodbankdb`.`izvjestaj_analize_krvni_parametar` value ('1','1','1.0');
insert into `bloodbankdb`.`izvjestaj_analize_krvni_parametar` value ('1','2','2.0');
insert into `bloodbankdb`.`izvjestaj_analize_krvni_parametar` value ('1','3','3.0');
insert into `bloodbankdb`.`izvjestaj_analize_krvni_parametar` value ('1','4','4.0');
insert into `bloodbankdb`.`izvjestaj_analize_krvni_parametar` value ('2','1','5.0');
insert into `bloodbankdb`.`izvjestaj_analize_krvni_parametar` value ('2','2','6.0');
insert into `bloodbankdb`.`izvjestaj_analize_krvni_parametar` value ('2','3','7.0');
insert into `bloodbankdb`.`izvjestaj_analize_krvni_parametar` value ('2','4','8.0');
insert into `bloodbankdb`.`izvjestaj_analize_krvni_parametar` value ('3','1','1.1');
insert into `bloodbankdb`.`izvjestaj_analize_krvni_parametar` value ('3','2','2.2');
insert into `bloodbankdb`.`izvjestaj_analize_krvni_parametar` value ('3','3','3.3');
insert into `bloodbankdb`.`izvjestaj_analize_krvni_parametar` value ('3','4','4.4');
insert into `bloodbankdb`.`izvjestaj_analize_krvni_parametar` value ('4','1','1.0');
insert into `bloodbankdb`.`izvjestaj_analize_krvni_parametar` value ('4','2','2.0');
insert into `bloodbankdb`.`izvjestaj_analize_krvni_parametar` value ('4','3','3.0');
insert into `bloodbankdb`.`izvjestaj_analize_krvni_parametar` value ('4','4','4.0');

-- Izvjestaj_analize_virusi

insert into `bloodbankdb`.`izvjestaj_analize_virus` value ('1','1','1.0');
insert into `bloodbankdb`.`izvjestaj_analize_virus` value ('1','2','2.0');
insert into `bloodbankdb`.`izvjestaj_analize_virus` value ('1','3','3.0');
insert into `bloodbankdb`.`izvjestaj_analize_virus` value ('1','4','4.0');
insert into `bloodbankdb`.`izvjestaj_analize_virus` value ('2','1','5.0');
insert into `bloodbankdb`.`izvjestaj_analize_virus` value ('2','2','6.0');
insert into `bloodbankdb`.`izvjestaj_analize_virus` value ('2','3','7.0');
insert into `bloodbankdb`.`izvjestaj_analize_virus` value ('2','4','8.0');
insert into `bloodbankdb`.`izvjestaj_analize_virus` value ('3','1','1.1');
insert into `bloodbankdb`.`izvjestaj_analize_virus` value ('3','2','2.2');
insert into `bloodbankdb`.`izvjestaj_analize_virus` value ('3','3','3.3');
insert into `bloodbankdb`.`izvjestaj_analize_virus` value ('3','4','4.4');
insert into `bloodbankdb`.`izvjestaj_analize_virus` value ('4','1','1.0');
insert into `bloodbankdb`.`izvjestaj_analize_virus` value ('4','2','2.0');
insert into `bloodbankdb`.`izvjestaj_analize_virus` value ('4','3','3.0');
insert into `bloodbankdb`.`izvjestaj_analize_virus` value ('4','4','4.0');




