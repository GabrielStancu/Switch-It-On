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
    public partial class Hint : Form
    {
        public Hint()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Levels lv = new Levels();
            this.Hide();
            lv.ShowDialog();
            this.Close();
        }
    }
}
