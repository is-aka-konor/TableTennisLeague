CREATE TABLE `ttl.Leagues` (
	`Id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`Name`	TEXT NOT NULL
);

CREATE INDEX `IX_Leagues_Name` ON `ttl.Leagues` (
	`Name`
);