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
    public partial class EnumerationAndStruct : Form
    {
        struct Simple
        {
            public int Position;
            public double LastValue;
        };

        enum Colors
        {
            Green,
            Blue,
            Yellow,
            Gray,
            DarkMagenta,
            Red,
            Orange
        }
        public EnumerationAndStruct()
        {
            InitializeComponent();
            listBoxByEnumData.Items.AddRange(typeof(Colors).GetEnumNames());
        }

        private void lblColor_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadColor_Click(object sender, EventArgs e)
        {
            if (radioEnum.Checked)
            {
                string strData = listBoxByEnumData.SelectedItem.ToString();
                lblColor.Text = "Wow ! This is " + strData;
                lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.BackColor = System.Drawing.ColorTranslator.FromHtml(strData);
            }
            else if (radioStruct.Checked)
            {
                Simple s;
                s.Position = 1;
                s.LastValue = 5.5;

                lblColor.Text = "Position is " + s.Position + " and last value is " + s.LastValue;

            }

        }

        private void radioStruct_CheckedChanged(object sender, EventArgs e)
        {
            if (radioStruct.Checked)
            {
                btnLoadColor.Text = "Load Struct Info";
            }
            else
            {
                btnLoadColor.Text = "Load Color";
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
