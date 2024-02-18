-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 18 Feb 2024 pada 09.49
-- Versi server: 10.4.24-MariaDB
-- Versi PHP: 8.1.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_bajuapd`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_admin`
--

CREATE TABLE `tbl_admin` (
  `kodeadmin` varchar(20) NOT NULL,
  `namaadmin` varchar(30) NOT NULL,
  `pwdadmin` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_admin`
--

INSERT INTO `tbl_admin` (`kodeadmin`, `namaadmin`, `pwdadmin`) VALUES
('123', '123', '123'),
('444', 'Restu', '444'),
('ADM001', 'ADMIN', 'ADMIN'),
('ADM002', 'ADMIN02', 'ADMIN');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_barang`
--

CREATE TABLE `tbl_barang` (
  `kodebarang` varchar(6) NOT NULL,
  `namabarang` varchar(30) NOT NULL,
  `jumlahbarang` int(20) NOT NULL,
  `satuanbarang` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_barang`
--

INSERT INTO `tbl_barang` (`kodebarang`, `namabarang`, `jumlahbarang`, `satuanbarang`) VALUES
('111', 'Wearpack HCA', 100, 'Pcs'),
('222', 'Wearpack MCA', 100, 'Pcs'),
('333', 'Wearpack LCA', 100, 'Pcs'),
('444', 'Safety Helmet', 100, 'Pcs'),
('555', 'Back Support', 100, 'Pcs'),
('666', 'Sarung Tangan', 100, 'Box');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_karyawan`
--

CREATE TABLE `tbl_karyawan` (
  `nik` varchar(20) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `departement` varchar(30) NOT NULL,
  `area` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_karyawan`
--

INSERT INTO `tbl_karyawan` (`nik`, `nama`, `departement`, `area`) VALUES
('123', 'Marsya', 'Production', 'Medium care'),
('134', 'Restu', 'Production', 'High care'),
('144', 'Raihan', 'Engineering', 'Medium care'),
('222', 'Agung', 'Engineering', 'High care'),
('232', 'ara', 'Engineering', 'Low care'),
('234', 'Marsya', 'Quality', 'Low care'),
('322', 'Rohman', 'Engineering', 'Low care');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbl_admin`
--
ALTER TABLE `tbl_admin`
  ADD PRIMARY KEY (`kodeadmin`);

--
-- Indeks untuk tabel `tbl_barang`
--
ALTER TABLE `tbl_barang`
  ADD PRIMARY KEY (`kodebarang`);

--
-- Indeks untuk tabel `tbl_karyawan`
--
ALTER TABLE `tbl_karyawan`
  ADD PRIMARY KEY (`nik`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
