INSERT INTO Heroes VALUES('Captain Swinburne',6,1,2,'1')
INSERT INTO Heroes VALUES ('Rick', 10,4,2,'2')

INSERT INTO Villains VALUES('FaceBook',4,'1')
INSERT INTO Villains VALUES('Management Man',5,'2')
INSERT INTO Villains VALUES('Covid Cal',2,3)
INSERT INTO Villains VALUES('Networking Nancy',2,'4')

INSERT INTO GAME VALUES('1-1-1900','w')
INSERT INTO GAME VALUES('1-1-1901','w')
INSERT INTO GAME VALUES('2-2-1998','l')
INSERT INTO GAME VALUES('1-1-1998','l')


Select * From Villains
SELECT * FROM Heroes
SELECT * FROM GAME

SELECT TOP 10 * FROM GAME ORDER BY [DateTime] DESC