using System;

namespace PlayerManager3
{
    class Player : IComparable<Player>
    {
        public Player(string name, int score)
        {
            this.Name = name;
            this.Score = score;
        }

        public string Name { get; private set; }
        public int Score { get; private set; }

        public int CompareTo(Player other)
        {
            if (other == null)
            {
                return 1;
            }
            
            return other.Score.CompareTo(this.Score);
        }
    }
}
