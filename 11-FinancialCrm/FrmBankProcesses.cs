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
    public partial class FrmBankProcesses : Form
    {
        public FrmBankProcesses()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBankProcesses_Load(object sender, EventArgs e)
        {
            List<BankProcess> bankProcesses = db.BankProcesses.OrderByDescending(x => x.BankProcessId).ToList();

            foreach (var process in bankProcesses)
            {
                Panel panel = new Panel();
                panel.Width = flp.Width - 25;
                panel.Height = 80;
                panel.BorderStyle = BorderStyle.FixedSingle;

                Label lblDate = new Label();
                lblDate.Text = process.ProcessDate.HasValue
                    ? process.ProcessDate.Value.ToString("dd/MM/yyyy")
                    : "N/A";
                lblDate.Location = new Point(10, 10);
                lblDate.AutoSize = true;

                Label lblDescription = new Label();
                lblDescription.Text = process.Description;
                lblDescription.Location = new Point(10, 30);
                lblDescription.AutoSize = true;

                Label lblProcessType = new Label();
                lblProcessType.Text = process.ProcessType;
                lblProcessType.Location = new Point(10, 40);
                lblProcessType.AutoSize = true;

                Label lblAmount = new Label();
                lblAmount.Text = process.Amount.ToString() + " ₺";
                lblAmount.Location = new Point(10, 50);
                lblAmount.AutoSize = true;

                panel.Controls.Add(lblDate);
                panel.Controls.Add(lblDescription);
                panel.Controls.Add(lblAmount);

                flp.Controls.Add(panel);
            }
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

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
            this.Hide();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
