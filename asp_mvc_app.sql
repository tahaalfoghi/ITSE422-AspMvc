create database asp_mvc_app;

use asp_mvc_app;

CREATE TABLE Profiles (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    FullName LONGTEXT NOT NULL,
    Age INT NOT NULL,
    Address LONGTEXT NOT NULL,
    Gender LONGTEXT 
);


insert into Profiles (FullName, Age, Address) values
('طه احمد رضوان',22,'طرابلس-ليبيا','Male'),
('لجين عبد الرزاق زويط',23,'طرابلس-ليبيا','Female'),
('رغد مصطفى الحلواجي',22,'طرابلس-ليبيا','Female')