namespace CardGame.Entities
{
    class CardListArray
    {
        public Card[] cardArray;

        public CardListArray()
        {
            DBFake fake = new DBFake();
            fake.StartDB();
            cardArray = fake.cardlist.ToArray();
        }
    }
}