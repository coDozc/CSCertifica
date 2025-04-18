using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using PieChart = LiveCharts.WinForms.PieChart;

namespace FinancialCrm
{
    public partial class FrmDashboard: Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        int count = 0;
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            lblTotalBalance.Text = totalBalance.ToString() + " ₺";

            var LastBankProcessAmount = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.Amount).FirstOrDefault();
            lblLastBankProcessAmount.Text = LastBankProcessAmount.ToString() + " ₺";

            //this.Controls.Clear();

            //Chart 1
            var bankData= db.Banks.Select(x=> new
            {
                x.BankTitle,
                x.BankBalance
            }).ToList();

            var bankPieChart = new PieChart
            {
                Dock = DockStyle.Fill,
                InnerRadius = 30,
                LegendLocation = LegendLocation.Right,
                Width = this.Width /2
            };
            var bankSeries = new SeriesCollection();
            foreach (var item in bankData)
            {
                bankSeries.Add(new PieSeries
                {
                    Title = item.BankTitle,
                    Values = new ChartValues<decimal> {item.BankBalance ?? 0},
                    DataLabels = true,
                });
            }
            bankPieChart.Series = bankSeries;
           

            var billData = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            }).ToList();

            var billBarChart = new LiveCharts.WinForms.CartesianChart
            {
                Dock = DockStyle.Fill,
            };
            var values = new ChartValues<decimal>();
            var labels = new List<string>();

            foreach (var item in billData)
            {
                values.Add(item.BillAmount ?? 0);
                labels.Add(item.BillTitle);
            }
            billBarChart.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Faturalar",
                    Values = values,
                }
            };

            billBarChart.AxisX.Add(new Axis
            {
                Title = "Fatura Türleri",
                Labels = labels,
            });
            billBarChart.AxisY.Add(new Axis
            {
                Title = "Tutar",
                LabelFormatter = value => value.ToString("C"),
            });

            panel8.Controls.Clear();
            panel8.Controls.Add(bankPieChart);

            panel9.Controls.Clear();
            panel9.Controls.Add(billBarChart);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if(count % 4 == 1)
            {
                var elektrikFaturasi = db.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Elektrik Faturası";
                lblBillAmount.Text = elektrikFaturasi.ToString() + " ₺";
            }
            if (count % 4 == 2)
            {
                var elektrikFaturasi = db.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Elektrik Faturası";
                lblBillAmount.Text = elektrikFaturasi.ToString() + " ₺";
            }
            if (count % 4 == 3)
            {
                var elektrikFaturasi = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Elektrik Faturası";
                lblBillAmount.Text = elektrikFaturasi.ToString() + " ₺";
            }
            if (count % 4 == 0)
            {
                var elektrikFaturasi = db.Bills.Where(x => x.BillTitle == "İnternet Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "İnternet Faturası";
                lblBillAmount.Text = elektrikFaturasi.ToString() + " ₺";
            }
        }

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

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnSpendingForm_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
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
