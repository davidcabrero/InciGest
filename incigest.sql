-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 10-05-2023 a las 17:35:26
-- Versión del servidor: 10.4.22-MariaDB
-- Versión de PHP: 7.4.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `incigest`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aplicaciones`
--

CREATE TABLE `aplicaciones` (
  `nombre` char(50) NOT NULL,
  `Incidencias` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `aplicaciones`
--

INSERT INTO `aplicaciones` (`nombre`, `Incidencias`) VALUES
('Terminal Financiero', 3),
('TPV', 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `incidencias`
--

CREATE TABLE `incidencias` (
  `id_incidencia` int(100) NOT NULL,
  `titulo` varchar(150) NOT NULL,
  `descripcion` longtext NOT NULL,
  `grupo_soporte` varchar(50) NOT NULL,
  `prioridad` varchar(20) NOT NULL,
  `fecha` date NOT NULL,
  `ip_terminal` char(50) NOT NULL,
  `dni_usuario` varchar(8) NOT NULL,
  `dni_usuarioAsignado` varchar(8) DEFAULT NULL,
  `aplicacion` varchar(50) NOT NULL,
  `estado` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `incidencias`
--

INSERT INTO `incidencias` (`id_incidencia`, `titulo`, `descripcion`, `grupo_soporte`, `prioridad`, `fecha`, `ip_terminal`, `dni_usuario`, `dni_usuarioAsignado`, `aplicacion`, `estado`) VALUES
(2, 'Error en la conexión host', 'Al ejecutar la aplicación se muestra un error en la conexión con el host, no permite realizar ninguna operativa.', 'Desarrollo', 'Baja', '2023-03-17', '182.65.37.9', '90628941', '02781465', 'Terminal Financiero', ''),
(3, 'No arranca la aplicación en el terminal 2', 'Al iniciar la aplicación del terminal 5002, del centro, no se ejecuta la aplicación, quedándose todo el rato en modo espera, cargando. No se puede realizar ninguna operación.', 'Desarrollo', 'Baja', '2023-03-21', '173.24.19.4', '90628941', '70837762', 'Terminal Financiero', ''),
(4, 'No es posible actualizar versión en TPV', 'La aplicación de TPV en todos los terminales del centro no se ha actualizado a la nueva versión. Al iniciar terminal aparece \"No es posible actualizar\".', 'Desarrollo', 'Baja', '2023-03-26', '152.19.83.1', '90628941', '84235916', 'TPV', ''),
(10, 'No se permite pago con tarjeta regalo en TPV', 'Al realizar una operación de cobro, la tarjeta regalo eci es rechazada, sin completarse el pago.', 'Desarrollo', 'Media', '2023-04-01', '125.65.23.6', '90628941', '02781465', 'TPV', ''),
(11, 'No es posible el cierre del terminal en TPV', 'El tpv 272 del centro de Marbella, al terminar el día y realizar el cierre del terminal, no se envían los datos, dando un error en el cierre.', 'Desarrollo', 'Media', '2023-04-27', '199.34.234.1', '90628941', NULL, 'TPV', ''),
(12, 'El terminal 5000 no se enciende', 'El terminal 5000 del centro de Gran Via, no arranca', 'Desarrollo', 'Baja', '2023-05-08', '127.34.18', '90628941', NULL, 'Terminal Financiero', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mensajes`
--

CREATE TABLE `mensajes` (
  `mensaje` longtext NOT NULL,
  `usuario` varchar(8) NOT NULL,
  `id_incidencia` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `mensajes`
--

INSERT INTO `mensajes` (`mensaje`, `usuario`, `id_incidencia`) VALUES
('¿Pueden aportar una operación de ejemplo donde se encuentre el error?', '84235916', 10),
('Operación 8859', '90628941', 10),
('Mantenemos en pendiente hasta encendido del terminal', '90628941', 10),
('Mensaje de prueba', '90628941', 10),
('Hola', '90628941', 10),
('Terminal encendido', '90628941', 10);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `nombre` varchar(100) NOT NULL,
  `apellido` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `DNI` varchar(8) NOT NULL,
  `perfil` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`nombre`, `apellido`, `email`, `password`, `DNI`, `perfil`) VALUES
('Ana', 'Cabrero', 'anacabrerojimenez@gmail.com', '$2a$10$Zl.9Q167LxuU4UupvzxGV.94pyWBuz7XjPzB9CL/uwVV4hi.qcCWy', '02781464', 1),
('David', 'Cabrero', 'davidcabrerojimenez@gmail.com', '$2a$10$YKTkEC/e9nxMe.foZYFwbOLMeMoGSGOSih4N5VOqQZXf3VUE9fJo.', '02781465', 1),
('Celia', 'Fernandez', 'celiafernandez@ufv.es', '$2a$10$lEpOA/I7W0SqD9gyzkRbYOUfbAnrlXU76njCbBX.yVjihkTi4.RCG', '03786831', 1),
('Marcos', 'Perez', 'marcosdiaz@gmail.com', '$2a$10$pL2oht6pc0O2BSPSQ19BSeNQQn3sRZAKzLlRh39tLRSI.LyzRBkRq', '70837762', 1),
('Pablo', 'Soler', 'pablosoler@gmail.com', '$2a$10$kIhiQ5WtzlWgKOrKzP0G5eRKoORuJ5ttMM7kXbzDuucPKGwAycP3y', '84235916', 1),
('Carla', 'Muñoz', 'carlamuñoz@gmail.com', '$2a$10$tixHbBoZcBjx7hLRe.CSneaJ57r34GovZz3Yaf0fMpm7AzemU1a2G', '90628941', 2);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `aplicaciones`
--
ALTER TABLE `aplicaciones`
  ADD PRIMARY KEY (`nombre`);

--
-- Indices de la tabla `incidencias`
--
ALTER TABLE `incidencias`
  ADD PRIMARY KEY (`id_incidencia`),
  ADD KEY `dni_usuario` (`dni_usuario`),
  ADD KEY `dni_usuarioAsignado` (`dni_usuarioAsignado`),
  ADD KEY `aplicacion` (`aplicacion`);

--
-- Indices de la tabla `mensajes`
--
ALTER TABLE `mensajes`
  ADD KEY `usuario` (`usuario`),
  ADD KEY `id_incidencia` (`id_incidencia`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`DNI`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `incidencias`
--
ALTER TABLE `incidencias`
  MODIFY `id_incidencia` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `incidencias`
--
ALTER TABLE `incidencias`
  ADD CONSTRAINT `incidencias_ibfk_1` FOREIGN KEY (`dni_usuario`) REFERENCES `usuario` (`DNI`),
  ADD CONSTRAINT `incidencias_ibfk_2` FOREIGN KEY (`dni_usuarioAsignado`) REFERENCES `usuario` (`DNI`);

--
-- Filtros para la tabla `mensajes`
--
ALTER TABLE `mensajes`
  ADD CONSTRAINT `mensajes_ibfk_1` FOREIGN KEY (`usuario`) REFERENCES `usuario` (`DNI`),
  ADD CONSTRAINT `mensajes_ibfk_2` FOREIGN KEY (`id_incidencia`) REFERENCES `incidencias` (`id_incidencia`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
