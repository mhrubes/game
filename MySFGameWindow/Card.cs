using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySFGameWindow
{
    public enum Suit
    {
        Heart, Diamond, Spade, Club
    }

    public enum Face
    {
        Ace, Two, Three, Four, Five, Six, Seven,
        Eight, Nine, Ten, Jack, Queen, King,
    }

    class Card
    {
        public Suit suit { get; set; }
        public Face face { get; set; }
        public int Value { get; set; }
    }
}
