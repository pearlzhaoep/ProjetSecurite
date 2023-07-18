CREATE TABLE autruchelogindata(
	id INT AUTO_INCREMENT PRIMARY KEY,
    nom varchar(20) NOT NULL,
    prenom varchar(20) NOT NULL,
    username varchar(20) NOT NULL,
    email varchar(30) NOT NULL,
    salt varchar(36) NOT NULL,
    hashedmotdepasse varchar(64) NOT NULL,
    failedattempt INT default 0,
    lastlogintime DATETIME DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT CHK_autruchelogindata CHECK (nom REGEXP '^[:alpha:]+$' AND prenom REGEXP '^[:alpha:]+$' AND username REGEXP '^[:alnum:]+$')
);
