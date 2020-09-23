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
    public partial class Level4 : Form
    {
        public Level4()
        {
            InitializeComponent();
            timeLeft = 15;
            lbTimpRamas.Text = "15";
            timer1.Start();

            int stele1 = Variabile.stele_lv1;
            int stele2 = Variabile.stele_lv2;
            int stele3 = Variabile.stele_lv3;
            int stele4 = Variabile.stele_lv4;
            int stele5 = Variabile.stele_lv5;

            if (stele1 + stele2 + stele3 + stele4 + stele5 >= 12) { btHint.Enabled = true; btHint.BackColor = Color.DarkBlue; }
            else { btHint.Enabled = false; btHint.BackColor = Color.SlateGray; }
        }

        int timeLeft;
        int x = 0;
        int y = 0;
        int z = 0;
        int t = 0;
        int s = 0;
        int mutari = 0;

        private void bt1_Click(object sender, EventArgs e)
        {
            x++;
            if (x % 2 == 0) bt1.BackgroundImage = Properties.Resources.off_button;
            else bt1.BackgroundImage = Properties.Resources.on_button;

            mutari++;
            lbMutari.Text = mutari.ToString();

            if (x % 2 == 1 && y % 2 == 1 && z % 2 == 1 && t % 2 == 1 && s % 2 == 1)
            {
                Variabile.mutari_lv4 = mutari;
                timer1.Stop();
                Variabile.nivel_actual = 4;
                this.Hide();
                LevelPassed lp = new LevelPassed();
                lp.ShowDialog();
                this.Close();
            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            y++;
            if (y % 2 == 0) bt2.BackgroundImage = Properties.Resources.off_button;
            else bt2.BackgroundImage = Properties.Resources.on_button;

            s++;
            if (s % 2 == 0) bt5.BackgroundImage = Properties.Resources.off_button;
            else bt5.BackgroundImage = Properties.Resources.on_button;

            mutari++;
            lbMutari.Text = mutari.ToString();

            if (x % 2 == 1 && y % 2 == 1 && z % 2 == 1 && t % 2 == 1 && s % 2 == 1)
            {
                Variabile.mutari_lv4 = mutari;
                timer1.Stop();
                Variabile.nivel_actual = 4;
                this.Hide();
                LevelPassed lp = new LevelPassed();
                lp.ShowDialog();
                this.Close();
            }
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            z++;
            if (z % 2 == 0) bt3.BackgroundImage = Properties.Resources.off_button;
            else bt3.BackgroundImage = Properties.Resources.on_button;

            x++;
            if (x % 2 == 0) bt1.BackgroundImage = Properties.Resources.off_button;
            else bt1.BackgroundImage = Properties.Resources.on_button;

            mutari++;
            lbMutari.Text = mutari.ToString();

            if (x % 2 == 1 && y % 2 == 1 && z % 2 == 1 && t % 2 == 1 && s % 2 == 1)
            {
                Variabile.mutari_lv4 = mutari;
                timer1.Stop();
                Variabile.nivel_actual = 4;
                this.Hide();
                LevelPassed lp = new LevelPassed();
                lp.ShowDialog();
                this.Close();
            }
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            t++;
            if (t % 2 == 0) bt4.BackgroundImage = Properties.Resources.off_button;
            else bt4.BackgroundImage = Properties.Resources.on_button;

            x++;
            if (x % 2 == 0) bt1.BackgroundImage = Properties.Resources.off_button;
            else bt1.BackgroundImage = Properties.Resources.on_button;

            mutari++;
            lbMutari.Text = mutari.ToString();

            if (x % 2 == 1 && y % 2 == 1 && z % 2 == 1 && t % 2 == 1 && s % 2 == 1)
            {
                Variabile.mutari_lv4 = mutari;
                timer1.Stop();
                Variabile.nivel_actual = 4;
                this.Hide();
                LevelPassed lp = new LevelPassed();
                lp.ShowDialog();
                this.Close();
            }
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            s++;
            if (s % 2 == 0) bt5.BackgroundImage = Properties.Resources.off_button;
            else bt5.BackgroundImage = Properties.Resources.on_button;

            z++;
            if (z % 2 == 0) bt3.BackgroundImage = Properties.Resources.off_button;
            else bt3.BackgroundImage = Properties.Resources.on_button;

            mutari++;
            lbMutari.Text = mutari.ToString();

            if (x % 2 == 1 && y % 2 == 1 && z % 2 == 1 && t % 2 == 1 && s % 2 == 1)
            {
                Variabile.mutari_lv4 = mutari;
                timer1.Stop();
                Variabile.nivel_actual = 4;
                this.Hide();
                LevelPassed lp = new LevelPassed();
                lp.ShowDialog();
                this.Close();
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Level4 f2 = new Level4();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void btHint_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Hint f2 = new Hint();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Levels f2 = new Levels();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                lbTimpRamas.Text = timeLeft + "";
            }
            else
            {
                timer1.Stop();
                lbTimpRamas.Text = "0";

                MessageBox.Show("Time is up, try again!");

                Level4 f2 = new Level4();
                this.Hide();
                f2.ShowDialog();
                this.Close();
            }
        }
    }
}
