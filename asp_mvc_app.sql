create database asp_mvc_app;

use asp_mvc_app;

CREATE TABLE Profiles (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    FullName LONGTEXT NOT NULL,
    Age INT NOT NULL,
    Address LONGTEXT NOT NULL,
    Gender LONGTEXT 
);
