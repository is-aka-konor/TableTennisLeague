CREATE TABLE "ttl.Games" (
	"Id"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	"Date"	TEXT NOT NULL,
	"ResultPlayerA"	INTEGER NOT NULL DEFAULT 0,
	"ResultPlayerB"	INTEGER NOT NULL DEFAULT 0
);