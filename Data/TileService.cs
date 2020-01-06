using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scrabbler.Data
{
    public class TileService
    {
        private List<TileModel> _tiles;

        public List<TileModel> DistributeTiles()
        {
            _tiles = new List<TileModel>();
            for (char c = 'A'; c <= 'Z'; c++)
            {
                var thisTile = new TileModel();
                thisTile.Letter = c;
                switch (c)
                {
                    //1 Instance
                    case 'K':
                        thisTile.Points = 5;
                        thisTile.Instances = 1;
                        break;
                    case 'J':
                    case 'X':
                        thisTile.Points = 8;
                        thisTile.Instances = 1;
                        break;
                    case 'Q':
                    case 'Z':
                        thisTile.Points = 10;
                        thisTile.Instances = 1;
                        break;

                    //2 Instances
                    case 'B':
                    case 'C':
                    case 'M':
                    case 'P':
                        thisTile.Points = 3;
                        thisTile.Instances = 2;
                        break;
                    case 'F':
                    case 'H':
                    case 'V':
                    case 'W':
                    case 'Y':
                        thisTile.Points = 4;
                        thisTile.Instances = 2;
                        break;
                    //3 Instances
                    case 'G':
                        thisTile.Points = 2;
                        thisTile.Instances = 3;
                        break;
                    //4 Instances
                    case 'L':
                    case 'S':
                    case 'U':
                        thisTile.Points = 1;
                        thisTile.Instances = 4;
                        break;

                    case 'D':
                        thisTile.Points = 2;
                        thisTile.Instances = 4;
                        break;
                    //6 Instances
                    case 'N':
                    case 'R':
                    case 'T':
                        thisTile.Points = 1;
                        thisTile.Instances = 6;
                        break;
                    //8 Instances
                    case 'O':
                        thisTile.Points = 1;
                        thisTile.Instances = 8;
                        break;
                    //9 Instances
                    case 'A':
                    case 'I':
                        thisTile.Points = 1;
                        thisTile.Instances = 9;
                        break;
                    //12 Instances
                    case 'E':
                        thisTile.Points = 1;
                        thisTile.Instances = 12;
                        break;
                }
                _tiles.Add(thisTile);
            }
            return _tiles;
        }

        public int PreviewTiles(string word)
        {
            var points = 0;
            foreach (char c in word.ToUpper())
            {
                var thisTile = _tiles.Find(i => i.Letter == c);
                points = points + thisTile.Points;
            }
            return points;
        }

        public int UseTiles(string word)
        {
            var points = 0;
            foreach (char c in word.ToUpper())
            {
                var thisTile = _tiles.Find(i => i.Letter == c);
                points = points + thisTile.Points;
                thisTile.Instances = thisTile.Instances - 1;
            }
            return points;
        }

        public int UnuseTiles(string word)
        {
            var points = 0;
            foreach (char c in word.ToUpper())
            {
                var thisTile = _tiles.Find(i => i.Letter == c);
                points = points + thisTile.Points;
                thisTile.Instances = thisTile.Instances + 1;
            }
            return points;
        }
    }
}
