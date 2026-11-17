using System.Data;

namespace ComputerSales
{
    public class SalesDataSet : DataSet
    {
        public SalesDataTable Sales;

        public SalesDataSet()
        {
            this.DataSetName = "SalesDataSet";
            Sales = new SalesDataTable();
            this.Tables.Add(Sales);
        }

        public class SalesDataTable : DataTable
        {
            public SalesDataTable() : base("Sales")
            {
                DataColumn saleId = Columns.Add("sale_id", typeof(int));
                saleId.AutoIncrement = true;
                saleId.AutoIncrementSeed = -1;
                saleId.AutoIncrementStep = -1;
                Columns.Add("model", typeof(string));
                Columns.Add("buyer", typeof(string));
                Columns.Add("quant", typeof(int));
                Columns.Add("price", typeof(int));
                PrimaryKey = new DataColumn[] { saleId };
            }
        }
    }
}
