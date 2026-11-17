namespace ComputerSales
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.components.Add(this.oleDbConnection1);
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.SalesAdapter = new System.Data.OleDb.OleDbDataAdapter();
            this.salesDataSet1 = new ComputerSales.SalesDataSet();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saleIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=sales.mdb";
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT sale_id, model, buyer, quant, price FROM Sales";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO Sales (model, buyer, quant, price) VALUES (?, ?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("model", System.Data.OleDb.OleDbType.VarWChar, 80, "model"),
            new System.Data.OleDb.OleDbParameter("buyer", System.Data.OleDb.OleDbType.VarWChar, 80, "buyer"),
            new System.Data.OleDb.OleDbParameter("quant", System.Data.OleDb.OleDbType.Integer, 0, "quant"),
            new System.Data.OleDb.OleDbParameter("price", System.Data.OleDb.OleDbType.Integer, 0, "price")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = "UPDATE Sales SET model = ?, buyer = ?, quant = ?, price = ? WHERE (sale_id = ?)";
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("model", System.Data.OleDb.OleDbType.VarWChar, 80, "model"),
            new System.Data.OleDb.OleDbParameter("buyer", System.Data.OleDb.OleDbType.VarWChar, 80, "buyer"),
            new System.Data.OleDb.OleDbParameter("quant", System.Data.OleDb.OleDbType.Integer, 0, "quant"),
            new System.Data.OleDb.OleDbParameter("price", System.Data.OleDb.OleDbType.Integer, 0, "price"),
            new System.Data.OleDb.OleDbParameter("Original_sale_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sale_id", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM Sales WHERE (sale_id = ?)";
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_sale_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sale_id", System.Data.DataRowVersion.Original, null)});
            // 
            // SalesAdapter
            // 
            this.SalesAdapter.DeleteCommand = this.oleDbDeleteCommand1;
            this.SalesAdapter.InsertCommand = this.oleDbInsertCommand1;
            this.SalesAdapter.SelectCommand = this.oleDbSelectCommand1;
            this.SalesAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Sales", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("sale_id", "sale_id"),
                        new System.Data.Common.DataColumnMapping("model", "model"),
                        new System.Data.Common.DataColumnMapping("buyer", "buyer"),
                        new System.Data.Common.DataColumnMapping("quant", "quant"),
                        new System.Data.Common.DataColumnMapping("price", "price")})});
            this.SalesAdapter.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // salesDataSet1
            // 
            this.salesDataSet1.DataSetName = "SalesDataSet";
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.salesDataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = true;
            this.dataGridView1.AllowUserToDeleteRows = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleIdColumn,
            this.modelColumn,
            this.buyerColumn,
            this.quantColumn,
            this.priceColumn});
            this.dataGridView1.DataSource = this.salesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(860, 390);
            this.dataGridView1.TabIndex = 0;
            // 
            // saleIdColumn
            // 
            this.saleIdColumn.DataPropertyName = "sale_id";
            this.saleIdColumn.HeaderText = "№";
            this.saleIdColumn.Name = "saleIdColumn";
            this.saleIdColumn.ReadOnly = true;
            this.saleIdColumn.FillWeight = 40F;
            // 
            // modelColumn
            // 
            this.modelColumn.DataPropertyName = "model";
            this.modelColumn.HeaderText = "Модель";
            this.modelColumn.Name = "modelColumn";
            this.modelColumn.FillWeight = 160F;
            // 
            // buyerColumn
            // 
            this.buyerColumn.DataPropertyName = "buyer";
            this.buyerColumn.HeaderText = "Покупатель";
            this.buyerColumn.Name = "buyerColumn";
            this.buyerColumn.FillWeight = 140F;
            // 
            // quantColumn
            // 
            this.quantColumn.DataPropertyName = "quant";
            this.quantColumn.HeaderText = "Количество";
            this.quantColumn.Name = "quantColumn";
            // 
            // priceColumn
            // 
            this.priceColumn.DataPropertyName = "price";
            this.priceColumn.HeaderText = "Цена, руб.";
            this.priceColumn.Name = "priceColumn";
            // 
            // btn_save
            // 
            this.btn_save.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
            this.btn_save.Location = new System.Drawing.Point(12, 440);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(160, 32);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
            this.btn_cancel.Location = new System.Drawing.Point(184, 440);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(160, 32);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Отменить";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(12, 12);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(520, 15);
            this.lblHint.TabIndex = 3;
            this.lblHint.Text = "Правьте таблицу прямо в сетке. Новая строка добавляется снизу, удаление — клавишей Delete.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 486);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(720, 420);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет продаж компьютеров";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter SalesAdapter;
        private SalesDataSet salesDataSet1;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lblHint;
    }
}
