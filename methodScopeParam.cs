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
    public partial class methodScopeParam : Form
    {
        public class Sum
        {

            public int AddTwoValues(int x, int y)
            {
                return x + y;
            }

            public int AddThreeValues(int x, int y, int z)
            {
                return x + y + z;
            }
        }
        public methodScopeParam()
        {
            InitializeComponent();
        }

        
            private void btnAdd_Click(object sender, EventArgs e)
        {
            Sum sumobj=new Sum();
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int result = 0;
            num1 = Convert.ToInt16(txtNum1.Text);
            num2 = Convert.ToInt16(txtNum2.Text);
            num3 = Convert.ToInt16(txtNum3.Text);
            if ((num1 > 0) && (num2 > 0) && (num3 > 0))
            {
                result = sumobj.AddThreeValues(num1, num2, num3);
            }
            else
            {
               
                result = sumobj.AddTwoValues(num1, num2);
            }

            label5.Text = result.ToString();
        }

            private void button1_Click(object sender, EventArgs e)
            {
                txtNum1.Text = "";
                txtNum2.Text = "";
                txtNum3.Text = "";
                label5.Text = "";
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
