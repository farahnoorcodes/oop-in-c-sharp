
using System.Collections.Generic;
namespace cards_game
{
    public class players
    {
        List<card> hand = new List<card>();
        public string name;
        public players(string name)
        {
            this.name = name;
        }
        public void addcard(card newcard)
        {
            hand.Add(newcard);

        }
        public int gettotal()
        {
            int total = 0;
            foreach (card c in hand)
            {
                total += c.value;
            }
            return total;
        }

        public int getfacecardcount()
        {
            int facecardcount = 0;
            foreach (card c in hand)
            {
                if (c.isfacecard())
                {
                    facecardcount++;
                }
            }
            return facecardcount;
        }
        public int getfacecardsum()
        {
            int facecardsum = 0;
            foreach (card c in hand)
            {
                if (c.isfacecard())
                {
                    facecardsum += c.value;
                }
            }
            return facecardsum;
        }
    }
    }
