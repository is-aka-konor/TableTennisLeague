CREATE VIEW [ttl.vw_GamesPlayers] AS 
SELECT s.[LeagueId]
     , s.[Id] AS 'SeasonId'
     , g.[Id] AS 'GameId'
     , g.[Date] AS 'GameDate'
     , pA.[Id] AS 'PlayerAId'
     , pB.[Id] AS 'PlayerBId'
     , pA.[Name] AS 'PlayerA'
     , pB.[Name] AS 'PlayerB'
     , g.[ResultPlayerA]
     , g.[ResultPlayerB]
FROM [ttl.Games] AS g
INNER JOIN [ttl.Seasons] AS s ON s.[Id] = g.[SeasonId]
LEFT JOIN [ttl.Players] AS pA ON g.[PlayerAId] = pA.[Id] 
LEFT JOIN [ttl.Players] AS pb ON g.[PlayerBId] = pB.[Id];