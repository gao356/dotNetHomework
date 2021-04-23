
namespace week09
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
            this.URL = new System.Windows.Forms.Label();
            this.URLTextBox = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_website = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // URL
            // 
            this.URL.AutoSize = true;
            this.URL.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.URL.Location = new System.Drawing.Point(22, 36);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(51, 25);
            this.URL.TabIndex = 0;
            this.URL.Text = "URL";
            // 
            // URLTextBox
            // 
            this.URLTextBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.URLTextBox.Location = new System.Drawing.Point(103, 36);
            this.URLTextBox.Name = "URLTextBox";
            this.URLTextBox.Size = new System.Drawing.Size(527, 30);
            this.URLTextBox.TabIndex = 1;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(225, 157);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(218, 45);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "开始爬取";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "指定网址";
            // 
            // TB_website
            // 
            this.TB_website.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_website.Location = new System.Drawing.Point(103, 107);
            this.TB_website.Name = "TB_website";
            this.TB_website.Size = new System.Drawing.Size(527, 30);
            this.TB_website.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 214);
            this.Controls.Add(this.TB_website);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.URLTextBox);
            this.Controls.Add(this.URL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label URL;
        private System.Windows.Forms.TextBox URLTextBox;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_website;
    }
}

