namespace CardGame.Entities
{
    class Card
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int HP { get; set; }
        public int ATK { get; set; }
        public int Rank { get; set; }
        public string IMGPath { get; set; }

        public Card(int _code, string _name, string _type, string _description, int _hp, int _atk, int _rank, string _imgpath)
        {
            Code = _code;
            Name = _name;
            Type = _type;
            Description = _description;
            HP = _hp;
            ATK = _atk;
            Rank = _rank;
            IMGPath = _imgpath;
        }
    }
}