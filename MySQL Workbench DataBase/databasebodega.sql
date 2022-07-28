-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: localhost    Database: bodega_db
-- ------------------------------------------------------
-- Server version	8.0.29

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `administrador`
--

DROP TABLE IF EXISTS `administrador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `administrador` (
  `administrador_id` varchar(45) NOT NULL,
  `administrador_run` varchar(45) DEFAULT NULL,
  `administrador_nombre` varchar(45) DEFAULT NULL,
  `administrador_password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`administrador_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `administrador`
--

LOCK TABLES `administrador` WRITE;
/*!40000 ALTER TABLE `administrador` DISABLE KEYS */;
INSERT INTO `administrador` VALUES ('1','19.872.413-0','Sergio','admin1234');
/*!40000 ALTER TABLE `administrador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bodega`
--

DROP TABLE IF EXISTS `bodega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bodega` (
  `bodegero_id` int NOT NULL,
  `bodegero_run` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`bodegero_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bodega`
--

LOCK TABLES `bodega` WRITE;
/*!40000 ALTER TABLE `bodega` DISABLE KEYS */;
INSERT INTO `bodega` VALUES (1,'19.872.413-0');
/*!40000 ALTER TABLE `bodega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bodegero`
--

DROP TABLE IF EXISTS `bodegero`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bodegero` (
  `idbodegero` int NOT NULL,
  `bodegero_run` varchar(45) DEFAULT NULL,
  `bodegero_nombre` varchar(45) DEFAULT NULL,
  `bodegero_password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idbodegero`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bodegero`
--

LOCK TABLES `bodegero` WRITE;
/*!40000 ALTER TABLE `bodegero` DISABLE KEYS */;
INSERT INTO `bodegero` VALUES (1,'19.872.413-0','Sergio','bodegero1234');
/*!40000 ALTER TABLE `bodegero` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `login`
--

DROP TABLE IF EXISTS `login`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `login` (
  `id_bodegero` int NOT NULL,
  `id_admin` int NOT NULL,
  `nombre_bodegero` varchar(45) DEFAULT NULL,
  `nombre_admin` varchar(45) DEFAULT NULL,
  `password_bodegero` varchar(45) DEFAULT NULL,
  `password_admin` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_bodegero`,`id_admin`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `login`
--

LOCK TABLES `login` WRITE;
/*!40000 ALTER TABLE `login` DISABLE KEYS */;
INSERT INTO `login` VALUES (1,1,'Juan','Beto','bodega1234','admin1234');
/*!40000 ALTER TABLE `login` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producto` (
  `idproducto` int NOT NULL,
  `nombre_producto` varchar(1000) DEFAULT NULL,
  `precio_producto` int DEFAULT NULL,
  `descripcion_producto` varchar(1000) DEFAULT NULL,
  PRIMARY KEY (`idproducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES (1,'Fuente De Poder RX-700AC-V Vortex 80 Plus Raidmax',200000,'La fuente de alimentación Raidmax Vortex es compatible con tecnologías Multi-GPU, ofreciendo conectores PCIe de 6 y 8 pines. Es ideal para CPU de dos, cuatro y múltiples núcleos y está diseñado con un ventilador silencioso de 120 mm que ajusta automáticamente las velocidades según el estado térmico.'),(2,'Mouse Pro X Superlight Negro Logitech',15000,'Elimina todos los obstáculos para ganar con nuestro mouse inalámbrico PRO más ligero y rápido. El nuevo favorito de los mejores profesionales de esports pesa menos de 63 gramos y se desliza sin apenas fricción'),(3,'Webcam 1080P GXT 1160 Vero Trust',40000,'Plug & play'),(4,'Escritorio Gamer RGB MT-DSK20 Meetion',120000,'DSK20 RGB escritorio de juegos de computadora con luz led para PC,Material Tablero PB, fibra de carbono, patas de metal, cuero PU'),(5,'Micrófono Seiren V2 X Razer',60000,'Destaca entre la multitud de streamers con una claridad que se abre paso entre el ruido. Hazte oír con el Razer Seiren V2 X, un micrófono condensador USB perfecto para cualquier equipo de streaming, equipado con toda la tecnología necesaria para que tu voz cobre vida.');
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `retiro`
--

DROP TABLE IF EXISTS `retiro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `retiro` (
  `idretiro` int NOT NULL,
  `idproducto` int NOT NULL,
  PRIMARY KEY (`idretiro`,`idproducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `retiro`
--

LOCK TABLES `retiro` WRITE;
/*!40000 ALTER TABLE `retiro` DISABLE KEYS */;
INSERT INTO `retiro` VALUES (1,1);
/*!40000 ALTER TABLE `retiro` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-07-27 20:49:06
