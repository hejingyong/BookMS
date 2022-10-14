
namespace BookMS
{
    partial class AdminAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAddForm));
            this.LinkLabel_CAPTCHA = new System.Windows.Forms.LinkLabel();
            this.TextBox_CAPTCHA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Add = new System.Windows.Forms.Button();
            this.TextBox_Store = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBox_Publisher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_BookAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_BookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_ISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LinkLabel_CAPTCHA
            // 
            this.LinkLabel_CAPTCHA.AutoSize = true;
            this.LinkLabel_CAPTCHA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkLabel_CAPTCHA.Location = new System.Drawing.Point(169, 165);
            this.LinkLabel_CAPTCHA.Name = "LinkLabel_CAPTCHA";
            this.LinkLabel_CAPTCHA.Size = new System.Drawing.Size(54, 20);
            this.LinkLabel_CAPTCHA.TabIndex = 9;
            this.LinkLabel_CAPTCHA.TabStop = true;
            this.LinkLabel_CAPTCHA.Text = "1a2b3";
            // 
            // TextBox_CAPTCHA
            // 
            this.TextBox_CAPTCHA.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TextBox_CAPTCHA.Location = new System.Drawing.Point(68, 162);
            this.TextBox_CAPTCHA.Name = "TextBox_CAPTCHA";
            this.TextBox_CAPTCHA.Size = new System.Drawing.Size(84, 27);
            this.TextBox_CAPTCHA.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "验证码";
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(139, 211);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(80, 30);
            this.Button_Cancel.TabIndex = 8;
            this.Button_Cancel.Text = "取消";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(15, 211);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(80, 30);
            this.Button_Add.TabIndex = 7;
            this.Button_Add.Text = "添加";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // TextBox_Store
            // 
            this.TextBox_Store.Location = new System.Drawing.Point(68, 133);
            this.TextBox_Store.Name = "TextBox_Store";
            this.TextBox_Store.Size = new System.Drawing.Size(149, 27);
            this.TextBox_Store.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "库存";
            // 
            // TextBox_Publisher
            // 
            this.TextBox_Publisher.Location = new System.Drawing.Point(68, 104);
            this.TextBox_Publisher.Name = "TextBox_Publisher";
            this.TextBox_Publisher.Size = new System.Drawing.Size(149, 27);
            this.TextBox_Publisher.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "出版社";
            // 
            // TextBox_BookAuthor
            // 
            this.TextBox_BookAuthor.Location = new System.Drawing.Point(68, 75);
            this.TextBox_BookAuthor.Name = "TextBox_BookAuthor";
            this.TextBox_BookAuthor.Size = new System.Drawing.Size(149, 27);
            this.TextBox_BookAuthor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "作者";
            // 
            // TextBox_BookName
            // 
            this.TextBox_BookName.Location = new System.Drawing.Point(68, 46);
            this.TextBox_BookName.Name = "TextBox_BookName";
            this.TextBox_BookName.Size = new System.Drawing.Size(149, 27);
            this.TextBox_BookName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "书名";
            // 
            // TextBox_ISBN
            // 
            this.TextBox_ISBN.Location = new System.Drawing.Point(68, 17);
            this.TextBox_ISBN.Name = "TextBox_ISBN";
            this.TextBox_ISBN.Size = new System.Drawing.Size(149, 27);
            this.TextBox_ISBN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "书号";
            // 
            // AdminAddForm
            // 
            this.AcceptButton = this.Button_Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(231, 251);
            this.Controls.Add(this.LinkLabel_CAPTCHA);
            this.Controls.Add(this.TextBox_CAPTCHA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.TextBox_Store);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBox_Publisher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBox_BookAuthor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox_BookName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_ISBN);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书管理系统 - 添加图书信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LinkLabel_CAPTCHA;
        private System.Windows.Forms.TextBox TextBox_CAPTCHA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.TextBox TextBox_Store;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBox_Publisher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox_BookAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_BookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_ISBN;
        private System.Windows.Forms.Label label1;
    }
}