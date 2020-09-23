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
    public partial class Levels : Form
    {
        public Levels()
        {
            InitializeComponent();
            if (Variabile.lv2_deblocat == 1)
            {
                btLv2.Enabled = true; btLv2.BackColor = Color.Navy;
                lbSteleLv2.BackColor = Color.Navy;
                lbSteleLv1.Text = Variabile.stele_lv1.ToString() + " / 3";
            }
            if (Variabile.lv3_deblocat == 1)
            {
                btLv3.Enabled = true; btLv3.BackColor = Color.Navy;
                lbSteleLv3.BackColor = Color.Navy;
                lbSteleLv2.Text = Variabile.stele_lv2.ToString() + " / 3";
            }
            if (Variabile.lv4_deblocat == 1)
            {
                btLv4.Enabled = true; btLv4.BackColor = Color.Navy;
                lbSteleLv4.BackColor = Color.Navy;
                lbSteleLv3.Text = Variabile.stele_lv3.ToString() + " / 3";
            }
            if (Variabile.lv5_deblocat == 1)
            {
                btLv5.Enabled = true; btLv5.BackColor = Color.Navy;
                lbSteleLv5.BackColor = Color.Navy;
                lbSteleLv4.Text = Variabile.stele_lv4.ToString() + " / 3";
            }

            if (Variabile.stele_lv5 != 0) lbSteleLv5.Text = Variabile.stele_lv5.ToString() + " / 3";
        }

        private void btLv1_Click(object sender, EventArgs e)
        {
            Level1 f2 = new Level1();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void btLv2_Click(object sender, EventArgs e)
        {
            Level2 f2 = new Level2();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void btLv3_Click(object sender, EventArgs e)
        {
            Level3 f2 = new Level3();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void btLv4_Click(object sender, EventArgs e)
        {
            Level4 f2 = new Level4();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void btLv5_Click(object sender, EventArgs e)
        {
            Level5 f2 = new Level5();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            Main f2 = new Main();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void btRestart_Click(object sender, EventArgs e)
        {
            Variabile.lv2_deblocat = 0;
            Variabile.lv3_deblocat = 0;
            Variabile.lv4_deblocat = 0;
            Variabile.lv5_deblocat = 0;

            Variabile.mutari_lv1 = 0;
            Variabile.mutari_lv2 = 0;
            Variabile.mutari_lv3 = 0;
            Variabile.mutari_lv4 = 0;
            Variabile.mutari_lv5 = 0;

            Variabile.stele_lv1 = 0;
            Variabile.stele_lv2 = 0;
            Variabile.stele_lv3 = 0;
            Variabile.stele_lv4 = 0;
            Variabile.stele_lv5 = 0;

            Variabile.nivel_actual = 0;

            Levels f2 = new Levels();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }
    }
}
// oprit timere la iesirea din form (hint, select, restart)
