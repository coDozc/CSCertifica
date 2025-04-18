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
    public partial class FrmSpendings: Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmSpendings_Load(object sender, EventArgs e)
        {

            List<Spending> spendings = db.Spendings.OrderByDescending(x => x.SpendingDate).ToList();
            
           
            foreach(var spend in spendings)
            {
                Panel panel = new Panel();
                panel.Width = flpSpendings.Width - 25;
                panel.Height = 80;
                panel.BorderStyle = BorderStyle.FixedSingle;

                Label lblDate = new Label();
                lblDate.Text = spend.SpendingDate.HasValue
                    ? spend.SpendingDate.Value.ToString("dd/MM/yyyy")
                    : "N/A";
                lblDate.Location = new Point(10, 10);
                lblDate.AutoSize = true;

                Label lblDescription = new Label();
                lblDescription.Text = spend.SpendingTitle;
                lblDescription.Location = new Point(10, 30);
                lblDescription.AutoSize = true;

                Label lblAmount = new Label();
                lblAmount.Text = spend.SpendingAmount.ToString() + " ₺";
                lblAmount.Location = new Point(10, 50);
                lblAmount.AutoSize = true;

                panel.Controls.Add(lblDate);
                panel.Controls.Add(lblDescription);
                panel.Controls.Add(lblAmount);

                flpSpendings.Controls.Add(panel);
            }
        }

        //private void btnRefresh_Click(object sender, EventArgs e)
        //{
        //    refreshList();
        //}
        //private void refreshList()
        //{
        //    var spendings = db.Spendings.OrderByDescending(x => x.SpendingDate).ToList();

        //    flpSpendings.Controls.Clear();

        //    foreach (var spend in spendings)
        //    {
        //        var control = new UserControl();
        //        control.Width = flpSpendings.Width - 25;
                
        //        flpSpendings.Controls.Add(control);

        //    }
        //}

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnBankProcess_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frm = new FrmBankProcesses();
            frm.Show();
            this.Hide();
        }
    }
}
