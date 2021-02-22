using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRegistration
{
    public partial class Form1 : Form
    {

        List<Person> people;

        public Form1()
        {
            InitializeComponent();

            people = new List<Person>();

            ComboCategory.Items.Add("Action and Adventure");
            ComboCategory.Items.Add("Fantasy");
            ComboCategory.Items.Add("Horror");
            ComboCategory.Items.Add("Romance");
            ComboCategory.Items.Add("Technology");

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {

        }

        private void bntDelete_Click(object sender, EventArgs e)
        {

        }
        private void List()
        {
            ListView.Items.Clear();

            foreach (Person p in people)
            {
                ListView.Items.Add(p.Name);
            }
        }
    }
}
