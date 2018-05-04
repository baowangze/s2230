namespace Frmtaocan
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtming = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSetPrice = new System.Windows.Forms.Label();
            this.lblSetName = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comItems = new System.Windows.Forms.ComboBox();
            this.cbSets = new System.Windows.Forms.ComboBox();
            this.dgvHealthList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHealthList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtming);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(101, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新建套餐";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtming
            // 
            this.txtming.Location = new System.Drawing.Point(211, 60);
            this.txtming.Name = "txtming";
            this.txtming.Size = new System.Drawing.Size(226, 25);
            this.txtming.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "套餐名称";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSetPrice);
            this.groupBox2.Controls.Add(this.lblSetName);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comItems);
            this.groupBox2.Controls.Add(this.cbSets);
            this.groupBox2.Controls.Add(this.dgvHealthList);
            this.groupBox2.Location = new System.Drawing.Point(101, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(683, 372);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "检查套餐维护";
            // 
            // lblSetPrice
            // 
            this.lblSetPrice.AutoSize = true;
            this.lblSetPrice.Location = new System.Drawing.Point(303, 117);
            this.lblSetPrice.Name = "lblSetPrice";
            this.lblSetPrice.Size = new System.Drawing.Size(55, 15);
            this.lblSetPrice.TabIndex = 8;
            this.lblSetPrice.Text = "label5";
            // 
            // lblSetName
            // 
            this.lblSetName.AutoSize = true;
            this.lblSetName.Location = new System.Drawing.Point(72, 118);
            this.lblSetName.Name = "lblSetName";
            this.lblSetName.Size = new System.Drawing.Size(55, 15);
            this.lblSetName.TabIndex = 7;
            this.lblSetName.Text = "label4";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(555, 110);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(425, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "添加";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "检查项目";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "套餐列表";
            // 
            // comItems
            // 
            this.comItems.FormattingEnabled = true;
            this.comItems.Location = new System.Drawing.Point(474, 67);
            this.comItems.Name = "comItems";
            this.comItems.Size = new System.Drawing.Size(183, 23);
            this.comItems.TabIndex = 2;
            this.comItems.SelectedIndexChanged += new System.EventHandler(this.comItems_SelectedIndexChanged);
            // 
            // cbSets
            // 
            this.cbSets.FormattingEnabled = true;
            this.cbSets.Location = new System.Drawing.Point(149, 67);
            this.cbSets.Name = "cbSets";
            this.cbSets.Size = new System.Drawing.Size(200, 23);
            this.cbSets.TabIndex = 1;
            this.cbSets.SelectedIndexChanged += new System.EventHandler(this.cmbming_SelectedIndexChanged);
            // 
            // dgvHealthList
            // 
            this.dgvHealthList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHealthList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHealthList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvHealthList.Location = new System.Drawing.Point(31, 159);
            this.dgvHealthList.Name = "dgvHealthList";
            this.dgvHealthList.ReadOnly = true;
            this.dgvHealthList.RowTemplate.Height = 27;
            this.dgvHealthList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHealthList.Size = new System.Drawing.Size(626, 207);
            this.dgvHealthList.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "项目名";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "description";
            this.Column2.HeaderText = "描述";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Price";
            this.Column3.HeaderText = "价格";
            this.Column3.Name = "Column3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 666);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "体检套餐管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHealthList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtming;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comItems;
        private System.Windows.Forms.ComboBox cbSets;
        private System.Windows.Forms.DataGridView dgvHealthList;
        private System.Windows.Forms.Label lblSetPrice;
        private System.Windows.Forms.Label lblSetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

