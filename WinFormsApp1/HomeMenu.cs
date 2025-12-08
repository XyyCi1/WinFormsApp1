using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class HomeMenu : Form
    {



        private string _username;

        public HomeMenu(string username)
        {
            InitializeComponent();
            _username = username;
        }

        public void HomeMenu_Load(object sender, EventArgs e)
        {

            labelUsername.Text = _username + "!";
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Play playForm = new Play(_username); // pass username into Play
            playForm.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Leaderboard leaderboard = new Leaderboard();
            leaderboard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatchHistory historyForm = new MatchHistory(_username);
            historyForm.Show();
        }
    }
}
