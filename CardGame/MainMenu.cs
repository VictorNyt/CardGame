using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardGame.Entities;

namespace CardGame
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player1 p1 = new Player1(p1Name.Text);
            string message = $"Decklist of {p1.Name}\n";

            foreach(Card c in p1.Deck)
            {
                message += $"ID - {c.Code} - {c.Name}\n";
            }

            MessageBox.Show(message);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Player2 p2 = new Player2(p1Name.Text);
            string message = $"Decklist of {p2.Name}\n";

            foreach (Card c in p2.Deck)
            {
                message += $"ID - {c.Code} - {c.Name}\n";
            }

            MessageBox.Show(message);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CardListArray cla = new CardListArray();

            string message = "All Cards available are:\n";

            for (int x = 0; x < cla.cardArray.Length; x++)
            {
                message += $"ID = {cla.cardArray[x].Code} - {cla.cardArray[x].Name}\n";
            }

            MessageBox.Show(message);
        }
    }
}