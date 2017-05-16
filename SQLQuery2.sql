
CREATE TABLE Apartment 
(Apartment_ID INT NOT NULL PRIMARY KEY,
Address varchar(50) NOT NULL,
Size INT NOT NULL,
Number_Of_Rooms int NOT NULL,
BBR FLOAT NOT NULL,
Fordelingstal FLOAT NOT NULL,
Floor INT NOT NULL,
Side VARCHAR(30) NOT NULL,
Reserved bit NOT NULL,
);

CREATE TABLE Resident(
Resident_ID varchar(30) NOT NULL,
Apartment_ID INT NOT NULL ,
Name varchar(30) NOT NULL,
Address varchar(50) NOT NULL,
Phone_Number int NOT NULL,
Age INT NOT NULL,
Email varchar (50),
Moved_In Date NOT NULL,
Moved_Out Date NOT NULL,
Board_Member bit NOT NULL,

FOREIGN KEY(Apartment_ID) REFERENCES Apartment (Apartment_ID),
PRIMARY KEY ( Resident_ID)
);