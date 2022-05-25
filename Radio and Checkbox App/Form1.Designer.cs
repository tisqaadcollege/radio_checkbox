namespace Radio_and_Checkbox_App
{
    partial class frmDemo
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
            this.chkShoworHide = new System.Windows.Forms.CheckBox();
            this.btnShowOrHide = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.btnAddCountry = new System.Windows.Forms.Button();
            this.lstCountry = new System.Windows.Forms.ListBox();
            this.btnDelCountry = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbRed = new System.Windows.Forms.RadioButton();
            this.rdbGreen = new System.Windows.Forms.RadioButton();
            this.rdbBlue = new System.Windows.Forms.RadioButton();
            this.rdbYellow = new System.Windows.Forms.RadioButton();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoppy = new System.Windows.Forms.TextBox();
            this.btnAddHoppy = new System.Windows.Forms.Button();
            this.cmbHoppy = new System.Windows.Forms.ComboBox();
            this.btnDelHoppy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkShoworHide
            // 
            this.chkShoworHide.AutoSize = true;
            this.chkShoworHide.Location = new System.Drawing.Point(13, 30);
            this.chkShoworHide.Name = "chkShoworHide";
            this.chkShoworHide.Size = new System.Drawing.Size(200, 17);
            this.chkShoworHide.TabIndex = 0;
            this.chkShoworHide.Text = "Show or Hide Listbox and Combobox";
            this.chkShoworHide.UseVisualStyleBackColor = true;
            // 
            // btnShowOrHide
            // 
            this.btnShowOrHide.Location = new System.Drawing.Point(239, 26);
            this.btnShowOrHide.Name = "btnShowOrHide";
            this.btnShowOrHide.Size = new System.Drawing.Size(87, 23);
            this.btnShowOrHide.TabIndex = 1;
            this.btnShowOrHide.Text = "Show or Hide";
            this.btnShowOrHide.UseVisualStyleBackColor = true;
            this.btnShowOrHide.Click += new System.EventHandler(this.btnShowOrHide_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstCountry);
            this.panel1.Controls.Add(this.txtCountry);
            this.panel1.Controls.Add(this.btnDelCountry);
            this.panel1.Controls.Add(this.btnAddCountry);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 454);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Country:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(120, 24);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(309, 20);
            this.txtCountry.TabIndex = 1;
            // 
            // btnAddCountry
            // 
            this.btnAddCountry.Location = new System.Drawing.Point(226, 63);
            this.btnAddCountry.Name = "btnAddCountry";
            this.btnAddCountry.Size = new System.Drawing.Size(75, 23);
            this.btnAddCountry.TabIndex = 1;
            this.btnAddCountry.Text = "Add";
            this.btnAddCountry.UseVisualStyleBackColor = true;
            this.btnAddCountry.Click += new System.EventHandler(this.btnAddCountry_Click);
            // 
            // lstCountry
            // 
            this.lstCountry.FormattingEnabled = true;
            this.lstCountry.Location = new System.Drawing.Point(120, 92);
            this.lstCountry.Name = "lstCountry";
            this.lstCountry.Size = new System.Drawing.Size(309, 329);
            this.lstCountry.TabIndex = 2;
            // 
            // btnDelCountry
            // 
            this.btnDelCountry.Location = new System.Drawing.Point(226, 427);
            this.btnDelCountry.Name = "btnDelCountry";
            this.btnDelCountry.Size = new System.Drawing.Size(75, 23);
            this.btnDelCountry.TabIndex = 1;
            this.btnDelCountry.Text = "Delete";
            this.btnDelCountry.UseVisualStyleBackColor = true;
            this.btnDelCountry.Click += new System.EventHandler(this.btnDelCountry_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbYellow);
            this.groupBox1.Controls.Add(this.rdbBlue);
            this.groupBox1.Controls.Add(this.rdbGreen);
            this.groupBox1.Controls.Add(this.rdbRed);
            this.groupBox1.Location = new System.Drawing.Point(578, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 211);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Background Color:";
            // 
            // rdbRed
            // 
            this.rdbRed.AutoSize = true;
            this.rdbRed.Location = new System.Drawing.Point(7, 20);
            this.rdbRed.Name = "rdbRed";
            this.rdbRed.Size = new System.Drawing.Size(45, 17);
            this.rdbRed.TabIndex = 0;
            this.rdbRed.TabStop = true;
            this.rdbRed.Text = "Red";
            this.rdbRed.UseVisualStyleBackColor = true;
            // 
            // rdbGreen
            // 
            this.rdbGreen.AutoSize = true;
            this.rdbGreen.Location = new System.Drawing.Point(7, 64);
            this.rdbGreen.Name = "rdbGreen";
            this.rdbGreen.Size = new System.Drawing.Size(54, 17);
            this.rdbGreen.TabIndex = 1;
            this.rdbGreen.TabStop = true;
            this.rdbGreen.Text = "Green";
            this.rdbGreen.UseVisualStyleBackColor = true;
            // 
            // rdbBlue
            // 
            this.rdbBlue.AutoSize = true;
            this.rdbBlue.Location = new System.Drawing.Point(0, 110);
            this.rdbBlue.Name = "rdbBlue";
            this.rdbBlue.Size = new System.Drawing.Size(46, 17);
            this.rdbBlue.TabIndex = 2;
            this.rdbBlue.TabStop = true;
            this.rdbBlue.Text = "Blue";
            this.rdbBlue.UseVisualStyleBackColor = true;
            // 
            // rdbYellow
            // 
            this.rdbYellow.AutoSize = true;
            this.rdbYellow.Location = new System.Drawing.Point(0, 161);
            this.rdbYellow.Name = "rdbYellow";
            this.rdbYellow.Size = new System.Drawing.Size(56, 17);
            this.rdbYellow.TabIndex = 3;
            this.rdbYellow.TabStop = true;
            this.rdbYellow.Text = "Yellow";
            this.rdbYellow.UseVisualStyleBackColor = true;
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(687, 247);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(75, 23);
            this.btnChangeColor.TabIndex = 1;
            this.btnChangeColor.Text = "Change";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbHoppy);
            this.panel2.Controls.Add(this.txtHoppy);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnDelHoppy);
            this.panel2.Controls.Add(this.btnAddHoppy);
            this.panel2.Location = new System.Drawing.Point(488, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 240);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Hoppies:";
            // 
            // txtHoppy
            // 
            this.txtHoppy.Location = new System.Drawing.Point(97, 37);
            this.txtHoppy.Name = "txtHoppy";
            this.txtHoppy.Size = new System.Drawing.Size(266, 20);
            this.txtHoppy.TabIndex = 1;
            // 
            // btnAddHoppy
            // 
            this.btnAddHoppy.Location = new System.Drawing.Point(199, 73);
            this.btnAddHoppy.Name = "btnAddHoppy";
            this.btnAddHoppy.Size = new System.Drawing.Size(75, 23);
            this.btnAddHoppy.TabIndex = 1;
            this.btnAddHoppy.Text = "Add";
            this.btnAddHoppy.UseVisualStyleBackColor = true;
            this.btnAddHoppy.Click += new System.EventHandler(this.btnAddHoppy_Click);
            // 
            // cmbHoppy
            // 
            this.cmbHoppy.FormattingEnabled = true;
            this.cmbHoppy.Location = new System.Drawing.Point(97, 143);
            this.cmbHoppy.Name = "cmbHoppy";
            this.cmbHoppy.Size = new System.Drawing.Size(266, 21);
            this.cmbHoppy.TabIndex = 2;
            // 
            // btnDelHoppy
            // 
            this.btnDelHoppy.Location = new System.Drawing.Point(199, 198);
            this.btnDelHoppy.Name = "btnDelHoppy";
            this.btnDelHoppy.Size = new System.Drawing.Size(75, 23);
            this.btnDelHoppy.TabIndex = 1;
            this.btnDelHoppy.Text = "Delete";
            this.btnDelHoppy.UseVisualStyleBackColor = true;
            this.btnDelHoppy.Click += new System.EventHandler(this.btnDelHoppy_Click);
            // 
            // frmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.btnShowOrHide);
            this.Controls.Add(this.chkShoworHide);
            this.Name = "frmDemo";
            this.Text = "Demo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkShoworHide;
        private System.Windows.Forms.Button btnShowOrHide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnDelCountry;
        private System.Windows.Forms.Button btnAddCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbYellow;
        private System.Windows.Forms.RadioButton rdbBlue;
        private System.Windows.Forms.RadioButton rdbGreen;
        private System.Windows.Forms.RadioButton rdbRed;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbHoppy;
        private System.Windows.Forms.TextBox txtHoppy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelHoppy;
        private System.Windows.Forms.Button btnAddHoppy;
    }
}

