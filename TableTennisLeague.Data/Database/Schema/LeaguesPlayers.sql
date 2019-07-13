CREATE TABLE `ttl.LeaguesPlayers` (
	`Id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`LeagueId`	INTEGER NOT NULL,
	`PlayerId`	INTEGER NOT NULL,
	FOREIGN KEY(`FK_PlayerId`) REFERENCES `ttl.Players`(`Id`),
    FOREIGN KEY(`FK_LeagueId`) REFERENCES `ttl.Leagues`(`Id`)
);