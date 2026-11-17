using System;
using System.Windows.Forms;

namespace ComputerSales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SalesAdapter.Fill(salesDataSet1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Не удалось открыть базу");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                salesBindingSource.EndEdit();
                SalesAdapter.Update(salesDataSet1, "Sales");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Не удалось сохранить");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            salesBindingSource.CancelEdit();
            salesDataSet1.Sales.RejectChanges();
        }
    }
}
