﻿using System;
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

            ComboCategory.SelectedIndex = 0;

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int index = -1;

            foreach (Person person in people)
            {
                if (person.Name == txtName.Text)
                {
                    index = people.IndexOf(person);
                }             
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("Fill in the name area.");
                txtName.Focus();
                return;
            }
            if (txtIsbn.Text == "   -  -")
            {
                MessageBox.Show("Fill in the isbn area.");
                txtIsbn.Focus();
                return;
            }
            string format;

            if (radioPhysical.Checked)
            {
                format = "Physical";
            }
            else
            {
                format = "eBook";
            }
            Person p = new Person();
            p.Name = txtName.Text;
            p.ReleaseDate = txtDate.Text;
            p.Category = ComboCategory.SelectedItem.ToString();
            p.Isbn = txtIsbn.Text;
            p.PortugueseLanguage = checkPortuguese.Checked;
            p.EnglishLanguage = checkEnglish.Checked;
            p.Format = format;

            if(index < 0)
            {
                people.Add(p);
            }
            else
            {
                people[index] = p;
            }

            btnClean_Click(btnClean, EventArgs.Empty);

            List();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtDate.Text = "";
            ComboCategory.SelectedIndex = 0;
            txtIsbn.Text = "";
            checkPortuguese.Checked = false;
            checkEnglish.Checked = false;
            radioPhysical.Checked = true;
            radioPhysical.Checked = false;
            txtName.Focus();
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            int index = ListView.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Select a item to delete.");
            }
            else
            {
                people.RemoveAt(index);
            }         

            List();

        }
        private void List()
        {
            ListView.Items.Clear();

            foreach (Person p in people)
            {
                ListView.Items.Add(p.Name);
            }
        }

        private void ListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = ListView.SelectedIndex;
            Person p = people[index];

            txtName.Text = p.Name;
            txtDate.Text = p.ReleaseDate;
            ComboCategory.SelectedItem = p.Category;
            txtIsbn.Text = p.Isbn;
            checkPortuguese.Checked = p.PortugueseLanguage;
            checkEnglish.Checked = p.EnglishLanguage;

            switch (p.Format)
            {
                case "Physical Book":
                    radioPhysical.Checked = true;
                    break;
                case "Ebook":
                    radioEbook.Checked = true;
                    break;
            }
        }
    }
}
