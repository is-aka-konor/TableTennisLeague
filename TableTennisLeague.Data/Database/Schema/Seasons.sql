CREATE TABLE "ttl.Seasons" (
	"Id"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	"Name"	TEXT NOT NULL,
	"LeagueId"	INTEGER NOT NULL,
	FOREIGN KEY("LeagueId") REFERENCES "ttl.Leagues"("Id")
);
CREATE INDEX "IX_Seasons_Name" ON "ttl.Seasons" (
	"Name"
);
