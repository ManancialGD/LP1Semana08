using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager4
{
    class CompareByName : IComparer<Player>
    {
        private bool ascending;
        public CompareByName(bool ascending)
        {
            this.ascending = ascending;
        }

        public int Compare(Player x, Player y)
        {
            if (x == null && y == null)
            {
                return 0;
            }
            else if (x == null)
            {
                return ascending ? -1 : 1;
            }
            else if (y == null)
            {
                return ascending ? 1 : -1;
            }
            else
            {
                if (ascending)
                {
                    return x.Name.CompareTo(y.Name);
                }
                else
                {
                    return y.Name.CompareTo(x.Name);
                }
            }
        }
    }
}