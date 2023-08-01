using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_login_form
{
    public partial class Employee_Details : Form
    {
        public Employee_Details()
        {
            InitializeComponent();
        }

        double salary, hra, ta, epf, da, hra_amount, ta_amount, epf_amount, da_amount, gross_sal, allowance, net_sal;

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{ txtName.Text}\n {txtSalary.Text}\n{combDept.Text}\n{txtGrossSal.Text}\n{txtNetSal.Text}");
        }

        private void combDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Employee_Details_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>() { "HR", "Admin", "Devlopment", "Testing", "Salse", "Marketing" };
            combDept.DataSource = list;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHRA.Clear();
            txtEPF.Clear();
            txtTA.Clear();
            txtDA.Clear();
            txtGrossSal.Clear();
            txtName.Clear();
            txtSalary.Clear();
            txtNetSal.Clear();
            txtAloowance.Clear();

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            salary = double.Parse(txtSalary.Text);

            if (chkHRA.Checked==true)
            {
                hra_amount = salary * .40;
            }

            if (chkTA.Checked == true)
            {
                ta_amount = salary * .20;
            }

            if (chkEPF.Checked == true)
            {
                epf_amount = salary * .12 ;
            }

            if (chkDA.Checked == true)
            {
                da_amount = salary * .10;
            }
            txtHRA.Text = hra_amount.ToString();
            txtTA.Text = ta_amount.ToString();
            txtEPF.Text = epf_amount.ToString();
            txtDA.Text = da_amount.ToString();

            gross_sal = (salary + hra_amount + ta_amount + da_amount) - epf_amount;

            txtGrossSal.Text = gross_sal.ToString();

            if(salary > 30000)
            {
                allowance = 2000;
            }
            else
            {
                allowance = 0;
            }

            txtAloowance.Text = allowance.ToString();

            net_sal = gross_sal + allowance;

            txtNetSal.Text = net_sal.ToString();








        }
    }
}
