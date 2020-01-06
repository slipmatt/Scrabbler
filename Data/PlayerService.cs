using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scrabbler.Data
{
    public class PlayerService
    {
        private List<PlayerModel> _players;

        public List<PlayerModel> ResetPlayers()
        {
            _players = new List<PlayerModel>();
            return _players;
        }

        public List<PlayerModel> GetPlayers()
        {
            return _players;
        }

        public void AddPlayer(string name)
        {
            var player = new PlayerModel
            {
                Name = name,
                Words=new List<string>()
            };
            _players.Add(player);
        }

        public void RemovePlayer(string name)
        {
            var player = _players.Find(i => i.Name == name);
            _players.Remove(player);
        }

        public void AddWord(string name, string word, int points)
        {
            var player = _players.Find(i => i.Name == name);
            player.Words.Add(word);
            player.Points = player.Points+points;
        }

        public void RemoveWord(string name, string word, int points)
        {
            var player = _players.Find(i => i.Name == name);
            player.Words.Remove(word);
            player.Points = player.Points - points;
        }
    }
}
