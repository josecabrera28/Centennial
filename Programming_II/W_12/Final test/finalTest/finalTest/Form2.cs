using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalTest
{
    public partial class Form2 : Form
    {
        private List<Hero> heroList;
        public Form2()
        {
            InitializeComponent();
            heroList = Hero.GetHeros();
            dgrdHero.DataSource = heroList;
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible= false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dgrdHero.AutoGenerateColumns=true;
            
        }

        public void AddHero(Hero newHero)
        {
            heroList.Add(newHero);
            dgrdHero.DataSource = null;
            dgrdHero.DataSource = heroList;
            dgrdHero.Refresh();
        }
    }
}
