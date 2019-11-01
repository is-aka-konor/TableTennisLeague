CREATE TABLE "ttl.Games" (
	"Id"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	"SeasonId"	INTEGER NOT NULL,
	"Date"	TEXT NOT NULL,
	"ResultPlayerA"	INTEGER NOT NULL DEFAULT 0,
	"ResultPlayerB"	INTEGER NOT NULL DEFAULT 0,
	`PlayerAId`	INTEGER NOT NULL,
	`PlayerBId`	INTEGER NOT NULL,
	FOREIGN KEY(`PlayerBId`) REFERENCES `ttl.Players`(`Id`),
	FOREIGN KEY(`PlayerAId`) REFERENCES `ttl.Players`(`Id`),
	FOREIGN KEY("SeasonId") REFERENCES "ttl.Seasons"("Id")
);