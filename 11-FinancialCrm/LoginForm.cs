using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class LoginForm: Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text.Trim();
            string password = txtPassword.Text;


            var user = db.Users.FirstOrDefault(x => x.Username == userName);

            if (user != null && BCrypt.Net.BCrypt.Verify(password, user.Password))
            {
                MessageBox.Show("Giris basarili!");
                FrmDashboard frm = new FrmDashboard();
                frm.Show();
                this.Hide();
            }
            else
            {
                lblLoginStatus.Text = "Kullanici adi veya sifre hatali!";
            }
        }
    }
}
