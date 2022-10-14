
namespace BookMS
{
    partial class BorrowBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowBookForm));
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Edit = new System.Windows.Forms.Button();
            this.TextBox_Rtime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_BookQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_BookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_ISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_SelectDate1 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(235, 154);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(80, 30);
            this.Button_Cancel.TabIndex = 37;
            this.Button_Cancel.Text = "取消";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click_1);
            // 
            // Button_Edit
            // 
            this.Button_Edit.Location = new System.Drawing.Point(28, 154);
            this.Button_Edit.Name = "Button_Edit";
            this.Button_Edit.Size = new System.Drawing.Size(155, 30);
            this.Button_Edit.TabIndex = 36;
            this.Button_Edit.Text = "确认借书";
            this.Button_Edit.UseVisualStyleBackColor = true;
            this.Button_Edit.Click += new System.EventHandler(this.Button_Edit_Click);
            // 
            // TextBox_Rtime
            // 
            this.TextBox_Rtime.Location = new System.Drawing.Point(120, 110);
            this.TextBox_Rtime.Name = "TextBox_Rtime";
            this.TextBox_Rtime.Size = new System.Drawing.Size(149, 25);
            this.TextBox_Rtime.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "还书时间";
            // 
            // TextBox_BookQuantity
            // 
            this.TextBox_BookQuantity.Location = new System.Drawing.Point(120, 80);
            this.TextBox_BookQuantity.Name = "TextBox_BookQuantity";
            this.TextBox_BookQuantity.Size = new System.Drawing.Size(149, 25);
            this.TextBox_BookQuantity.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 41;
            this.label3.Text = "数量";
            // 
            // TextBox_BookName
            // 
            this.TextBox_BookName.Location = new System.Drawing.Point(120, 51);
            this.TextBox_BookName.Name = "TextBox_BookName";
            this.TextBox_BookName.Size = new System.Drawing.Size(149, 25);
            this.TextBox_BookName.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "书名";
            // 
            // TextBox_ISBN
            // 
            this.TextBox_ISBN.Location = new System.Drawing.Point(120, 21);
            this.TextBox_ISBN.Name = "TextBox_ISBN";
            this.TextBox_ISBN.Size = new System.Drawing.Size(149, 25);
            this.TextBox_ISBN.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "书号";
            // 
            // button_SelectDate1
            // 
            this.button_SelectDate1.Location = new System.Drawing.Point(275, 111);
            this.button_SelectDate1.Name = "button_SelectDate1";
            this.button_SelectDate1.Size = new System.Drawing.Size(80, 30);
            this.button_SelectDate1.TabIndex = 44;
            this.button_SelectDate1.Text = "选择";
            this.button_SelectDate1.UseVisualStyleBackColor = true;
            this.button_SelectDate1.Click += new System.EventHandler(this.button_SelectDate1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(367, 6);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 46;
            this.monthCalendar1.TitleForeColor = System.Drawing.Color.AntiqueWhite;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // BorrowBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 313);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button_SelectDate1);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Edit);
            this.Controls.Add(this.TextBox_Rtime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBox_BookQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox_BookName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_ISBN);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BorrowBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "借书";
            this.Load += new System.EventHandler(this.BorrowBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Edit;
        private System.Windows.Forms.TextBox TextBox_Rtime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox_BookQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_BookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_ISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_SelectDate1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}