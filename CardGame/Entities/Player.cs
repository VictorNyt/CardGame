using System.Collections.Generic;

namespace CardGame.Entities
{
    abstract class Player
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public List<Card> Deck { get; set; }
        public List<Card> HandCards { get; set; }
    }
}
