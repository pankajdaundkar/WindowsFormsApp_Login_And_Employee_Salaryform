namespace WindowsFormsApp_login_form
{
    partial class Employee_Details
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDA = new System.Windows.Forms.TextBox();
            this.txtTA = new System.Windows.Forms.TextBox();
            this.chkDA = new System.Windows.Forms.CheckBox();
            this.chkTA = new System.Windows.Forms.CheckBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.txtNetSal = new System.Windows.Forms.TextBox();
            this.txtAloowance = new System.Windows.Forms.TextBox();
            this.txtGrossSal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHRA = new System.Windows.Forms.TextBox();
            this.txtEPF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkEPF = new System.Windows.Forms.CheckBox();
            this.chkHRA = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.combDept = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Salary Calculation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(185, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(313, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(185, 107);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(313, 20);
            this.txtSalary.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDA);
            this.groupBox1.Controls.Add(this.txtTA);
            this.groupBox1.Controls.Add(this.chkDA);
            this.groupBox1.Controls.Add(this.chkTA);
            this.groupBox1.Controls.Add(this.Calculate);
            this.groupBox1.Controls.Add(this.txtNetSal);
            this.groupBox1.Controls.Add(this.txtAloowance);
            this.groupBox1.Controls.Add(this.txtGrossSal);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtHRA);
            this.groupBox1.Controls.Add(this.txtEPF);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkEPF);
            this.groupBox1.Controls.Add(this.chkHRA);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(67, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 316);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculation";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 38);
            this.button1.TabIndex = 20;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(419, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "TA Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(419, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "DA Amount";
            // 
            // txtDA
            // 
            this.txtDA.Location = new System.Drawing.Point(556, 94);
            this.txtDA.Name = "txtDA";
            this.txtDA.Size = new System.Drawing.Size(132, 23);
            this.txtDA.TabIndex = 17;
            // 
            // txtTA
            // 
            this.txtTA.Location = new System.Drawing.Point(556, 43);
            this.txtTA.Name = "txtTA";
            this.txtTA.Size = new System.Drawing.Size(132, 23);
            this.txtTA.TabIndex = 16;
            // 
            // chkDA
            // 
            this.chkDA.AutoSize = true;
            this.chkDA.Location = new System.Drawing.Point(335, 91);
            this.chkDA.Name = "chkDA";
            this.chkDA.Size = new System.Drawing.Size(48, 21);
            this.chkDA.TabIndex = 15;
            this.chkDA.Text = "DA";
            this.chkDA.UseVisualStyleBackColor = true;
            // 
            // chkTA
            // 
            this.chkTA.AutoSize = true;
            this.chkTA.Location = new System.Drawing.Point(335, 43);
            this.chkTA.Name = "chkTA";
            this.chkTA.Size = new System.Drawing.Size(47, 21);
            this.chkTA.TabIndex = 14;
            this.chkTA.Text = "TA";
            this.chkTA.UseVisualStyleBackColor = true;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(440, 234);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(127, 38);
            this.Calculate.TabIndex = 13;
            this.Calculate.Text = "CALCULATE";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // txtNetSal
            // 
            this.txtNetSal.Location = new System.Drawing.Point(472, 186);
            this.txtNetSal.Name = "txtNetSal";
            this.txtNetSal.Size = new System.Drawing.Size(216, 23);
            this.txtNetSal.TabIndex = 12;
            // 
            // txtAloowance
            // 
            this.txtAloowance.Location = new System.Drawing.Point(472, 152);
            this.txtAloowance.Name = "txtAloowance";
            this.txtAloowance.Size = new System.Drawing.Size(216, 23);
            this.txtAloowance.TabIndex = 11;
            // 
            // txtGrossSal
            // 
            this.txtGrossSal.Location = new System.Drawing.Point(136, 155);
            this.txtGrossSal.Name = "txtGrossSal";
            this.txtGrossSal.Size = new System.Drawing.Size(216, 23);
            this.txtGrossSal.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = " Gross Salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(368, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Allowance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(368, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Net Salary";
            // 
            // txtHRA
            // 
            this.txtHRA.Location = new System.Drawing.Point(186, 43);
            this.txtHRA.Name = "txtHRA";
            this.txtHRA.Size = new System.Drawing.Size(123, 23);
            this.txtHRA.TabIndex = 6;
            // 
            // txtEPF
            // 
            this.txtEPF.Location = new System.Drawing.Point(186, 91);
            this.txtEPF.Name = "txtEPF";
            this.txtEPF.Size = new System.Drawing.Size(123, 23);
            this.txtEPF.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "HRA Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "EPF Amount";
            // 
            // chkEPF
            // 
            this.chkEPF.AutoSize = true;
            this.chkEPF.Location = new System.Drawing.Point(6, 91);
            this.chkEPF.Name = "chkEPF";
            this.chkEPF.Size = new System.Drawing.Size(56, 21);
            this.chkEPF.TabIndex = 1;
            this.chkEPF.Text = "EPF";
            this.chkEPF.UseVisualStyleBackColor = true;
            // 
            // chkHRA
            // 
            this.chkHRA.AutoSize = true;
            this.chkHRA.Location = new System.Drawing.Point(6, 43);
            this.chkHRA.Name = "chkHRA";
            this.chkHRA.Size = new System.Drawing.Size(59, 21);
            this.chkHRA.TabIndex = 0;
            this.chkHRA.Text = "HRA";
            this.chkHRA.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(64, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Department";
            // 
            // combDept
            // 
            this.combDept.FormattingEnabled = true;
            this.combDept.Location = new System.Drawing.Point(185, 148);
            this.combDept.Name = "combDept";
            this.combDept.Size = new System.Drawing.Size(313, 21);
            this.combDept.TabIndex = 7;
            this.combDept.SelectedIndexChanged += new System.EventHandler(this.combDept_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(186, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 21;
            this.button2.Text = "Display";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Employee_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(918, 572);
            this.Controls.Add(this.combDept);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Employee_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Details";
            this.Load += new System.EventHandler(this.Employee_Details_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkEPF;
        private System.Windows.Forms.CheckBox chkHRA;
        private System.Windows.Forms.TextBox txtEPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHRA;
        private System.Windows.Forms.TextBox txtNetSal;
        private System.Windows.Forms.TextBox txtAloowance;
        private System.Windows.Forms.TextBox txtGrossSal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox txtDA;
        private System.Windows.Forms.TextBox txtTA;
        private System.Windows.Forms.CheckBox chkDA;
        private System.Windows.Forms.CheckBox chkTA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox combDept;
        private System.Windows.Forms.Button button2;
    }
}