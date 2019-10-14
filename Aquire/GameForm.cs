using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aquire
{
    // Game Form - Will use the GameManager class and usser button controls to control game flow. JR
    public partial class GameForm : Form
    {
        // Variables
        private Tiles gameTiles;


        

        // Constructor to initialzie the Form. JR
        public GameForm()
        {
            InitializeComponent();
        }

        // Loads the GameForm initially. JR
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Gold;
            this.pnlGameInfo.BackColor = Color.PowderBlue;
            this.pnlUserControl.BackColor = Color.SpringGreen;

            playerSelectScreen();

        }

       
        private void pnlUserControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTile1_Click(object sender, EventArgs e)
        {
            
        }


        // Method to change tile color. JR
        private void changeTile(Color color, RichTextBox tile)
        {
            tile.ForeColor = color;
            tile.BackColor = color;
        }

        //Method to switch to number of players selection screen. JR
        private void playerSelectScreen()
        {
            btnTile1.Hide();
            btnTile2.Hide();
            btnTile3.Hide();
            btnTile4.Hide();
            btnTile5.Hide();
            btnTile6.Hide();
            cbNumPlayers.Show();
            lblNumPlayers.Show();
        }

        // Metho do switch to user control screen. JR
        private void userControlScreen()
        {
            btnTile1.Show();
            btnTile2.Show();
            btnTile3.Show();

            btnTile4.Show();
            btnTile5.Show();
            btnTile6.Show();
            cbNumPlayers.Hide();
            lblNumPlayers.Hide();
        }

        // Event handler for cbNumPlayers control. JR

        private void cbNumPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numPlayers = Convert.ToInt32(cbNumPlayers.Text);

        }
    }
}
