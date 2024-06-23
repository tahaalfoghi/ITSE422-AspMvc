create database asp_mvc_app;

use asp_mvc_app;

CREATE TABLE Profiles (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    FullName LONGTEXT NOT NULL,
    Age INT NOT NULL,
    Address LONGTEXT NOT NULL,
    Gender LONGTEXT NOT NULL
);


insert into Profiles (FullName, Age, Address) values
('طه احمد رضوان',22,'طرابلس-ليبيا'),
('لجين عبد الرزاق زويط',23,'طرابلس-ليبيا'),
('رغد مصطفى الحلواجي',22,'طرابلس-ليبيا')