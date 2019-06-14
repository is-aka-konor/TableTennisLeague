using System;
using System.Collections.Generic;
using TableTennisLeague.Data.Model;

namespace TableTennisLeague.EloRanker
{
    public class EloRanker
    {
        private double _k = 30;
        private double _chanceToWinA;
        private double _chanceToWinB;
        private readonly int _resultA;
        private readonly int _resultB;
        private readonly Player _playerA;
        private readonly Player _playerB;


        public EloRanker(Game game)
        {
            _playerA = game.PlayerA;
            _playerB = game.PlayerB;
            this._resultA = game.ResultA;
            this._resultB = game.ResultB;
            CalculateProbability();
        }

        public List<Player> GetUpdatedRanks()
        {
            return RecalculateRatings(this._resultA, this._resultB);
        }

        private void CalculateProbability()
        {
            this._chanceToWinA = 1.0D / (1.0D + Math.Pow(10.0D, (_playerB.CurrentRank - _playerA.CurrentRank) / 400));
            this._chanceToWinB = 1.0D / (1.0D + Math.Pow(10.0D, (_playerA.CurrentRank - _playerB.CurrentRank) / 400));
        }

        private List<Player> RecalculateRatings(int resultA, int resultB)
        {
            var result = new List<Player>();
            // calcualte new ratings
            var newRatingA = CalculateRating(_playerA.CurrentRank, resultA, resultB, this._chanceToWinA, "A");
            var newRatingB = CalculateRating(_playerB.CurrentRank, resultA, resultB, this._chanceToWinB, "B");
            // update raings
            _playerA.CurrentRank = newRatingA;
            _playerB.CurrentRank = newRatingB;
            // return player's objects with new ratings
            result.Add(_playerA);
            result.Add(_playerB);
            return result;
        }

        private double CalculateRating(
            double currentRating,
            int resultA,
            int resultB,
            double chanceToWin,
            string player
        )
        {
            var result = IsWinner(player, resultA, resultB) ? 1 : 0;
            var isFavorite = chanceToWin > 0.5 ? -1 : 1;
            return currentRating +
                (this._k * (result - chanceToWin) + isFavorite * GetTtCoefficient(resultA, resultB));
        }

        private double GetTtCoefficient(int resultA, int resultB)
        {
            return (20 - (resultA + resultB) + this._k / 4) / 2;
        }

        private bool IsWinner(string player, int resultA, int resultB)
        {
            bool result;
            if (player.Trim().ToUpper() == "A")
            {
                result = resultA > resultB;
            }
            else
            {
                result = resultA < resultB;
            }
            return result;
        }
    }
}
