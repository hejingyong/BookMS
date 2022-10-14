
namespace BookMS
{
    partial class ReturnBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBookForm));
            this.DataGridView_BookList = new System.Windows.Forms.DataGridView();
            this.TextBox_QueryText = new System.Windows.Forms.TextBox();
            this.ComboBox_QueryBuilder = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Query = new System.Windows.Forms.Button();
            this.button_certain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_BookList)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_BookList
            // 
            this.DataGridView_BookList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_BookList.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_BookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_BookList.Location = new System.Drawing.Point(7, 64);
            this.DataGridView_BookList.Name = "DataGridView_BookList";
            this.DataGridView_BookList.RowHeadersWidth = 51;
            this.DataGridView_BookList.RowTemplate.Height = 23;
            this.DataGridView_BookList.Size = new System.Drawing.Size(927, 334);
            this.DataGridView_BookList.TabIndex = 17;
            // 
            // TextBox_QueryText
            // 
            this.TextBox_QueryText.Location = new System.Drawing.Point(195, 27);
            this.TextBox_QueryText.Name = "TextBox_QueryText";
            this.TextBox_QueryText.Size = new System.Drawing.Size(161, 25);
            this.TextBox_QueryText.TabIndex = 16;
            // 
            // ComboBox_QueryBuilder
            // 
            this.ComboBox_QueryBuilder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_QueryBuilder.FormattingEnabled = true;
            this.ComboBox_QueryBuilder.Items.AddRange(new object[] {
            "书号",
            "书名",
            "数量",
            "借书日期",
            "还书日期"});
            this.ComboBox_QueryBuilder.Location = new System.Drawing.Point(103, 27);
            this.ComboBox_QueryBuilder.Name = "ComboBox_QueryBuilder";
            this.ComboBox_QueryBuilder.Size = new System.Drawing.Size(86, 23);
            this.ComboBox_QueryBuilder.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "查询条件";
            // 
            // Button_Query
            // 
            this.Button_Query.Location = new System.Drawing.Point(362, 27);
            this.Button_Query.Name = "Button_Query";
            this.Button_Query.Size = new System.Drawing.Size(79, 29);
            this.Button_Query.TabIndex = 13;
            this.Button_Query.Text = "查询";
            this.Button_Query.UseVisualStyleBackColor = true;
            this.Button_Query.Click += new System.EventHandler(this.Button_Query_Click);
            // 
            // button_certain
            // 
            this.button_certain.Location = new System.Drawing.Point(479, 26);
            this.button_certain.Name = "button_certain";
            this.button_certain.Size = new System.Drawing.Size(186, 29);
            this.button_certain.TabIndex = 18;
            this.button_certain.Text = "还书";
            this.button_certain.UseVisualStyleBackColor = true;
            this.button_certain.Click += new System.EventHandler(this.button_certain_Click);
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 399);
            this.Controls.Add(this.button_certain);
            this.Controls.Add(this.DataGridView_BookList);
            this.Controls.Add(this.TextBox_QueryText);
            this.Controls.Add(this.ComboBox_QueryBuilder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Query);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReturnBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "还书";
            this.Load += new System.EventHandler(this.ReturnBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_BookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_BookList;
        private System.Windows.Forms.TextBox TextBox_QueryText;
        private System.Windows.Forms.ComboBox ComboBox_QueryBuilder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Query;
        private System.Windows.Forms.Button button_certain;
    }
}