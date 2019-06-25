using System;
using System.Collections.Generic;
using System.Text;

namespace TableTennisLeague.Data.SqlCommands
{
    public static class GameCommand
    {
        public static readonly string GetAllGames = @"SELECT GameId
                                                            , GameDate
                                                            , PlayerA
                                                            , PlayerB
                                                            , ResultPlayerA
                                                            , ResultPlayerB
                                                        FROM [ttl.vw_GamesPlayers];";

        public static readonly string GetAllGamesByLeagueId = @"SELECT GameId
                                                                    , GameDate
                                                                    , PlayerA
                                                                    , PlayerB
                                                                    , ResultPlayerA
                                                                    , ResultPlayerB
                                                                FROM [ttl.vw_GamesPlayers]
                                                                WHERE LeagueId = @LeagueId;";

        public static readonly string GetAllGamesBySeasonId = @"SELECT GameId
                                                                    , GameDate
                                                                    , PlayerA
                                                                    , PlayerB
                                                                    , ResultPlayerA
                                                                    , ResultPlayerB
                                                                FROM [ttl.vw_GamesPlayers]
                                                                WHERE SeasonId = @SeasonId;";

        public static readonly string CreateGame = @"INSERT INTO [ttl.Games]
                                                            ( SeasonId,  Date,  ResultPlayerA,  ResultPlayerB,  PlayerAId,  PlayerBId)
                                                     VALUES (@SeasonId, @Date, @ResultPlayerA, @ResultPlayerB, @PlayerAId, @PlayerBId);";
    }
}
