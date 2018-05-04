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
    public partial class Game : Form
    {
        int diff;

        public Form RefToMainMenu
        {
            get;
            set;
        }

        public Game()
        {
            InitializeComponent();
            diff = 0;
        }

        public Game(int dif)
        {
            InitializeComponent();
            diff = dif;
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefToMainMenu.Show();
        }
    }
}
