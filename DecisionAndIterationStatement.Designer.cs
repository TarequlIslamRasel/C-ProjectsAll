namespace MyFirstProject1238335
{
    partial class DecisionAndIterationStatement
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupIf = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblGrade = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.lblEnter = new System.Windows.Forms.Label();
            this.radioForEach = new System.Windows.Forms.RadioButton();
            this.radioDo = new System.Windows.Forms.RadioButton();
            this.radioFor = new System.Windows.Forms.RadioButton();
            this.radioWhile = new System.Windows.Forms.RadioButton();
            this.radioSwitch = new System.Windows.Forms.RadioButton();
            this.radioIf = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listTimeTable = new System.Windows.Forms.ListBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupIf.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(36, 424);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(46, 18);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(67, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Decision And Iteration";
            // 
            // groupIf
            // 
            this.groupIf.Controls.Add(this.btnShow);
            this.groupIf.Controls.Add(this.lblGrade);
            this.groupIf.Controls.Add(this.label2);
            this.groupIf.Controls.Add(this.txtMark);
            this.groupIf.Controls.Add(this.lblEnter);
            this.groupIf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupIf.Location = new System.Drawing.Point(257, 135);
            this.groupIf.Name = "groupIf";
            this.groupIf.Size = new System.Drawing.Size(197, 177);
            this.groupIf.TabIndex = 6;
            this.groupIf.TabStop = false;
            this.groupIf.Text = "If Statement";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(31, 116);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show ";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(113, 77);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(42, 15);
            this.lblGrade.TabIndex = 3;
            this.lblGrade.Text = "Show";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Show Grade";
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(130, 30);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(58, 21);
            this.txtMark.TabIndex = 1;
            this.txtMark.TextChanged += new System.EventHandler(this.txtMark_TextChanged);
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Location = new System.Drawing.Point(28, 30);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(96, 15);
            this.lblEnter.TabIndex = 0;
            this.lblEnter.Text = "Enter Number";
            // 
            // radioForEach
            // 
            this.radioForEach.AutoSize = true;
            this.radioForEach.Location = new System.Drawing.Point(7, 149);
            this.radioForEach.Name = "radioForEach";
            this.radioForEach.Size = new System.Drawing.Size(86, 19);
            this.radioForEach.TabIndex = 5;
            this.radioForEach.TabStop = true;
            this.radioForEach.Text = "For Each ";
            this.radioForEach.UseVisualStyleBackColor = true;
            // 
            // radioDo
            // 
            this.radioDo.AutoSize = true;
            this.radioDo.Location = new System.Drawing.Point(7, 102);
            this.radioDo.Name = "radioDo";
            this.radioDo.Size = new System.Drawing.Size(112, 19);
            this.radioDo.TabIndex = 4;
            this.radioDo.TabStop = true;
            this.radioDo.Text = "Do Statement";
            this.radioDo.UseVisualStyleBackColor = true;
            // 
            // radioFor
            // 
            this.radioFor.AutoSize = true;
            this.radioFor.Location = new System.Drawing.Point(6, 125);
            this.radioFor.Name = "radioFor";
            this.radioFor.Size = new System.Drawing.Size(115, 19);
            this.radioFor.TabIndex = 3;
            this.radioFor.TabStop = true;
            this.radioFor.Text = "For Statement";
            this.radioFor.UseVisualStyleBackColor = true;
            // 
            // radioWhile
            // 
            this.radioWhile.AutoSize = true;
            this.radioWhile.Location = new System.Drawing.Point(6, 77);
            this.radioWhile.Name = "radioWhile";
            this.radioWhile.Size = new System.Drawing.Size(130, 19);
            this.radioWhile.TabIndex = 2;
            this.radioWhile.TabStop = true;
            this.radioWhile.Text = "While Statement";
            this.radioWhile.UseVisualStyleBackColor = true;
            // 
            // radioSwitch
            // 
            this.radioSwitch.AutoSize = true;
            this.radioSwitch.Location = new System.Drawing.Point(6, 50);
            this.radioSwitch.Name = "radioSwitch";
            this.radioSwitch.Size = new System.Drawing.Size(136, 19);
            this.radioSwitch.TabIndex = 1;
            this.radioSwitch.TabStop = true;
            this.radioSwitch.Text = "Switch Statement";
            this.radioSwitch.UseVisualStyleBackColor = true;
            // 
            // radioIf
            // 
            this.radioIf.AutoSize = true;
            this.radioIf.Location = new System.Drawing.Point(7, 26);
            this.radioIf.Name = "radioIf";
            this.radioIf.Size = new System.Drawing.Size(102, 19);
            this.radioIf.TabIndex = 0;
            this.radioIf.TabStop = true;
            this.radioIf.Text = "If Statement";
            this.radioIf.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioForEach);
            this.groupBox1.Controls.Add(this.radioDo);
            this.groupBox1.Controls.Add(this.radioFor);
            this.groupBox1.Controls.Add(this.radioWhile);
            this.groupBox1.Controls.Add(this.radioSwitch);
            this.groupBox1.Controls.Add(this.radioIf);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(72, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 177);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statements";
            // 
            // listTimeTable
            // 
            this.listTimeTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listTimeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTimeTable.FormattingEnabled = true;
            this.listTimeTable.ItemHeight = 15;
            this.listTimeTable.Location = new System.Drawing.Point(480, 141);
            this.listTimeTable.Name = "listTimeTable";
            this.listTimeTable.Size = new System.Drawing.Size(120, 169);
            this.listTimeTable.TabIndex = 7;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(12, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(53, 18);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Home";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // DecisionAndIterationStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(649, 469);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.listTimeTable);
            this.Controls.Add(this.groupIf);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Name = "DecisionAndIterationStatement";
            this.Text = "DecisionAndIterationStatement";
            this.groupIf.ResumeLayout(false);
            this.groupIf.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupIf;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.RadioButton radioForEach;
        private System.Windows.Forms.RadioButton radioDo;
        private System.Windows.Forms.RadioButton radioFor;
        private System.Windows.Forms.RadioButton radioWhile;
        private System.Windows.Forms.RadioButton radioSwitch;
        private System.Windows.Forms.RadioButton radioIf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listTimeTable;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}