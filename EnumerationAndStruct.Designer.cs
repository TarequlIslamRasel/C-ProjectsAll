namespace MyFirstProject1238335
{
    partial class EnumerationAndStruct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxByEnumData = new System.Windows.Forms.ListBox();
            this.radioEnum = new System.Windows.Forms.RadioButton();
            this.radioStruct = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnLoadColor = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxByEnumData
            // 
            this.listBoxByEnumData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBoxByEnumData.ForeColor = System.Drawing.Color.Black;
            this.listBoxByEnumData.FormattingEnabled = true;
            this.listBoxByEnumData.Location = new System.Drawing.Point(80, 183);
            this.listBoxByEnumData.Name = "listBoxByEnumData";
            this.listBoxByEnumData.Size = new System.Drawing.Size(120, 95);
            this.listBoxByEnumData.TabIndex = 7;
            // 
            // radioEnum
            // 
            this.radioEnum.AutoSize = true;
            this.radioEnum.Checked = true;
            this.radioEnum.Location = new System.Drawing.Point(6, 15);
            this.radioEnum.Name = "radioEnum";
            this.radioEnum.Size = new System.Drawing.Size(95, 17);
            this.radioEnum.TabIndex = 4;
            this.radioEnum.TabStop = true;
            this.radioEnum.Text = "Enumeration";
            this.radioEnum.UseVisualStyleBackColor = true;
            // 
            // radioStruct
            // 
            this.radioStruct.AutoSize = true;
            this.radioStruct.Location = new System.Drawing.Point(121, 15);
            this.radioStruct.Name = "radioStruct";
            this.radioStruct.Size = new System.Drawing.Size(59, 17);
            this.radioStruct.TabIndex = 5;
            this.radioStruct.Text = "Struct";
            this.radioStruct.UseVisualStyleBackColor = true;
            this.radioStruct.CheckedChanged += new System.EventHandler(this.radioStruct_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioEnum);
            this.groupBox1.Controls.Add(this.radioStruct);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(80, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 38);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(224, 316);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(44, 13);
            this.lblColor.TabIndex = 10;
            this.lblColor.Text = "Color :";
            this.lblColor.UseWaitCursor = true;
            this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // btnLoadColor
            // 
            this.btnLoadColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadColor.Location = new System.Drawing.Point(225, 255);
            this.btnLoadColor.Name = "btnLoadColor";
            this.btnLoadColor.Size = new System.Drawing.Size(103, 23);
            this.btnLoadColor.TabIndex = 9;
            this.btnLoadColor.Text = "Load Color";
            this.btnLoadColor.UseVisualStyleBackColor = true;
            this.btnLoadColor.Click += new System.EventHandler(this.btnLoadColor_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(77, 139);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(178, 16);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Loading List using enum.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(12, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 18);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Home";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(18, 430);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(46, 18);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Back";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // EnumerationAndStruct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(649, 469);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.listBoxByEnumData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.btnLoadColor);
            this.Controls.Add(this.lblTitle);
            this.Name = "EnumerationAndStruct";
            this.Text = "EnumerationAndStruct";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxByEnumData;
        private System.Windows.Forms.RadioButton radioEnum;
        private System.Windows.Forms.RadioButton radioStruct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnLoadColor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}