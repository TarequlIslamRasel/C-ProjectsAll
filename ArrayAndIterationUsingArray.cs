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
    public partial class ArrayAndIterationUsingArray : Form
    {
        public ArrayAndIterationUsingArray()
        {
            InitializeComponent();
            LoadListUsingArray();
        }
        private void LoadListUsingArray()
        {
            string[] weekDays = new string[7];

            weekDays[0] = "FRIDAY";
            weekDays[1] = "SATURDAY";
            weekDays[2] = "SUNDAY";
            weekDays[3] = "MONDAY";
            weekDays[4] = "TUESDAY";
            weekDays[5] = "WEDNESDAY";
            weekDays[6] = "THURSDAY";
            listBoxWeekDays.Items.AddRange(weekDays);

        }

        private void btnIterate_Click(object sender, EventArgs e)
        {
            foreach (var item in listBoxIntermediate.Items)
            {
                listBoxAfterIteration.Items.Add(item);
            }
            listBoxIntermediate.Items.Clear();

        }

        private void listBoxIntermediate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxWeekDays.SelectedItem.ToString();
            int index = listBoxWeekDays.FindString(curItem);
            if (index == -1)
                MessageBox.Show("Item is not available in ListBox2");
            else
            {
                listBoxIntermediate.Items.Add(curItem);
            }
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

