using Darts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lesson10_SimpleDarts
{
    public class Game
    {
        private Player _player1;
        private Player _player2;
        private int DARTS_PER_ROUND = 3;


        public Game()
        {
            _player1 = new Player();
            _player1.Name = "Player 1";

            _player2 = new Player();
            _player2.Name = "Player 2";

        }

        public string Play()
        {
            while(_player1.Score < 300 || _player2.Score < 300)
            {
                // Player 1 throws his three darts and determines his score for this round
                _player1.Score = PlayerTurn(_player1);

                // Player 2 throws his three darts and determines his score for this round
                _player2.Score = PlayerTurn(_player2);

            }

            return displayResults();
            
        }

        public int PlayerTurn(Player player)
        {
            for (int i = 0; i < DARTS_PER_ROUND; i++)
            {
                Dart dart = new Dart();
                dart.Throw();
                player.Score += Score.calculateScore(dart.Score, dart.SpecialScore);
            }

            return player.Score;
        }

        public string displayResults()
        {
            string result = String.Format("{0}: {1} <br />{2}: {3} <br />",
                                            _player1.Name, _player1.Score,
                                            _player2.Name, _player2.Score);

            result += (_player1.Score > _player2.Score ? "Winner: Player 1" : "Winner: Player 2");
            return result;
        }

    }
}