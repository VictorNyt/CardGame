using System.Collections.Generic;

namespace CardGame.Entities
{
    class Player2 : Player
    {
        public Player2(string name)
        {
            Name = name;
            HP = 20;
            Deck = DeckCreator();
            HandCards = null;
        }

        List<Card> DeckCreator()
        {
            CardListArray cla = new CardListArray();

            List<Card> list = new List<Card>();

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    list.Add(cla.cardArray[x]);
                }
            }

            return list;
        }
    }
}