using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form_money f2;
        private void form_money_btn_Click(object sender, EventArgs e)
        {
            f2 = new Form_money();
            f2.ShowDialog();
        }
    }
}
