using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class FootballPlayer : Person
    {
        private string position;
        private string club;
        private int goalCount;

        public int GoalCount
        {
            get { return goalCount; }
            set { goalCount = value; }
        }


        public string Club
        {
            get { return club; }
            set { club = value; }
        }


        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public FootballPlayer() : base()
        {
            position = "none";
            club = "none";
            goalCount = 0;
        }

        public FootballPlayer(string name_, string surname_, DateTime dateOfBirth_, string position_, string club_, int goalCount_ ) : base(name_, surname_, dateOfBirth_)
        {
            position = position_;
            club = club_;
            goalCount = goalCount_;
        }

        public void Gooal()
        {
            goalCount++;
        }

        public override string ToString()
        {
            string strr = base.ToString() + $" Position: {position}, Club: {club}, Goal Count: {goalCount}";
            return strr;
        }

        public override void Details()
        {
            Console.WriteLine(this);
        }
    }
}
