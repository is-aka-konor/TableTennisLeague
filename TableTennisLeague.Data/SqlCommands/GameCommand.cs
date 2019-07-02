namespace TableTennisLeague.Data.SqlCommands
{
    public static class GameCommands
    {
        public static readonly string GetGameById = @"SELECT GameId
                                                            , LeagueId
                                                            , SeasonId
                                                            , GameDate
                                                            , PlayerAId
                                                            , PlayerBId
                                                            , PlayerAName
                                                            , PlayerBName
                                                            , ResultPlayerA
                                                            , ResultPlayerB
                                                        FROM [ttl.vw_GamesPlayers]
                                                       WHERE GameId = @GameId;";

        public static readonly string GetAllGames = @"SELECT GameId
                                                            , LeagueId
                                                            , SeasonId
                                                            , GameDate
                                                            , PlayerAId
                                                            , PlayerBId
                                                            , PlayerAName
                                                            , PlayerBName
                                                            , ResultPlayerA
                                                            , ResultPlayerB
                                                        FROM [ttl.vw_GamesPlayers];";

        public static readonly string GetAllGamesByLeagueId = @"SELECT GameId
                                                                    , LeagueId
                                                                    , SeasonId
                                                                    , GameDate
                                                                    , PlayerAId
                                                                    , PlayerBId
                                                                    , PlayerAName
                                                                    , PlayerBName
                                                                    , ResultPlayerA
                                                                    , ResultPlayerB
                                                                FROM [ttl.vw_GamesPlayers]
                                                                WHERE LeagueId = @LeagueId;";

        public static readonly string GetAllGamesBySeasonId = @"SELECT GameId
                                                                    , LeagueId
                                                                    , SeasonId
                                                                    , GameDate
                                                                    , PlayerAId
                                                                    , PlayerBId
                                                                    , PlayerAName
                                                                    , PlayerBName
                                                                    , ResultPlayerA
                                                                    , ResultPlayerB
                                                                FROM [ttl.vw_GamesPlayers]
                                                                WHERE SeasonId = @SeasonId;";

        public static readonly string GetAllGamesByPlayerId = @"SELECT GameId
                                                                    , LeagueId
                                                                    , SeasonId
                                                                    , GameDate
                                                                    , PlayerAId
                                                                    , PlayerBId
                                                                    , PlayerAName
                                                                    , PlayerBName
                                                                    , ResultPlayerA
                                                                    , ResultPlayerB
                                                                FROM [ttl.vw_GamesPlayers]
                                                                WHERE PlayerAId = @playerId OR PlayerBId = @playerId";

        public static readonly string CreateGame = @"INSERT INTO [ttl.Games]
                                                            ( SeasonId,  Date,  ResultPlayerA,  ResultPlayerB,  PlayerAId,  PlayerBId)
                                                     VALUES (@SeasonId, @Date, @ResultPlayerA, @ResultPlayerB, @PlayerAId, @PlayerBId);";

        public static readonly string DeleteGame = @"DELETE FROM [ttl.Games] WHERE Id = @GameId";

        public static readonly string UpdateGame = @"UPDATE [ttl.Games] SET
                                                    SeasonId = @SeasonId,
                                                    Date = @Date,
                                                    ResultPlayerA = @ResultPlayerA,
                                                    ResultPlayerB = @ResultPlayerB,
                                                    PlayerAId = @PlayerAId,
                                                    PlayerBId = @PlayerBId)";
    }
}
