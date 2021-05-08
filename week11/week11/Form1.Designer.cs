
namespace week08
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_showDetails = new System.Windows.Forms.Button();
            this.tb_cusName = new System.Windows.Forms.TextBox();
            this.tb_goodName = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_deleteOrder = new System.Windows.Forms.Button();
            this.btn_changeOrder = new System.Windows.Forms.Button();
            this.btn_newOrder = new System.Windows.Forms.Button();
            this.btn_searchByCusName = new System.Windows.Forms.Button();
            this.btn_goodNameSearch = new System.Windows.Forms.Button();
            this.btn_idSearch = new System.Windows.Forms.Button();
            this.btn_showAll = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBinding = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_showDetails);
            this.panel1.Controls.Add(this.tb_cusName);
            this.panel1.Controls.Add(this.tb_goodName);
            this.panel1.Controls.Add(this.tb_id);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_deleteOrder);
            this.panel1.Controls.Add(this.btn_changeOrder);
            this.panel1.Controls.Add(this.btn_newOrder);
            this.panel1.Controls.Add(this.btn_searchByCusName);
            this.panel1.Controls.Add(this.btn_goodNameSearch);
            this.panel1.Controls.Add(this.btn_idSearch);
            this.panel1.Controls.Add(this.btn_showAll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 126);
            this.panel1.TabIndex = 0;
            // 
            // btn_showDetails
            // 
            this.btn_showDetails.Location = new System.Drawing.Point(787, 13);
            this.btn_showDetails.Name = "btn_showDetails";
            this.btn_showDetails.Size = new System.Drawing.Size(71, 102);
            this.btn_showDetails.TabIndex = 13;
            this.btn_showDetails.Text = "按照id查看订单细节";
            this.btn_showDetails.UseVisualStyleBackColor = true;
            this.btn_showDetails.Click += new System.EventHandler(this.btn_showDetails_Click);
            // 
            // tb_cusName
            // 
            this.tb_cusName.Location = new System.Drawing.Point(124, 94);
            this.tb_cusName.Name = "tb_cusName";
            this.tb_cusName.Size = new System.Drawing.Size(398, 25);
            this.tb_cusName.TabIndex = 12;
            // 
            // tb_goodName
            // 
            this.tb_goodName.Location = new System.Drawing.Point(124, 55);
            this.tb_goodName.Name = "tb_goodName";
            this.tb_goodName.Size = new System.Drawing.Size(398, 25);
            this.tb_goodName.TabIndex = 11;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(124, 12);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(398, 25);
            this.tb_id.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "客户名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "商品名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "订单号(id)";
            // 
            // btn_deleteOrder
            // 
            this.btn_deleteOrder.Location = new System.Drawing.Point(636, 89);
            this.btn_deleteOrder.Name = "btn_deleteOrder";
            this.btn_deleteOrder.Size = new System.Drawing.Size(144, 36);
            this.btn_deleteOrder.TabIndex = 6;
            this.btn_deleteOrder.Text = "按照id删除订单";
            this.btn_deleteOrder.UseVisualStyleBackColor = true;
            this.btn_deleteOrder.Click += new System.EventHandler(this.btn_deleteOrder_Click);
            // 
            // btn_changeOrder
            // 
            this.btn_changeOrder.Location = new System.Drawing.Point(636, 45);
            this.btn_changeOrder.Name = "btn_changeOrder";
            this.btn_changeOrder.Size = new System.Drawing.Size(144, 39);
            this.btn_changeOrder.TabIndex = 5;
            this.btn_changeOrder.Text = "按照id修改订单";
            this.btn_changeOrder.UseVisualStyleBackColor = true;
            this.btn_changeOrder.Click += new System.EventHandler(this.btn_changeOrder_Click);
            // 
            // btn_newOrder
            // 
            this.btn_newOrder.Location = new System.Drawing.Point(636, 3);
            this.btn_newOrder.Name = "btn_newOrder";
            this.btn_newOrder.Size = new System.Drawing.Size(144, 37);
            this.btn_newOrder.TabIndex = 4;
            this.btn_newOrder.Text = "新订单";
            this.btn_newOrder.UseVisualStyleBackColor = true;
            this.btn_newOrder.Click += new System.EventHandler(this.btn_newOrder_Click);
            // 
            // btn_searchByCusName
            // 
            this.btn_searchByCusName.Location = new System.Drawing.Point(528, 100);
            this.btn_searchByCusName.Name = "btn_searchByCusName";
            this.btn_searchByCusName.Size = new System.Drawing.Size(102, 25);
            this.btn_searchByCusName.TabIndex = 3;
            this.btn_searchByCusName.Text = "客户名查询";
            this.btn_searchByCusName.UseVisualStyleBackColor = true;
            this.btn_searchByCusName.Click += new System.EventHandler(this.btn_searchByCusName_Click);
            // 
            // btn_goodNameSearch
            // 
            this.btn_goodNameSearch.Location = new System.Drawing.Point(528, 69);
            this.btn_goodNameSearch.Name = "btn_goodNameSearch";
            this.btn_goodNameSearch.Size = new System.Drawing.Size(102, 25);
            this.btn_goodNameSearch.TabIndex = 2;
            this.btn_goodNameSearch.Text = "商品名查询";
            this.btn_goodNameSearch.UseVisualStyleBackColor = true;
            this.btn_goodNameSearch.Click += new System.EventHandler(this.btn_goodNameSearch_Click);
            // 
            // btn_idSearch
            // 
            this.btn_idSearch.Location = new System.Drawing.Point(528, 33);
            this.btn_idSearch.Name = "btn_idSearch";
            this.btn_idSearch.Size = new System.Drawing.Size(102, 23);
            this.btn_idSearch.TabIndex = 1;
            this.btn_idSearch.Text = "id查询";
            this.btn_idSearch.UseVisualStyleBackColor = true;
            this.btn_idSearch.Click += new System.EventHandler(this.btn_idSearch_Click);
            // 
            // btn_showAll
            // 
            this.btn_showAll.Location = new System.Drawing.Point(528, 4);
            this.btn_showAll.Name = "btn_showAll";
            this.btn_showAll.Size = new System.Drawing.Size(102, 23);
            this.btn_showAll.TabIndex = 0;
            this.btn_showAll.Text = "显示所有";
            this.btn_showAll.UseVisualStyleBackColor = true;
            this.btn_showAll.Click += new System.EventHandler(this.btn_showAll_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBinding;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(861, 375);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderBinding
            // 
            this.orderBinding.DataSource = typeof(week08.Order);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 501);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBinding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_cusName;
        private System.Windows.Forms.TextBox tb_goodName;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_deleteOrder;
        private System.Windows.Forms.Button btn_changeOrder;
        private System.Windows.Forms.Button btn_newOrder;
        private System.Windows.Forms.Button btn_searchByCusName;
        private System.Windows.Forms.Button btn_goodNameSearch;
        private System.Windows.Forms.Button btn_idSearch;
        private System.Windows.Forms.Button btn_showAll;
        private System.Windows.Forms.BindingSource orderBinding;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_showDetails;
    }
}

