-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Окт 16 2018 г., 18:27
-- Версия сервера: 5.6.38
-- Версия PHP: 5.6.32

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `devm3d`
--

-- --------------------------------------------------------

--
-- Структура таблицы `partner`
--

CREATE TABLE `partner` (
  `id` int(11) NOT NULL,
  `email` varchar(250) NOT NULL,
  `password` varchar(255) NOT NULL,
  `actingBasis` varchar(150) DEFAULT NULL,
  `bik` varchar(15) DEFAULT NULL,
  `bankName` varchar(150) DEFAULT NULL,
  `checkingAccount` varchar(20) DEFAULT NULL,
  `correspondentAccount` varchar(20) DEFAULT NULL,
  `dateOfIssueCertificate` date DEFAULT NULL,
  `dateOfIssuePassport` date DEFAULT NULL,
  `fio` varchar(150) DEFAULT NULL,
  `inn` varchar(15) DEFAULT NULL,
  `issueByPassport` varchar(150) DEFAULT NULL,
  `kpp` varchar(15) DEFAULT NULL,
  `legalAdress` varchar(150) DEFAULT NULL,
  `nameOrganization` varchar(150) DEFAULT NULL,
  `ogrn` varchar(50) DEFAULT NULL,
  `ogrnip` varchar(50) DEFAULT NULL,
  `phoneNumber` varchar(22) DEFAULT NULL,
  `position` varchar(150) DEFAULT NULL,
  `seriesAndNumberCertificate` varchar(50) DEFAULT NULL,
  `seriesAndNumberPassword` varchar(50) DEFAULT NULL,
  `success` tinyint(1) DEFAULT NULL,
  `typeClient` int(2) DEFAULT NULL,
  `unitCodePassport` varchar(10) DEFAULT NULL,
  `actualAddress` varchar(150) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `partner`
--

INSERT INTO `partner` (`id`, `email`, `password`, `actingBasis`, `bik`, `bankName`, `checkingAccount`, `correspondentAccount`, `dateOfIssueCertificate`, `dateOfIssuePassport`, `fio`, `inn`, `issueByPassport`, `kpp`, `legalAdress`, `nameOrganization`, `ogrn`, `ogrnip`, `phoneNumber`, `position`, `seriesAndNumberCertificate`, `seriesAndNumberPassword`, `success`, `typeClient`, `unitCodePassport`, `actualAddress`) VALUES
(4, 'test@test', '$2y$10$GvuaN1untI4P5uGao9ZPtuJe2LtroGzfiQAWp5ot99VpO30CNCpI6', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(5, 'test1@test', '$2y$10$ZFDEkI2lptBpx0UhnoxALOtNlL83JfELuhEPlaw5MXKH6G4xcPLNm', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `partner`
--
ALTER TABLE `partner`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `partner`
--
ALTER TABLE `partner`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
