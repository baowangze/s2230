namespace FrmTreeView
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
            this.tvw = new System.Windows.Forms.TreeView();
            this.bttjia = new System.Windows.Forms.Button();
            this.bttjiazi = new System.Windows.Forms.Button();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tvw
            // 
            this.tvw.Location = new System.Drawing.Point(105, 71);
            this.tvw.Name = "tvw";
            this.tvw.Size = new System.Drawing.Size(527, 442);
            this.tvw.TabIndex = 0;
            // 
            // bttjia
            // 
            this.bttjia.Location = new System.Drawing.Point(745, 195);
            this.bttjia.Name = "bttjia";
            this.bttjia.Size = new System.Drawing.Size(75, 23);
            this.bttjia.TabIndex = 1;
            this.bttjia.Text = "添加节点";
            this.bttjia.UseVisualStyleBackColor = true;
            this.bttjia.Click += new System.EventHandler(this.bttjia_Click);
            // 
            // bttjiazi
            // 
            this.bttjiazi.Location = new System.Drawing.Point(910, 195);
            this.bttjiazi.Name = "bttjiazi";
            this.bttjiazi.Size = new System.Drawing.Size(75, 23);
            this.bttjiazi.TabIndex = 1;
            this.bttjiazi.Text = "添加子节点";
            this.bttjiazi.UseVisualStyleBackColor = true;
            this.bttjiazi.Click += new System.EventHandler(this.bttjiazi_Click);
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(745, 104);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(240, 25);
            this.txtbox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 616);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.bttjiazi);
            this.Controls.Add(this.bttjia);
            this.Controls.Add(this.tvw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvw;
        private System.Windows.Forms.Button bttjia;
        private System.Windows.Forms.Button bttjiazi;
        private System.Windows.Forms.TextBox txtbox;
    }
}

