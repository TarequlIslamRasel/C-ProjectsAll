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
    public partial class DecisionAndIterationStatement : Form
    {
        public DecisionAndIterationStatement()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IndexPage indexPage = new IndexPage();
            if (indexPage == null)
            {
                indexPage.Parent = this;
            }
            indexPage.Show();
            this.Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (radioIf.Checked)
            {
                ShowGradeUsingIfStatement();
            }
            else if (radioSwitch.Checked)
            {
                ShowGradeUsingSwitchStatement();
            }
            else if (radioWhile.Checked)
            {
                ShowGradeUsingWhileStatement();
            }
            else if (radioDo.Checked)
            {
                ShowGradeUsingDoWhileStatement();
            }
            else if (radioFor.Checked)
            {
                ShowTimeTableUsingForStatement();
            }
            else if (radioForEach.Checked)
            {
                ShowTimeTableUsingForEachStatement();
            }
            else
            {
                lblGrade.Text = "No option selected.";
            }

        }
        private void ShowTimeTableUsingForStatement()
        {
            int count = 0;
            int number = 0;
            string grade = "";
            label2.Text = "Show Time Table";
            lblGrade.Text = "";

            listTimeTable.Items.Clear();
            int i = 0;
            int t = 0;
            t = Convert.ToInt16(txtMark.Text);
            label2.Text = "Time Table of " + t;
            for (i = 1; i <= 10; i++)
            {
                listTimeTable.Items.Add(i + "  *  " + t + " =  " + i * t);
            }
        }
        private void ShowTimeTableUsingForEachStatement()
        {
            listTimeTable.Items.Clear();
            int count = 0;
            int number = 0;
            string grade = "";
            label2.Text = "Show Time Table";
            lblGrade.Text = "";
            //number = Convert.ToInt16(txtMark.Text);
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int t = 0;
            t = Convert.ToInt16(txtMark.Text);
            label2.Text = "Time Table of " + t;
            foreach (int num in nums)
            {
                listTimeTable.Items.Add(num + "  *  " + t + " =  " + num * t);
            }
        }
        private void ShowGradeUsingDoWhileStatement()
        {
            int count = 0;
            int percentageMark = 0;
            string grade = "";

            percentageMark = Convert.ToInt16(txtMark.Text);
            do
            {
                switch (percentageMark)
                {
                    case 70:
                        grade = "B";
                        break;
                    case 80:
                        grade = "A";
                        break;
                    case 90:
                        grade = "A*";
                        break;
                    case 100:
                        grade = "A*";
                        break;
                    default:
                        grade = "Fail";
                        break;
                }
                count++;
            } while (count < 0);
            lblGrade.Text = grade;
        }
        private void ShowGradeUsingWhileStatement()
        {
            int percentageMark = 0;
            string grade = "";
            int count = 0;
            percentageMark = Convert.ToInt16(txtMark.Text);
            while (count == 0)
            {
                switch (percentageMark)
                {
                    case 70:
                        grade = "B";
                        break;
                    case 80:
                        grade = "A";
                        break;
                    case 90:
                        grade = "A*";
                        break;
                    case 100:
                        grade = "A*";
                        break;
                    default:
                        grade = "Fail";
                        break;
                }
                count++;
            }
            lblGrade.Text = grade;
        }
        private void ShowGradeUsingSwitchStatement()
        {
            int percentageMark = 0;
            string grade = "";
            percentageMark = Convert.ToInt16(txtMark.Text);
            switch (percentageMark)
            {
                case 70:
                    grade = "B";
                    break;
                case 80:
                    grade = "A";
                    break;
                case 90:
                    grade = "A*";
                    break;
                case 100:
                    grade = "A*";
                    break;
                default:
                    grade = "Fail";
                    break;
            }
            lblGrade.Text = grade;
        }
        private void ShowGradeUsingIfStatement()
        {
            int percentageMark = 0;
            string grade = "";
            percentageMark = Convert.ToInt16(txtMark.Text);
            if (percentageMark >= 90 && percentageMark <= 100)
                grade = "A*";
            else if (percentageMark >= 80)
                grade = "A";
            else if (percentageMark >= 70)
                grade = "B";
            else if (percentageMark >= 60)
                grade = "C";
            else if (percentageMark >= 50)
                grade = "D";
            else if (percentageMark >= 40)
                grade = "E";
            else
                grade = "U";

            lblGrade.Text = grade;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomePage homePage = new HomePage();
            if (homePage == null)
            {
                homePage.Parent = this;
            }
            homePage.Show();
            this.Hide();
        }

        private void txtMark_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
