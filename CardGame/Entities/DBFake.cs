using System.Collections.Generic;
using System.IO;

namespace CardGame.Entities
{
    class DBFake
    {
        public List<Card> cardlist = new List<Card>();

        public void StartDB()
        {
            string path = @"C:\Users\victo\Desktop\Artwork\DB.txt";

            StreamReader sr = null;
            sr = File.OpenText(path);
            while (!sr.EndOfStream)
            {
                string[] cards = sr.ReadLine().Split(',');

                Card card = new Card(int.Parse(cards[0]), cards[1], cards[2], cards[3], int.Parse(cards[4]), int.Parse(cards[5]),
                    int.Parse(cards[6]), cards[7]);
                cardlist.Add(card);
            }

        }
    }
}