using System;
using System.Collections.Generic;
using System.Text;

namespace TableTennisLeague.Data.SqlCommands
{
    public static class GameCommand
    {
        public static readonly string GetPlayerById = @"SELECT Id
		                                                     , Name
		                                                     , CurrentRank
		                                                     , Won
		                                                     , WonOverTime
		                                                     , Lost
		                                                     , LostOverTime
                                                        FROM [ttl.Players]
                                                        WHERE [Id] = @id";
    }
}
