CREATE TABLE Cloud 
(
	CloudService varchar(30),
	Username varchar(50),
	Pws varchar(50), 
	GamePath varchar(max)
	FOREIGN KEY (GamePath) REFERENCES General(GamePath)
)
