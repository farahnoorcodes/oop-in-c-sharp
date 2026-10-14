namespace cards_game
{
    public class card
    {
        public string suit{ get; }
        public  int value{ get; }
        public card(string suit, int value)
        {
            this.suit = suit;
            this.value = value;
        }
        public bool isfacecard()
        {
            if (value == 11 || value == 12 || value == 13)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
