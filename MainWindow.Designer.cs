namespace DatabaseBloodBank
{
    partial class MainWindow
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
            this.PatientIDlabel = new System.Windows.Forms.Label();
            this.PatientNamelabel = new System.Windows.Forms.Label();
            this.phoneNumberlabel = new System.Windows.Forms.Label();
            this.PatientBGroup = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDtextBox1 = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.phonetextBox = new System.Windows.Forms.TextBox();
            this.BloodtextBox = new System.Windows.Forms.TextBox();
            this.Donorlabel = new System.Windows.Forms.Label();
            this.findDonorbutton = new System.Windows.Forms.Button();
            this.patientlabel22 = new System.Windows.Forms.Label();
            this.Donornamelabel = new System.Windows.Forms.Label();
            this.DonorPhonelabel = new System.Windows.Forms.Label();
            this.DonorBloodlabel2 = new System.Windows.Forms.Label();
            this.DonorCenterlabel2 = new System.Windows.Forms.Label();
            this.donorNametext = new System.Windows.Forms.Label();
            this.donorphonetext = new System.Windows.Forms.Label();
            this.donorbloodgrouptext = new System.Windows.Forms.Label();
            this.donorcenternametext = new System.Windows.Forms.Label();
            this.donorlistBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oldDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectDonorbutton1 = new System.Windows.Forms.Button();
            this.addanalysisbutton1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PatientIDlabel
            // 
            this.PatientIDlabel.AutoSize = true;
            this.PatientIDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PatientIDlabel.Location = new System.Drawing.Point(171, 92);
            this.PatientIDlabel.Name = "PatientIDlabel";
            this.PatientIDlabel.Size = new System.Drawing.Size(34, 25);
            this.PatientIDlabel.TabIndex = 0;
            this.PatientIDlabel.Text = "ID";
            // 
            // PatientNamelabel
            // 
            this.PatientNamelabel.AutoSize = true;
            this.PatientNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PatientNamelabel.Location = new System.Drawing.Point(133, 133);
            this.PatientNamelabel.Name = "PatientNamelabel";
            this.PatientNamelabel.Size = new System.Drawing.Size(72, 25);
            this.PatientNamelabel.TabIndex = 1;
            this.PatientNamelabel.Text = "Name";
            // 
            // phoneNumberlabel
            // 
            this.phoneNumberlabel.AutoSize = true;
            this.phoneNumberlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phoneNumberlabel.Location = new System.Drawing.Point(38, 173);
            this.phoneNumberlabel.Name = "phoneNumberlabel";
            this.phoneNumberlabel.Size = new System.Drawing.Size(167, 25);
            this.phoneNumberlabel.TabIndex = 2;
            this.phoneNumberlabel.Text = "Phone Number";
            // 
            // PatientBGroup
            // 
            this.PatientBGroup.AutoSize = true;
            this.PatientBGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PatientBGroup.Location = new System.Drawing.Point(62, 212);
            this.PatientBGroup.Name = "PatientBGroup";
            this.PatientBGroup.Size = new System.Drawing.Size(143, 25);
            this.PatientBGroup.TabIndex = 3;
            this.PatientBGroup.Text = "Blood Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Find Blood for Patient";
            // 
            // IDtextBox1
            // 
            this.IDtextBox1.Location = new System.Drawing.Point(212, 96);
            this.IDtextBox1.Name = "IDtextBox1";
            this.IDtextBox1.Size = new System.Drawing.Size(100, 20);
            this.IDtextBox1.TabIndex = 5;
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(212, 139);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(100, 20);
            this.nametextBox.TabIndex = 6;
            // 
            // phonetextBox
            // 
            this.phonetextBox.Location = new System.Drawing.Point(212, 173);
            this.phonetextBox.Name = "phonetextBox";
            this.phonetextBox.Size = new System.Drawing.Size(100, 20);
            this.phonetextBox.TabIndex = 7;
            // 
            // BloodtextBox
            // 
            this.BloodtextBox.Location = new System.Drawing.Point(212, 217);
            this.BloodtextBox.Name = "BloodtextBox";
            this.BloodtextBox.Size = new System.Drawing.Size(100, 20);
            this.BloodtextBox.TabIndex = 8;
            // 
            // Donorlabel
            // 
            this.Donorlabel.AutoSize = true;
            this.Donorlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Donorlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Donorlabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Donorlabel.Location = new System.Drawing.Point(413, 58);
            this.Donorlabel.Name = "Donorlabel";
            this.Donorlabel.Size = new System.Drawing.Size(69, 26);
            this.Donorlabel.TabIndex = 10;
            this.Donorlabel.Text = "Donor";
            // 
            // findDonorbutton
            // 
            this.findDonorbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.findDonorbutton.Location = new System.Drawing.Point(194, 253);
            this.findDonorbutton.Name = "findDonorbutton";
            this.findDonorbutton.Size = new System.Drawing.Size(118, 36);
            this.findDonorbutton.TabIndex = 11;
            this.findDonorbutton.Text = "Find Donor";
            this.findDonorbutton.UseVisualStyleBackColor = true;
            this.findDonorbutton.Click += new System.EventHandler(this.findDonorbutton_Click);
            // 
            // patientlabel22
            // 
            this.patientlabel22.AutoSize = true;
            this.patientlabel22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patientlabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.patientlabel22.Location = new System.Drawing.Point(212, 58);
            this.patientlabel22.Name = "patientlabel22";
            this.patientlabel22.Size = new System.Drawing.Size(75, 26);
            this.patientlabel22.TabIndex = 12;
            this.patientlabel22.Text = "Patient";
            // 
            // Donornamelabel
            // 
            this.Donornamelabel.AutoSize = true;
            this.Donornamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Donornamelabel.Location = new System.Drawing.Point(522, 106);
            this.Donornamelabel.Name = "Donornamelabel";
            this.Donornamelabel.Size = new System.Drawing.Size(82, 20);
            this.Donornamelabel.TabIndex = 13;
            this.Donornamelabel.Text = "Donor ID";
            // 
            // DonorPhonelabel
            // 
            this.DonorPhonelabel.AutoSize = true;
            this.DonorPhonelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DonorPhonelabel.Location = new System.Drawing.Point(522, 138);
            this.DonorPhonelabel.Name = "DonorPhonelabel";
            this.DonorPhonelabel.Size = new System.Drawing.Size(127, 20);
            this.DonorPhonelabel.TabIndex = 14;
            this.DonorPhonelabel.Text = "Phone Number";
            // 
            // DonorBloodlabel2
            // 
            this.DonorBloodlabel2.AutoSize = true;
            this.DonorBloodlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DonorBloodlabel2.Location = new System.Drawing.Point(522, 171);
            this.DonorBloodlabel2.Name = "DonorBloodlabel2";
            this.DonorBloodlabel2.Size = new System.Drawing.Size(98, 20);
            this.DonorBloodlabel2.TabIndex = 15;
            this.DonorBloodlabel2.Text = "Blood Type";
            // 
            // DonorCenterlabel2
            // 
            this.DonorCenterlabel2.AutoSize = true;
            this.DonorCenterlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DonorCenterlabel2.Location = new System.Drawing.Point(598, 200);
            this.DonorCenterlabel2.Name = "DonorCenterlabel2";
            this.DonorCenterlabel2.Size = new System.Drawing.Size(114, 20);
            this.DonorCenterlabel2.TabIndex = 16;
            this.DonorCenterlabel2.Text = "Center Name";
            // 
            // donorNametext
            // 
            this.donorNametext.AutoSize = true;
            this.donorNametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.donorNametext.Location = new System.Drawing.Point(664, 106);
            this.donorNametext.Name = "donorNametext";
            this.donorNametext.Size = new System.Drawing.Size(0, 13);
            this.donorNametext.TabIndex = 17;
            // 
            // donorphonetext
            // 
            this.donorphonetext.AutoSize = true;
            this.donorphonetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.donorphonetext.Location = new System.Drawing.Point(664, 142);
            this.donorphonetext.Name = "donorphonetext";
            this.donorphonetext.Size = new System.Drawing.Size(0, 13);
            this.donorphonetext.TabIndex = 18;
            // 
            // donorbloodgrouptext
            // 
            this.donorbloodgrouptext.AutoSize = true;
            this.donorbloodgrouptext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.donorbloodgrouptext.Location = new System.Drawing.Point(664, 173);
            this.donorbloodgrouptext.Name = "donorbloodgrouptext";
            this.donorbloodgrouptext.Size = new System.Drawing.Size(0, 13);
            this.donorbloodgrouptext.TabIndex = 19;
            // 
            // donorcenternametext
            // 
            this.donorcenternametext.AutoSize = true;
            this.donorcenternametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.donorcenternametext.Location = new System.Drawing.Point(523, 226);
            this.donorcenternametext.Name = "donorcenternametext";
            this.donorcenternametext.Size = new System.Drawing.Size(0, 13);
            this.donorcenternametext.TabIndex = 20;
            // 
            // donorlistBox1
            // 
            this.donorlistBox1.FormattingEnabled = true;
            this.donorlistBox1.Location = new System.Drawing.Point(391, 92);
            this.donorlistBox1.Name = "donorlistBox1";
            this.donorlistBox1.Size = new System.Drawing.Size(112, 147);
            this.donorlistBox1.TabIndex = 21;
            this.donorlistBox1.SelectedIndexChanged += new System.EventHandler(this.donorlistBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.moveToolStripMenuItem,
            this.oldDonorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donorToolStripMenuItem,
            this.employeeToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // donorToolStripMenuItem
            // 
            this.donorToolStripMenuItem.Name = "donorToolStripMenuItem";
            this.donorToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.donorToolStripMenuItem.Text = "Donor";
            this.donorToolStripMenuItem.Click += new System.EventHandler(this.donorToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donorToolStripMenuItem1});
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.moveToolStripMenuItem.Text = "Move";
            // 
            // donorToolStripMenuItem1
            // 
            this.donorToolStripMenuItem1.Name = "donorToolStripMenuItem1";
            this.donorToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.donorToolStripMenuItem1.Text = "Donor";
            this.donorToolStripMenuItem1.Click += new System.EventHandler(this.donorToolStripMenuItem1_Click);
            // 
            // oldDonorToolStripMenuItem
            // 
            this.oldDonorToolStripMenuItem.Name = "oldDonorToolStripMenuItem";
            this.oldDonorToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.oldDonorToolStripMenuItem.Text = "Old Donor";
            this.oldDonorToolStripMenuItem.Click += new System.EventHandler(this.oldDonorToolStripMenuItem_Click);
            // 
            // selectDonorbutton1
            // 
            this.selectDonorbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectDonorbutton1.Location = new System.Drawing.Point(391, 253);
            this.selectDonorbutton1.Name = "selectDonorbutton1";
            this.selectDonorbutton1.Size = new System.Drawing.Size(132, 36);
            this.selectDonorbutton1.TabIndex = 23;
            this.selectDonorbutton1.Text = "Select Donor";
            this.selectDonorbutton1.UseVisualStyleBackColor = true;
            this.selectDonorbutton1.Click += new System.EventHandler(this.selectDonorbutton1_Click);
            // 
            // addanalysisbutton1
            // 
            this.addanalysisbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addanalysisbutton1.Location = new System.Drawing.Point(391, 296);
            this.addanalysisbutton1.Name = "addanalysisbutton1";
            this.addanalysisbutton1.Size = new System.Drawing.Size(132, 35);
            this.addanalysisbutton1.TabIndex = 24;
            this.addanalysisbutton1.Text = "Analysis";
            this.addanalysisbutton1.UseVisualStyleBackColor = true;
            this.addanalysisbutton1.Click += new System.EventHandler(this.addanalysisbutton1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 354);
            this.Controls.Add(this.addanalysisbutton1);
            this.Controls.Add(this.selectDonorbutton1);
            this.Controls.Add(this.donorlistBox1);
            this.Controls.Add(this.donorcenternametext);
            this.Controls.Add(this.donorbloodgrouptext);
            this.Controls.Add(this.donorphonetext);
            this.Controls.Add(this.donorNametext);
            this.Controls.Add(this.DonorCenterlabel2);
            this.Controls.Add(this.DonorBloodlabel2);
            this.Controls.Add(this.DonorPhonelabel);
            this.Controls.Add(this.Donornamelabel);
            this.Controls.Add(this.patientlabel22);
            this.Controls.Add(this.findDonorbutton);
            this.Controls.Add(this.Donorlabel);
            this.Controls.Add(this.BloodtextBox);
            this.Controls.Add(this.phonetextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.IDtextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatientBGroup);
            this.Controls.Add(this.phoneNumberlabel);
            this.Controls.Add(this.PatientNamelabel);
            this.Controls.Add(this.PatientIDlabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PatientIDlabel;
        private System.Windows.Forms.Label PatientNamelabel;
        private System.Windows.Forms.Label phoneNumberlabel;
        private System.Windows.Forms.Label PatientBGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDtextBox1;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox phonetextBox;
        private System.Windows.Forms.TextBox BloodtextBox;
        private System.Windows.Forms.Label Donorlabel;
        private System.Windows.Forms.Button findDonorbutton;
        private System.Windows.Forms.Label patientlabel22;
        private System.Windows.Forms.Label Donornamelabel;
        private System.Windows.Forms.Label DonorPhonelabel;
        private System.Windows.Forms.Label DonorBloodlabel2;
        private System.Windows.Forms.Label DonorCenterlabel2;
        private System.Windows.Forms.Label donorNametext;
        private System.Windows.Forms.Label donorphonetext;
        private System.Windows.Forms.Label donorbloodgrouptext;
        private System.Windows.Forms.Label donorcenternametext;
        private System.Windows.Forms.ListBox donorlistBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.Button selectDonorbutton1;
        private System.Windows.Forms.Button addanalysisbutton1;
        private System.Windows.Forms.ToolStripMenuItem oldDonorToolStripMenuItem;
    }
}