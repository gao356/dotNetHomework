
namespace week07
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
            this.draw = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.per2 = new System.Windows.Forms.Label();
            this.th1 = new System.Windows.Forms.Label();
            this.per_1 = new System.Windows.Forms.TextBox();
            this.per_2 = new System.Windows.Forms.TextBox();
            this.per1 = new System.Windows.Forms.Label();
            this.th2 = new System.Windows.Forms.Label();
            this.th_1 = new System.Windows.Forms.TextBox();
            this.length = new System.Windows.Forms.TextBox();
            this.th_2 = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.Label();
            this.leng = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.TextBox();
            this.depth = new System.Windows.Forms.TextBox();
            this.n = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // draw
            // 
            this.draw.Location = new System.Drawing.Point(526, 12);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(104, 40);
            this.draw.TabIndex = 0;
            this.draw.Text = "draw";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 586);
            this.panel1.TabIndex = 15;
            // 
            // per2
            // 
            this.per2.AutoSize = true;
            this.per2.Location = new System.Drawing.Point(3, 266);
            this.per2.Name = "per2";
            this.per2.Size = new System.Drawing.Size(97, 15);
            this.per2.TabIndex = 4;
            this.per2.Text = "左分支角度比";
            // 
            // th1
            // 
            this.th1.AutoSize = true;
            this.th1.Location = new System.Drawing.Point(3, 339);
            this.th1.Name = "th1";
            this.th1.Size = new System.Drawing.Size(82, 15);
            this.th1.TabIndex = 5;
            this.th1.Text = "右分支角度";
            // 
            // per_1
            // 
            this.per_1.Location = new System.Drawing.Point(3, 218);
            this.per_1.Name = "per_1";
            this.per_1.Size = new System.Drawing.Size(100, 25);
            this.per_1.TabIndex = 10;
            // 
            // per_2
            // 
            this.per_2.Location = new System.Drawing.Point(3, 304);
            this.per_2.Name = "per_2";
            this.per_2.Size = new System.Drawing.Size(100, 25);
            this.per_2.TabIndex = 11;
            // 
            // per1
            // 
            this.per1.AutoSize = true;
            this.per1.Location = new System.Drawing.Point(3, 175);
            this.per1.Name = "per1";
            this.per1.Size = new System.Drawing.Size(97, 15);
            this.per1.TabIndex = 3;
            this.per1.Text = "右分支角度比";
            // 
            // th2
            // 
            this.th2.AutoSize = true;
            this.th2.Location = new System.Drawing.Point(3, 413);
            this.th2.Name = "th2";
            this.th2.Size = new System.Drawing.Size(82, 15);
            this.th2.TabIndex = 6;
            this.th2.Text = "左分支角度";
            // 
            // th_1
            // 
            this.th_1.Location = new System.Drawing.Point(3, 379);
            this.th_1.Name = "th_1";
            this.th_1.Size = new System.Drawing.Size(100, 25);
            this.th_1.TabIndex = 12;
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(3, 131);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(100, 25);
            this.length.TabIndex = 9;
            // 
            // th_2
            // 
            this.th_2.Location = new System.Drawing.Point(3, 458);
            this.th_2.Name = "th_2";
            this.th_2.Size = new System.Drawing.Size(100, 25);
            this.th_2.TabIndex = 13;
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Location = new System.Drawing.Point(3, 494);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(37, 15);
            this.color.TabIndex = 7;
            this.color.Text = "颜色";
            // 
            // leng
            // 
            this.leng.AutoSize = true;
            this.leng.Location = new System.Drawing.Point(3, 90);
            this.leng.Name = "leng";
            this.leng.Size = new System.Drawing.Size(67, 15);
            this.leng.TabIndex = 2;
            this.leng.Text = "主干长度";
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(3, 523);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(100, 25);
            this.c.TabIndex = 14;
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(3, 44);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(100, 25);
            this.depth.TabIndex = 8;
            // 
            // n
            // 
            this.n.AutoSize = true;
            this.n.Location = new System.Drawing.Point(3, 0);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(67, 15);
            this.n.TabIndex = 1;
            this.n.Text = "递归深度";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.n, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.depth, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.c, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.leng, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.color, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.th_2, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.length, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.th_1, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.th2, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.per1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.per_2, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.per_1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.th1, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.per2, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 586);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 586);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label per2;
        private System.Windows.Forms.Label th1;
        private System.Windows.Forms.TextBox per_1;
        private System.Windows.Forms.TextBox per_2;
        private System.Windows.Forms.Label per1;
        private System.Windows.Forms.Label th2;
        private System.Windows.Forms.TextBox th_1;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.TextBox th_2;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.Label leng;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.TextBox depth;
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

