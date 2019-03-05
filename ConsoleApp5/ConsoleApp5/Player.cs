using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Player: Person
    {
        private string _position;
        private string _club;
        private int _goals;

        public Player() : base()
        {
            _position = "brak";
            _club = "brak";
            _goals = 0;
        }
        public Player(string fn, string ln, int d, int m, int y,
            string pos, string cl):base(fn, ln,d,m,y)
        {
            _position = pos;
            _club = cl;
            _goals = 0;
        }
        public void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Club: {_club}");
            Console.WriteLine($"Position: {_position}");
            Console.WriteLine($"Goals: {_goals}");
        }
        public void ScoreGoal()
        {
            _goals++;
        }
    }
}
