﻿namespace OrderManageSystem
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
            this.dataGridView_OrderItem = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.bs_OrderItem = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Customer = new System.Windows.Forms.TextBox();
            this.btn_DelOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_OrderList = new System.Windows.Forms.DataGridView();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Query = new System.Windows.Forms.TextBox();
            this.btn_QID = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Tips = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Goods = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.btn_AddP = new System.Windows.Forms.Button();
            this.btn_MdP = new System.Windows.Forms.Button();
            this.btn_DelP = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_AddOrder = new System.Windows.Forms.Button();
            this.bs_OrderList = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrderItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_OrderItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrderList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_OrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_OrderItem
            // 
            this.dataGridView_OrderItem.AllowUserToAddRows = false;
            this.dataGridView_OrderItem.AllowUserToDeleteRows = false;
            this.dataGridView_OrderItem.AllowUserToResizeRows = false;
            this.dataGridView_OrderItem.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_OrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OrderItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Price});
            this.dataGridView_OrderItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_OrderItem.Location = new System.Drawing.Point(627, 29);
            this.dataGridView_OrderItem.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_OrderItem.Name = "dataGridView_OrderItem";
            this.dataGridView_OrderItem.ReadOnly = true;
            this.dataGridView_OrderItem.RowHeadersVisible = false;
            this.dataGridView_OrderItem.RowTemplate.Height = 23;
            this.dataGridView_OrderItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_OrderItem.Size = new System.Drawing.Size(616, 508);
            this.dataGridView_OrderItem.TabIndex = 3;
            this.dataGridView_OrderItem.SelectionChanged += new System.EventHandler(this.dataGridView_OrderItem_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Pname";
            this.dataGridViewTextBoxColumn1.HeaderText = "ItemName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Pnum";
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "PPrice";
            this.Price.HeaderText = "UnitPrice";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(627, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer";
            // 
            // tb_Customer
            // 
            this.tb_Customer.Location = new System.Drawing.Point(105, 4);
            this.tb_Customer.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Customer.Name = "tb_Customer";
            this.tb_Customer.Size = new System.Drawing.Size(132, 25);
            this.tb_Customer.TabIndex = 3;
            // 
            // btn_DelOrder
            // 
            this.btn_DelOrder.Location = new System.Drawing.Point(433, 4);
            this.btn_DelOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DelOrder.Name = "btn_DelOrder";
            this.btn_DelOrder.Size = new System.Drawing.Size(175, 52);
            this.btn_DelOrder.TabIndex = 5;
            this.btn_DelOrder.Text = "Delete";
            this.btn_DelOrder.UseVisualStyleBackColor = true;
            this.btn_DelOrder.Click += new System.EventHandler(this.btn_DelOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "List";
            // 
            // dataGridView_OrderList
            // 
            this.dataGridView_OrderList.AllowUserToAddRows = false;
            this.dataGridView_OrderList.AllowUserToDeleteRows = false;
            this.dataGridView_OrderList.AllowUserToResizeRows = false;
            this.dataGridView_OrderList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_OrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer,
            this.ID,
            this.TotalPrice});
            this.dataGridView_OrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_OrderList.Location = new System.Drawing.Point(4, 29);
            this.dataGridView_OrderList.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_OrderList.Name = "dataGridView_OrderList";
            this.dataGridView_OrderList.RowHeadersVisible = false;
            this.dataGridView_OrderList.RowTemplate.Height = 23;
            this.dataGridView_OrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_OrderList.Size = new System.Drawing.Size(615, 508);
            this.dataGridView_OrderList.TabIndex = 5;
            this.dataGridView_OrderList.SelectionChanged += new System.EventHandler(this.dataGridView_OrderList_SelectionChanged);
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "Customer";
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            this.Customer.Width = 200;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 200;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Width = 200;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_OrderList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_OrderItem, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1247, 671);
            this.tableLayoutPanel1.TabIndex = 7;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // flowLayoutPanel4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel4, 2);
            this.flowLayoutPanel4.Controls.Add(this.label7);
            this.flowLayoutPanel4.Controls.Add(this.tb_Query);
            this.flowLayoutPanel4.Controls.Add(this.btn_QID);
            this.flowLayoutPanel4.Controls.Add(this.label4);
            this.flowLayoutPanel4.Controls.Add(this.tb_Tips);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(4, 609);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1239, 44);
            this.flowLayoutPanel4.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(4, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Search";
            // 
            // tb_Query
            // 
            this.tb_Query.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Query.Location = new System.Drawing.Point(79, 4);
            this.tb_Query.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Query.Name = "tb_Query";
            this.tb_Query.Size = new System.Drawing.Size(408, 27);
            this.tb_Query.TabIndex = 4;
            // 
            // btn_QID
            // 
            this.btn_QID.Location = new System.Drawing.Point(495, 4);
            this.btn_QID.Margin = new System.Windows.Forms.Padding(4);
            this.btn_QID.Name = "btn_QID";
            this.btn_QID.Size = new System.Drawing.Size(133, 29);
            this.btn_QID.TabIndex = 5;
            this.btn_QID.Text = "Enter";
            this.btn_QID.UseVisualStyleBackColor = true;
            this.btn_QID.Click += new System.EventHandler(this.btn_QID_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(636, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reminder";
            // 
            // tb_Tips
            // 
            this.tb_Tips.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Tips.Location = new System.Drawing.Point(738, 4);
            this.tb_Tips.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Tips.Name = "tb_Tips";
            this.tb_Tips.ReadOnly = true;
            this.tb_Tips.Size = new System.Drawing.Size(445, 27);
            this.tb_Tips.TabIndex = 4;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label5);
            this.flowLayoutPanel3.Controls.Add(this.comboBox_Goods);
            this.flowLayoutPanel3.Controls.Add(this.label6);
            this.flowLayoutPanel3.Controls.Add(this.tb_num);
            this.flowLayoutPanel3.Controls.Add(this.btn_AddP);
            this.flowLayoutPanel3.Controls.Add(this.btn_MdP);
            this.flowLayoutPanel3.Controls.Add(this.btn_DelP);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(627, 545);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(616, 56);
            this.flowLayoutPanel3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(4, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name";
            // 
            // comboBox_Goods
            // 
            this.comboBox_Goods.FormattingEnabled = true;
            this.comboBox_Goods.Location = new System.Drawing.Point(74, 4);
            this.comboBox_Goods.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Goods.Name = "comboBox_Goods";
            this.comboBox_Goods.Size = new System.Drawing.Size(76, 23);
            this.comboBox_Goods.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(158, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Quantity";
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(252, 4);
            this.tb_num.Margin = new System.Windows.Forms.Padding(4);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(57, 25);
            this.tb_num.TabIndex = 9;
            // 
            // btn_AddP
            // 
            this.btn_AddP.Location = new System.Drawing.Point(317, 4);
            this.btn_AddP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddP.Name = "btn_AddP";
            this.btn_AddP.Size = new System.Drawing.Size(106, 52);
            this.btn_AddP.TabIndex = 4;
            this.btn_AddP.Text = "Add One";
            this.btn_AddP.UseVisualStyleBackColor = true;
            this.btn_AddP.Click += new System.EventHandler(this.btn_AddP_Click);
            // 
            // btn_MdP
            // 
            this.btn_MdP.Location = new System.Drawing.Point(431, 4);
            this.btn_MdP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MdP.Name = "btn_MdP";
            this.btn_MdP.Size = new System.Drawing.Size(89, 52);
            this.btn_MdP.TabIndex = 10;
            this.btn_MdP.Text = "Correct";
            this.btn_MdP.UseVisualStyleBackColor = true;
            this.btn_MdP.Click += new System.EventHandler(this.btn_MdP_Click);
            // 
            // btn_DelP
            // 
            this.btn_DelP.Location = new System.Drawing.Point(528, 4);
            this.btn_DelP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DelP.Name = "btn_DelP";
            this.btn_DelP.Size = new System.Drawing.Size(80, 52);
            this.btn_DelP.TabIndex = 5;
            this.btn_DelP.Text = "Delete";
            this.btn_DelP.UseVisualStyleBackColor = true;
            this.btn_DelP.Click += new System.EventHandler(this.btn_DelP_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.tb_Customer);
            this.flowLayoutPanel1.Controls.Add(this.btn_AddOrder);
            this.flowLayoutPanel1.Controls.Add(this.btn_DelOrder);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 545);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(615, 56);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // btn_AddOrder
            // 
            this.btn_AddOrder.Location = new System.Drawing.Point(245, 4);
            this.btn_AddOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddOrder.Name = "btn_AddOrder";
            this.btn_AddOrder.Size = new System.Drawing.Size(180, 52);
            this.btn_AddOrder.TabIndex = 4;
            this.btn_AddOrder.Text = "Add One";
            this.btn_AddOrder.UseVisualStyleBackColor = true;
            this.btn_AddOrder.Click += new System.EventHandler(this.btn_AddOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 671);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1262, 718);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrderItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_OrderItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrderList)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_OrderList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bs_OrderList;
        private System.Windows.Forms.DataGridView dataGridView_OrderItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bs_OrderItem;
        private System.Windows.Forms.Button btn_DelOrder;
        private System.Windows.Forms.TextBox tb_Customer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_OrderList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_AddP;
        private System.Windows.Forms.ComboBox comboBox_Goods;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.Button btn_MdP;
        private System.Windows.Forms.Button btn_DelP;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Query;
        private System.Windows.Forms.Button btn_QID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Tips;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.Button btn_AddOrder;
    }
}

