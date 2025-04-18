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
using BCrypt.Net;
using System.Data.Entity.Validation;

namespace FinancialCrm
{
    public partial class RegisterForm: Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtPasswordConfirm.Text;

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Lutfen tum alanlari doldurun.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Parolalar uyusmuyor!");
                return;
            }

            if(db.Users.Any(x => x.Username == userName))
            {
                MessageBox.Show("Bu kullanici adi zaten alindi.");
                return;
            }
            var newUser = new User
            {
                Username = userName,
                Password = BCrypt.Net.BCrypt.HashPassword(password),
            };

            db.Users.Add(newUser);
            try 
            {
                db.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var validationError in ex.EntityValidationErrors)
                {
                    foreach (var error in validationError.ValidationErrors)
                    {
                        MessageBox.Show($"Property: {error.PropertyName}, Error: {error.ErrorMessage}");
                    }
                }
            }
            

            MessageBox.Show("Kullanici kaydi basarili!");
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.Show();
            this.Close();
        }
    }
}
