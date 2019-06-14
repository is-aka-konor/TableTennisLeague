CREATE TABLE `ttl.Players` (
	`Id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`Name`	TEXT NOT NULL,
	`CurrentRank`	NUMERIC NOT NULL,
	`Won`	INTEGER,
	`WonOverTime`	INTEGER,
	`Lost`	INTEGER,
	`LostOverTime`	INTEGER
);

CREATE INDEX `IX_Players_Name` ON `ttl.Players` (
	`Name`	ASC
);

CREATE INDEX `IX_Players_Id` ON `ttl.Players` (
	`Id`	DESC
);