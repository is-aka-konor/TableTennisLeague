using System;

namespace TableTennisLeague.Data.SqlCommands
{
    public static class PlayerCommands
    {
        public const string CreatePlayer = @"
            INSERT INTO [ttl.Players] ([Name], [CurrentRank], [Won], [WonOverTime], [Lost], [LostOverTime])
            VALUES (@PlayerName, 1500, 0, 0, 0, 0);";
        public const string GetPlayerById = @"SELECT [Id], [Name], [CurrentRank], [Won], [WonOverTime], [Lost], [LostOverTime] FROM [ttl.Players] WHERE [Id] = @PlayerId";
        public const string GetAllPlayers = @"SELECT [Id], [Name], [CurrentRank], [Won], [WonOverTime], [Lost], [LostOverTime] FROM [ttl.Players]";
        public const string GetAllPlayersByLeagueId = @"
            SELECT 
                [ttl.Players].[Id], 
                [ttl.Players].[Name],
                [ttl.Players].[CurrentRank],
                [ttl.Players].[Won],
                [ttl.Players].[WonOverTime],
                [ttl.Players].[Lost],
                [ttl.Players].[LostOverTime]
            FROM [ttl.Players] 
            INNER JOIN [ttl.LeaguesPlayers] ON [ttl.Players].[Id] = [ttl.LeaguesPlayers].[PlayerId]
            WHERE [ttl.LeaguesPlayers].[LeagueId] = @LeagueId";
        public const string UpdatePlayer = @"
            UPDATE [ttl.Players] SET
            [CurrentRank] = @NewRank,
            [Won] = @NewWon,
            [WonOvertime] = @NewWonOvertime,
            [Lost] = @NewLost,
            [LostOvertime] = @NewLostOvertime
            WHERE [Id] = @PlayerId";    
    }
}
