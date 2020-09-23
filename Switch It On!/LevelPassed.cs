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
    public partial class LevelPassed : Form
    {
        public LevelPassed()
        {
            InitializeComponent();
            if (Variabile.nivel_actual ==1)
            {
                label2.Text = "You have successfully completed the 1st level!";
                if (Variabile.mutari_lv1 == 3)
                {
                    pbStele.BackgroundImage = Switch_It_On_.Properties.Resources.picturebox___3_stele;
                    Variabile.stele_lv1 = 3;
                }
                else if (Variabile.mutari_lv1 == 4 || Variabile.mutari_lv1 == 5)
                {
                    pbStele.BackgroundImage = Switch_It_On_.Properties.Resources.picturebox___2_stele;
                    Variabile.stele_lv1 = 2;
                }
                else
                {
                    pbStele.BackgroundImage = Switch_It_On_.Properties.Resources.picturebox___1_stea;
                    Variabile.stele_lv1 = 1;
                }
                Variabile.lv2_deblocat = 1;
            }


            else if (Variabile.nivel_actual == 2)
            {
                label2.Text = "You have successfully completed the 2nd level!";
                if (Variabile.mutari_lv2 == 4) { pbStele.BackgroundImage = Switch_It_On_.Properties.Resources.picturebox___3_stele; Variabile.stele_lv2 = 3; }
                else if (Variabile.mutari_lv2 == 5 || Variabile.mutari_lv2 == 6) { pbStele.BackgroundImage = Switch_It_On_.Properties.Resources.picturebox___2_stele; Variabile.stele_lv2 = 2; }
                else { pbStele.BackgroundImage = Switch_It_On_.Properties.Resources.picturebox___1_stea; Variabile.stele_lv2 = 1; }
                Variabile.lv3_deblocat = 1;
            }

            else if (Variabile.nivel_actual == 3)
            {
                label2.Text = "You have successfully completed the 3rd level!";
                if (Variabile.mutari_lv3 == 4) { pbStele.BackgroundImage = Switch_It_On_.Properties.Resources.picturebox___3_stele; Variabile.stele_lv3 = 3; }
                else if (Variabile.mutari_lv3 == 5 || Variabile.mutari_lv3 == 6) { pbStele.BackgroundImage = Switch_It_On_.Properties.Resources.picturebox___2_stele; Variabile.stele_lv3 = 2; }
                else { pbStele.BackgroundImage = Switch_It_On_.Properties.Resources.picturebox___1_stea; Variabile.stele_lv3 = 1; }
                Variabile.lv4_deblocat = 1;
            }

            else if (Variabile.nivel_actual == 4)
            {
                label2.Text = "You have successfully completed the 4th level!";
                if (Variabile.mutari_lv4 == 4) { pbStele.BackgroundImage = Switch_It_On_.Properties.Resources.picturebox___3_stele; Variabile.stele_lv4 = 3; }
                else if (Variabile.mutari_lv4 == 5 || Variabile.mutari_lv4 == 6) { pbStele.BackgroundImage = Switch_It_On_.Properties.Resources.picturebox___2_stele; Variabile.stele_lv4 = 2; }
                else { pbStele.BackgroundImage = Switch_It_On_.Properties.Resources.picturebox___1_stea; Variabile.stele_lv4 = 1; }
                Variabile.lv5_deblocat = 1;
            }
            else if (Variabile.nivel_actual == 5)
            {
                label2.Text = "You have successfully completed the 5th level!";
                if (Variabile.mutari_lv5 == 6) { pbStele.BackgroundImage = Switch_It_On_.Properties.Resources.picturebox___3_stele; Variabile.stele_lv5 = 3; }
                else if (Variabile.mutari_lv5 == 7 || Variabile.mutari_lv5 == 8) { pbStele.BackgroundImage = Switch_It_On_.Properties.Resources.picturebox___2_stele; Variabile.stele_lv5 = 2; }
                else { pbStele.BackgroundImage = Switch_It_On_.Properties.Resources.picturebox___1_stea; Variabile.stele_lv5 = 1; }
            }
        }

        private void bt_select_Click(object sender, EventArgs e)
        {
            this.Hide();
            Levels lv = new Levels();
            lv.ShowDialog();
            this.Close();
        }

        private void bt_Replay_Click(object sender, EventArgs e)
        {
            this.Hide();
            string level_restart = string.Empty;
            if (Variabile.nivel_actual == 1) { Level1 lv = new Level1(); lv.ShowDialog(); }    
            else if (Variabile.nivel_actual == 2) { Level2 lv = new Level2(); lv.ShowDialog(); }
            else if (Variabile.nivel_actual == 3) { Level3 lv = new Level3(); lv.ShowDialog(); }
            else if (Variabile.nivel_actual == 4) { Level4 lv = new Level4(); lv.ShowDialog(); }
            else { Level5 lv = new Level5(); lv.ShowDialog(); }
            this.Close();
        }
    }
}
