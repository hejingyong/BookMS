
namespace BookMS
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.DataGridView_BookList = new System.Windows.Forms.DataGridView();
            this.TextBox_QueryText = new System.Windows.Forms.TextBox();
            this.ComboBox_QueryBuilder = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Query = new System.Windows.Forms.Button();
            this.MenuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_Borrow = new System.Windows.Forms.Button();
            this.Button_Return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_BookList)).BeginInit();
            this.MenuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView_BookList
            // 
            this.DataGridView_BookList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_BookList.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_BookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_BookList.Location = new System.Drawing.Point(1, 68);
            this.DataGridView_BookList.Name = "DataGridView_BookList";
            this.DataGridView_BookList.RowHeadersWidth = 51;
            this.DataGridView_BookList.RowTemplate.Height = 23;
            this.DataGridView_BookList.Size = new System.Drawing.Size(739, 377);
            this.DataGridView_BookList.TabIndex = 12;
  
            // 
            // TextBox_QueryText
            // 
            this.TextBox_QueryText.Location = new System.Drawing.Point(195, 33);
            this.TextBox_QueryText.Name = "TextBox_QueryText";
            this.TextBox_QueryText.Size = new System.Drawing.Size(161, 27);
            this.TextBox_QueryText.TabIndex = 11;
    
            // 
            // ComboBox_QueryBuilder
            // 
            this.ComboBox_QueryBuilder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_QueryBuilder.FormattingEnabled = true;
            this.ComboBox_QueryBuilder.Items.AddRange(new object[] {
            "书号",
            "书名",
            "作者",
            "出版社"});
            this.ComboBox_QueryBuilder.Location = new System.Drawing.Point(103, 31);
            this.ComboBox_QueryBuilder.Name = "ComboBox_QueryBuilder";
            this.ComboBox_QueryBuilder.Size = new System.Drawing.Size(86, 28);
            this.ComboBox_QueryBuilder.TabIndex = 10;
  
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "查询条件";

            // 
            // Button_Query
            // 
            this.Button_Query.Location = new System.Drawing.Point(362, 32);
            this.Button_Query.Name = "Button_Query";
            this.Button_Query.Size = new System.Drawing.Size(79, 29);
            this.Button_Query.TabIndex = 8;
            this.Button_Query.Text = "查询";
            this.Button_Query.UseVisualStyleBackColor = true;
            this.Button_Query.Click += new System.EventHandler(this.Button_Query_Click);
            // 
            // MenuStrip_Main
            // 
            this.MenuStrip_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.MenuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Main.Name = "MenuStrip_Main";
            this.MenuStrip_Main.Size = new System.Drawing.Size(741, 28);
            this.MenuStrip_Main.TabIndex = 13;
            this.MenuStrip_Main.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注销登录ToolStripMenuItem,
            this.借书ToolStripMenuItem,
            this.还书ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // 注销登录ToolStripMenuItem
            // 
            this.注销登录ToolStripMenuItem.Name = "注销登录ToolStripMenuItem";
            this.注销登录ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.注销登录ToolStripMenuItem.Text = "注销登录";
            this.注销登录ToolStripMenuItem.Click += new System.EventHandler(this.注销登录ToolStripMenuItem_Click);
            // 
            // 借书ToolStripMenuItem
            // 
            this.借书ToolStripMenuItem.Name = "借书ToolStripMenuItem";
            this.借书ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.借书ToolStripMenuItem.Text = "借书";
            this.借书ToolStripMenuItem.Click += new System.EventHandler(this.借书ToolStripMenuItem_Click);
            // 
            // 还书ToolStripMenuItem
            // 
            this.还书ToolStripMenuItem.Name = "还书ToolStripMenuItem";
            this.还书ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.还书ToolStripMenuItem.Text = "还书";
            this.还书ToolStripMenuItem.Click += new System.EventHandler(this.还书ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // Button_Borrow
            // 
            this.Button_Borrow.Location = new System.Drawing.Point(650, 30);
            this.Button_Borrow.Name = "Button_Borrow";
            this.Button_Borrow.Size = new System.Drawing.Size(79, 29);
            this.Button_Borrow.TabIndex = 14;
            this.Button_Borrow.Text = "借书";
            this.Button_Borrow.UseVisualStyleBackColor = true;
            this.Button_Borrow.Click += new System.EventHandler(this.Button_Borrow_Click);
            // 
            // Button_Return
            // 
            this.Button_Return.Location = new System.Drawing.Point(565, 30);
            this.Button_Return.Name = "Button_Return";
            this.Button_Return.Size = new System.Drawing.Size(79, 29);
            this.Button_Return.TabIndex = 15;
            this.Button_Return.Text = "还书";
            this.Button_Return.UseVisualStyleBackColor = true;
            this.Button_Return.Click += new System.EventHandler(this.Button_Return_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(741, 452);
            this.Controls.Add(this.Button_Return);
            this.Controls.Add(this.Button_Borrow);
            this.Controls.Add(this.MenuStrip_Main);
            this.Controls.Add(this.DataGridView_BookList);
            this.Controls.Add(this.TextBox_QueryText);
            this.Controls.Add(this.ComboBox_QueryBuilder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Query);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书管理系统 - 用户";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_BookList)).EndInit();
            this.MenuStrip_Main.ResumeLayout(false);
            this.MenuStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_BookList;
        private System.Windows.Forms.TextBox TextBox_QueryText;
        private System.Windows.Forms.ComboBox ComboBox_QueryBuilder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Query;
        private System.Windows.Forms.MenuStrip MenuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Button Button_Borrow;
        private System.Windows.Forms.Button Button_Return;
        private System.Windows.Forms.ToolStripMenuItem 借书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还书ToolStripMenuItem;
    }
}