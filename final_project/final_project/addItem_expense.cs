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
    public partial class ADD : Form
    {
        public string category = "";
        public string item = "";
        public int money = 0;
        public Boolean isadd = false;
        public ADD(bool v)
        {
            InitializeComponent();
            if (v == true)
            {
                category_input.Items.Add("食");
                category_input.Items.Add("衣");
                category_input.Items.Add("住");
                category_input.Items.Add("行");
                category_input.Items.Add("育");
                category_input.Items.Add("樂");
                category_input.Items.Add("其他");
            }
            else
            {
                category_input.Items.Add("薪水");
                category_input.Items.Add("投資");
                category_input.Items.Add("其他");
            }
        }
        
        private void ADD_Load(object sender, EventArgs e)
        {
            category = "";
            item = "";
            money = 0;
            isadd = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isadd = true;
            category = category_input.GetItemText(category_input.SelectedItem);
            item = item_input.Text;
            money = Convert.ToInt32(money_input.Text);
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            isadd = false;
            this.Close();
        }
    }
}
