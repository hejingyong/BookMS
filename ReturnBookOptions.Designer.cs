
namespace BookMS
{
    partial class ReturnBookOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBookOptions));
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Edit = new System.Windows.Forms.Button();
            this.TextBox_BookQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_BookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_ISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(174, 133);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(80, 30);
            this.Button_Cancel.TabIndex = 50;
            this.Button_Cancel.Text = "取消";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Edit
            // 
            this.Button_Edit.Location = new System.Drawing.Point(12, 133);
            this.Button_Edit.Name = "Button_Edit";
            this.Button_Edit.Size = new System.Drawing.Size(156, 30);
            this.Button_Edit.TabIndex = 49;
            this.Button_Edit.Text = "确认还书";
            this.Button_Edit.UseVisualStyleBackColor = true;
            this.Button_Edit.Click += new System.EventHandler(this.Button_Edit_Click);
            // 
            // TextBox_BookQuantity
            // 
            this.TextBox_BookQuantity.Location = new System.Drawing.Point(105, 99);
            this.TextBox_BookQuantity.Name = "TextBox_BookQuantity";
            this.TextBox_BookQuantity.Size = new System.Drawing.Size(149, 25);
            this.TextBox_BookQuantity.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 53;
            this.label3.Text = "数量";
            // 
            // TextBox_BookName
            // 
            this.TextBox_BookName.Location = new System.Drawing.Point(105, 70);
            this.TextBox_BookName.Name = "TextBox_BookName";
            this.TextBox_BookName.Size = new System.Drawing.Size(149, 25);
            this.TextBox_BookName.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 52;
            this.label2.Text = "书名";
            // 
            // TextBox_ISBN
            // 
            this.TextBox_ISBN.Location = new System.Drawing.Point(105, 40);
            this.TextBox_ISBN.Name = "TextBox_ISBN";
            this.TextBox_ISBN.Size = new System.Drawing.Size(149, 25);
            this.TextBox_ISBN.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 51;
            this.label1.Text = "书号";
            // 
            // TextBox_ID
            // 
            this.TextBox_ID.Location = new System.Drawing.Point(105, 9);
            this.TextBox_ID.Name = "TextBox_ID";
            this.TextBox_ID.Size = new System.Drawing.Size(149, 25);
            this.TextBox_ID.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 55;
            this.label4.Text = "序号";
            // 
            // ReturnBookOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 191);
            this.Controls.Add(this.TextBox_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Edit);
            this.Controls.Add(this.TextBox_BookQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox_BookName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_ISBN);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReturnBookOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "还书选择";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Edit;
        private System.Windows.Forms.TextBox TextBox_BookQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_BookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_ISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_ID;
        private System.Windows.Forms.Label label4;
    }
}