using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_It_On_
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            label1.Left = (this.Width-label1.Width)/ 2;
            btNewGame.Left = (this.Width - btNewGame.Width) / 2;
            btInstr.Left = (this.Width - btInstr.Width) / 2;
            btExit.Left = (this.Width - btExit.Width) / 2;
        }

        private void btNewGame_Click(object sender, EventArgs e)
        {
            Levels f2 = new Levels();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void btInstr_Click(object sender, EventArgs e)
        {
            Instructions f2 = new Instructions();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
