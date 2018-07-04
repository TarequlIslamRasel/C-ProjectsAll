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
    public partial class IndexPage : Form
    {
        public IndexPage()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {
            DecisionAndIterationStatement decisionAndIterationStatement = new DecisionAndIterationStatement();
            if (decisionAndIterationStatement == null)
            {
                decisionAndIterationStatement.Parent = this;
            }
            decisionAndIterationStatement.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Variable_And_Operator variable_And_Operator = new Variable_And_Operator();
            if (variable_And_Operator == null)
            {
                variable_And_Operator.Parent = this;
            }
            variable_And_Operator.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            methodScopeParam Methodscopeparam = new methodScopeParam();
            if (Methodscopeparam == null)
            {
                Methodscopeparam.Parent = this;
            }
            Methodscopeparam.Show();
            this.Hide(); 
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ClassesAndConstractor classesandconstuctor = new ClassesAndConstractor();
            if (classesandconstuctor == null)
            {
                classesandconstuctor.Parent = this;
            }
            classesandconstuctor.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ArrayAndIterationUsingArray arrayAndIterationUsingArray = new ArrayAndIterationUsingArray();
            if (arrayAndIterationUsingArray == null)
            {
                arrayAndIterationUsingArray.Parent = this;
            }
            arrayAndIterationUsingArray.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            EnumerationAndStruct enumandstruct = new EnumerationAndStruct();
            if (enumandstruct == null)
            {
                enumandstruct.Parent = this;
            }
            enumandstruct.Show();
            this.Hide();
        }
    }
}
