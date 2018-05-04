using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonKnight
{

    public partial class MainMenu : Form
    {
        int dif = 0;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game playGame;
            Hide();
            if (dif == 1)
                playGame = new Game(1);
            else
                playGame = new Game();
            playGame.RefToMainMenu = this;
            playGame.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dif = 0;
            label2.Text = "Easy";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dif = 1;
            label2.Text = "Hard";
        }
    }
}
