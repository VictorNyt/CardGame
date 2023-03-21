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
            CardListArray cla = new CardListArray();


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CardListArray cla = new CardListArray();

            string message = "";

            for(int x = 0; x < cla.cardArray.Length; x++)
            {
                message += $"ID = {cla.cardArray[x].Code} - {cla.cardArray[x].Name}\n";
            }

            MessageBox.Show(message);
        }
    }
}