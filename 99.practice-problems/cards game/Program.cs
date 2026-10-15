using System;
namespace cards_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
           deck d = new deck();
            d.shuffle();
            players p1 = new players("Player 1");
            players p2 = new players("Player 2");
            for(int i = 0; i < 5; i++)
            {
                p1.addcard(d.dealcard());
                p2.addcard(d.dealcard());
            }
            Console.WriteLine($"Player: {p1.name}, Total Value of Hand: {p1.gettotal()}");
            Console.WriteLine($"Player: {p1.name}, Face Card Count: {p1.getfacecardcount()}");
            Console.WriteLine($"Player: {p1.name}, Face Card Sum: {p1.getfacecardsum()}");
            Console.WriteLine($"Player: {p2.name}, Total Value of Hand: {p2.gettotal()}");
            Console.WriteLine($"Player: {p2.name}, Face Card Count: {p2.getfacecardcount()}");
            Console.WriteLine($"Player: {p2.name}, Face Card Sum: {p2.getfacecardsum()}");
            if (p1.gettotal() > p2.gettotal())
            {
                Console.WriteLine(p1.name + " wins");
            }
            else if (p2.gettotal() > p1.gettotal())
            {
                Console.WriteLine(p2.name + " wins");
            }
            else
            {
                
                    if (p1.getfacecardcount() > p2.getfacecardcount())
                    {
                        Console.WriteLine(p1.name + " wins");
                }
                    else if (p2.getfacecardcount() > p1.getfacecardcount())
                    {
                        Console.WriteLine(p2.name + " wins");
                }
                    else
                    {
                         if(p1.getfacecardsum() > p2.getfacecardsum())
                        {
                            Console.WriteLine(p1.name + " wins");
                    }
                        else if(p2.getfacecardsum() > p1.getfacecardsum())
                        {
                            Console.WriteLine(p2.name + " wins");
                    }
                    }
                
            }
        }
    }
}
