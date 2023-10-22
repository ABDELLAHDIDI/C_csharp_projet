-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 17, 2023 at 03:45 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.0.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ginf2`
--

-- --------------------------------------------------------

--
-- Table structure for table `eleve`
--

CREATE TABLE `eleve` (
  `id` int(11) NOT NULL PRIMARY KEY ,
  `code` varchar(255) NOT NULL,
  `nom` varchar(255) NOT NULL,
  `prenom` varchar(255) NOT NULL,
  `niveau` int(11) NOT NULL,
  `code_fil` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `eleve`
--

INSERT INTO `eleve` (`id`, `code`, `nom`, `prenom`, `niveau`, `code_fil`) VALUES
(1, 'ELE1', 'Doe', 'John', 1, 'GINF'),
(2, 'ELE2', 'Smith', 'Jane', 1, 'GINF'),
(3, 'ELE3', 'Garcia', 'Juan', 1, 'GSTR'),
(4, 'ELE4', 'Lee', 'Min', 1, 'GSTR'),
(5, 'ELE5', 'DIDI', 'ABDELLAH', 2, 'GINF');

-- --------------------------------------------------------

--
-- Table structure for table `filiere`
--

CREATE TABLE `filiere` (
  `id` int(11) NOT NULL PRIMARY KEY,
  `code` varchar(255) NOT NULL,
  `designation` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `filiere`
--

INSERT INTO `filiere` (`id`, `code`, `designation`) VALUES
(2, 'GSTR', 'genie des system telecom et reseaux '),
(3, 'GSEA', 'genie des system electrique analogique'),
(4, 'G3EI', 'genie d enverenment ecologique electrique industrielle'),
(5, 'AP', 'année préparatoire'),
(7, 'GINF', 'genie informatique');

-- --------------------------------------------------------

--
-- Table structure for table `matiere`
--

CREATE TABLE `matiere` (
  `id` int(11) NOT NULL PRIMARY KEY,
  `code` varchar(255) NOT NULL,
  `designation` varchar(255) NOT NULL,
  `VH` int(11) NOT NULL,
  `code_module` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `matiere`
--

INSERT INTO `matiere` (`id`, `code`, `designation`, `VH`, `code_module`) VALUES
(1, 'ALG1', 'Algèbre 1', 30, 'ALG'),
(2, 'POO1', 'Programmation orientée objet 1', 30, 'POO'),
(3, 'ANAL', 'Analyse', 30, 'ANA'),
(4, 'ALG2', 'Algèbre 2', 30, 'ALG2'),
(5, 'THERMO1', 'Thermodynamique 1', 30, 'THERM'),
(6, 'OPTI1', 'Optique 1', 30, 'OPTI'),
(7, 'ORG1', 'Chimie organique 1', 30, 'ORG'),
(8, 'INOR1', 'Chimie inorganique 1', 30, 'INOR');

-- --------------------------------------------------------

--
-- Table structure for table `module`
--

CREATE TABLE `module` (
  `id` int(11) NOT NULL  PRIMARY KEY,
  `code` varchar(255) NOT NULL,
  `designation` varchar(255) NOT NULL,
  `niveau` int(11) NOT NULL,
  `semestre` int(11) NOT NULL,
  `code_fil` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `module`
--

INSERT INTO `module` (`id`, `code`, `designation`, `niveau`, `semestre`, `code_fil`) VALUES
(1, 'ALG', 'Algorithmique', 1, 1, 'GINF'),
(2, 'POO', 'Programmation orientée objet', 1, 2, 'GINF'),
(3, 'ANA', 'Analyse', 1, 1, 'GSTR'),
(4, 'ALG2', 'Algèbre 2', 1, 2, 'GSTR'),
(5, 'THERM', 'Thermodynamique', 1, 1, 'GSEA'),
(6, 'OPTI', 'Optique', 1, 2, 'GSEA'),
(7, 'ORG', 'Organique', 1, 1, 'G3EI'),
(8, 'INOR', 'Inorganique', 1, 2, 'G3EI');

-- --------------------------------------------------------

--
-- Table structure for table `moyennes`
--

CREATE TABLE `moyennes` (
  `id` int(11) NOT NULL  PRIMARY KEY,
  `code_eleve` varchar(255) NOT NULL,
  `code_fil` varchar(255) NOT NULL,
  `niveau` int(11) NOT NULL,
  `moyenne` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `moyennes`
--

INSERT INTO `moyennes` (`id`, `code_eleve`, `code_fil`, `niveau`, `moyenne`) VALUES
(1, 'ELE1', 'GINF', 1, 14),
(2, 'ELE2', 'GINF', 1, 16),
(3, 'ELE3', 'GSTR', 1, 11.5),
(4, 'ELE4', 'GSTR', 1, 13);

-- --------------------------------------------------------

--
-- Table structure for table `notes`
--

CREATE TABLE `notes` (
  `id` int(11) NOT NULL PRIMARY KEY,
  `code_eleve` varchar(255) NOT NULL,
  `code_mat` varchar(255) NOT NULL,
  `note` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `notes`
--

INSERT INTO `notes` (`id`, `code_eleve`, `code_mat`, `note`) VALUES 
(1, 'ELE1', 'ALG1', 12),
(2, 'ELE1', 'POO1', 16),
(3, 'ELE2', 'ALG1', 14),
(4, 'ELE2', 'POO1', 18),
(5, 'ELE3', 'ANAL', 10),
(6, 'ELE3', 'ALG2', 13),
(7, 'ELE4', 'ANAL', 15),
(8, 'ELE4', 'ALG2', 11);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `eleve`
--
ALTER TABLE `eleve`
  ADD UNIQUE KEY `code` (`code`),
  ADD KEY `code_fil` (`code_fil`);

--
-- Indexes for table `filiere`
--
ALTER TABLE `filiere`
  ADD UNIQUE KEY `code` (`code`);

--
-- Indexes for table `matiere`
--
ALTER TABLE `matiere`
  ADD UNIQUE KEY `code` (`code`),
  ADD KEY `code_module` (`code_module`);

--
-- Indexes for table `module`
--
ALTER TABLE `module`
  ADD UNIQUE KEY `code` (`code`),
  ADD KEY `code_fil` (`code_fil`);

--
-- Indexes for table `moyennes`
--
ALTER TABLE `moyennes`
  ADD KEY `code_eleve` (`code_eleve`),
  ADD KEY `code_fil` (`code_fil`);

--
-- Indexes for table `notes`
--
ALTER TABLE `notes`
  ADD KEY `code_eleve` (`code_eleve`),
  ADD KEY `code_mat` (`code_mat`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `eleve`
--
ALTER TABLE `eleve`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `filiere`
--
ALTER TABLE `filiere`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `matiere`
--
ALTER TABLE `matiere`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `module`
--
ALTER TABLE `module`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `moyennes`
--
ALTER TABLE `moyennes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `notes`
--
ALTER TABLE `notes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Constraints for dumped tables
--
--
-- Constraints for table `eleve`
--
ALTER TABLE `eleve`
  ADD CONSTRAINT `eleve_ibfk_1` FOREIGN KEY (`code_fil`) REFERENCES `filiere` (`code`);

  --
-- Constraints for table `module`
--
ALTER TABLE `module`
  ADD CONSTRAINT `module_ibfk_1` FOREIGN KEY (`code_fil`) REFERENCES `filiere` (`code`);
--
-- Constraints for table `matiere`
--
ALTER TABLE `matiere`
  ADD CONSTRAINT `matiere_ibfk_1` FOREIGN KEY (`code_module`) REFERENCES `module` (`code`);

--
-- Constraints for table `moyennes`
--
ALTER TABLE `moyennes`
  ADD CONSTRAINT `moyennes_ibfk_1` FOREIGN KEY (`code_eleve`) REFERENCES `eleve` (`code`),
  ADD CONSTRAINT `moyennes_ibfk_2` FOREIGN KEY (`code_fil`) REFERENCES `filiere` (`code`);

--
-- Constraints for table `notes`
--
ALTER TABLE `notes`
  ADD CONSTRAINT `notes_ibfk_1` FOREIGN KEY (`code_eleve`) REFERENCES `eleve` (`code`),
  ADD CONSTRAINT `notes_ibfk_2` FOREIGN KEY (`code_mat`) REFERENCES `matiere` (`code`);


DELIMITER $$

CREATE FUNCTION `func_save_notes` ( `id` INT ,`Code_eleve` varchar(225), `Code_mat` varchar(225), `Note` FLOAT)
RETURNS INT(11)
BEGIN
    DECLARE new_id INT;
    DECLARE kode varchar(225);
    SET kode = NULL;

    SELECT code_eleve INTO new_id FROM kode WHERE code_eleve = Code_eleve AND code_mat = Code_mat;

    IF kode IS NOT NULL THEN
        UPDATE notes SET note = Note WHERE code_eleve = Code_eleve AND code_mat = Code_mat;
        SELECT id INTO new_id FROM notes WHERE code_eleve = Code_eleve AND code_mat = Code_mat;
    ELSE
        SELECT COALESCE(MAX(id), 0) + 1 INTO new_id FROM notes;
        INSERT INTO notes (code_eleve, code_mat, note) VALUES (Code_eleve, Code_mat, Note);
    END IF;

    RETURN new_id;

END$$

DELIMITER ;








COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
