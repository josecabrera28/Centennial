using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalTest
{
    public partial class Form1 : Form
    {

        private Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            form2.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> powerList = new List<string>();
            powerList.Add(PowerEnum.None.ToString());
            powerList.Add(PowerEnum.Healing.ToString());
            powerList.Add(PowerEnum.Strength.ToString());
            powerList.Add(PowerEnum.Teleporter.ToString());
            powerList.Add(PowerEnum.Elemental_Control.ToString());
            cboPower.DataSource = powerList;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string name;
            int age;
            try
            {
                age = Convert.ToInt32(txtAge.Text);
                name = txtName.Text;
                while(name == "")
                {
                    MessageBox.Show("Input the hero´s name");
                    return;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message + "\nPlease input a number into Age field");
                return;
            }            
            bool isgood = chkIsGood.Checked;
            PowerEnum power = (PowerEnum)Enum.Parse(typeof(PowerEnum),cboPower.SelectedValue.ToString());
            Hero myHero = new Hero(name,age,isgood,power);
            form2.AddHero(myHero);
            btnCancel_Click(this,e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text= string.Empty;
            txtAge.Text= string.Empty;
            chkIsGood.Checked= true;
            cboPower.SelectedIndex= 0;
        }
    }
}
