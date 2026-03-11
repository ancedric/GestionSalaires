-- =====================================================
-- Schéma SQL Server - GestionSalairesDB
-- Ce fichier définit les objets métiers de l'application.
-- =====================================================

CREATE TABLE dbo.Administrateurs (
    IdAdmin INT IDENTITY(1,1) PRIMARY KEY,
    Nom NVARCHAR(100) NOT NULL,
    Email NVARCHAR(150) NOT NULL UNIQUE,
    MotDePasse NVARCHAR(256) NOT NULL
);

CREATE TABLE dbo.Employes (
    IdEmploye INT IDENTITY(1,1) PRIMARY KEY,
    Matricule NVARCHAR(50) NOT NULL UNIQUE,
    Nom NVARCHAR(100) NOT NULL,
    Prenom NVARCHAR(100) NOT NULL,
    Poste NVARCHAR(100) NOT NULL,
    SalaireBase DECIMAL(18,2) NOT NULL,
    DateEmbauche DATE NOT NULL
);

CREATE TABLE dbo.Paie (
    IdPaie INT IDENTITY(1,1) PRIMARY KEY,
    IdEmploye INT NOT NULL,
    Mois INT NOT NULL,
    Annee INT NOT NULL,
    SalaireBase DECIMAL(18,2) NOT NULL,
    Primes DECIMAL(18,2) NOT NULL,
    HeuresSup DECIMAL(18,2) NOT NULL,
    Retenues DECIMAL(18,2) NOT NULL,
    SalaireBrut DECIMAL(18,2) NOT NULL,
    SalaireNet DECIMAL(18,2) NOT NULL,
    DateGeneration DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_Paie_Employes FOREIGN KEY (IdEmploye) REFERENCES dbo.Employes(IdEmploye)
);

CREATE INDEX IX_Employes_Matricule ON dbo.Employes(Matricule);
CREATE INDEX IX_Paie_IdEmploye_Mois_Annee ON dbo.Paie(IdEmploye, Mois, Annee);
