using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstProject1238335
{
    public partial class ClassesAndConstractor : Form
    {
        class Person
        {
            public int Age;
            public string Name;

           
            public Person()
            {
                Name = "";
                Age = 0;
            }

            
            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }


        }
        public ClassesAndConstractor()
        {
            InitializeComponent();
        }
        private void GetInformation()
        {
            Person person = new Person();
            string name = "";
            int age = 0;
            name = txtName.Text;
            age = Convert.ToInt32(txtagebox.Text);

            person = new Person(name, age);
            string info1 = person.ToString();
            string info = "Name is " + person.Name + " and age is " + person.Age+ " years";

            lblInfo.Text = info;

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            GetInformation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtName.Text="";

                txtagebox.Text="";
                lblInfo.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomePage homePage = new HomePage();
            if (homePage == null)
            {
                homePage.Parent = this;
            }
            homePage.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IndexPage indexPage = new IndexPage();
            if (indexPage == null)
            {
                indexPage.Parent = this;
            }
            indexPage.Show();
            this.Hide();
        }

    }
}
