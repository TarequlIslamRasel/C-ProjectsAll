namespace MyFirstProject1238335
{
    partial class ArrayAndIterationUsingArray
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxIntermediate = new System.Windows.Forms.ListBox();
            this.btnIterate = new System.Windows.Forms.Button();
            this.listBoxAfterIteration = new System.Windows.Forms.ListBox();
            this.listBoxWeekDays = new System.Windows.Forms.ListBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Array And Iteration Using Array :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(446, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Items after iteration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Selected Item from primary array";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Primary array";
            // 
            // listBoxIntermediate
            // 
            this.listBoxIntermediate.FormattingEnabled = true;
            this.listBoxIntermediate.Location = new System.Drawing.Point(273, 279);
            this.listBoxIntermediate.Name = "listBoxIntermediate";
            this.listBoxIntermediate.Size = new System.Drawing.Size(120, 95);
            this.listBoxIntermediate.TabIndex = 11;
            this.listBoxIntermediate.SelectedIndexChanged += new System.EventHandler(this.listBoxIntermediate_SelectedIndexChanged);
            // 
            // btnIterate
            // 
            this.btnIterate.Location = new System.Drawing.Point(297, 375);
            this.btnIterate.Name = "btnIterate";
            this.btnIterate.Size = new System.Drawing.Size(75, 23);
            this.btnIterate.TabIndex = 10;
            this.btnIterate.Text = "Iterate";
            this.btnIterate.UseVisualStyleBackColor = true;
            this.btnIterate.Click += new System.EventHandler(this.btnIterate_Click);
            // 
            // listBoxAfterIteration
            // 
            this.listBoxAfterIteration.FormattingEnabled = true;
            this.listBoxAfterIteration.Location = new System.Drawing.Point(446, 132);
            this.listBoxAfterIteration.Name = "listBoxAfterIteration";
            this.listBoxAfterIteration.Size = new System.Drawing.Size(120, 108);
            this.listBoxAfterIteration.TabIndex = 9;
            // 
            // listBoxWeekDays
            // 
            this.listBoxWeekDays.FormattingEnabled = true;
            this.listBoxWeekDays.Location = new System.Drawing.Point(125, 132);
            this.listBoxWeekDays.Name = "listBoxWeekDays";
            this.listBoxWeekDays.Size = new System.Drawing.Size(120, 108);
            this.listBoxWeekDays.TabIndex = 8;
            this.listBoxWeekDays.SelectedIndexChanged += new System.EventHandler(this.listBoxIntermediate_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(12, 25);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 18);
            this.linkLabel1.TabIndex = 16;
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
            this.linkLabel2.Location = new System.Drawing.Point(19, 431);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(46, 18);
            this.linkLabel2.TabIndex = 17;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Back";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // ArrayAndIterationUsingArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(649, 469);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxIntermediate);
            this.Controls.Add(this.btnIterate);
            this.Controls.Add(this.listBoxAfterIteration);
            this.Controls.Add(this.listBoxWeekDays);
            this.Name = "ArrayAndIterationUsingArray";
            this.Text = "ArrayAndIterationUsingArray";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxIntermediate;
        private System.Windows.Forms.Button btnIterate;
        private System.Windows.Forms.ListBox listBoxAfterIteration;
        private System.Windows.Forms.ListBox listBoxWeekDays;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}