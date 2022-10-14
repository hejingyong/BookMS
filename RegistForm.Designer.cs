
namespace BookMS
{
    partial class RegistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistForm));
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_UserName = new System.Windows.Forms.TextBox();
            this.TextBox_UserPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_UserPassword2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_Regist = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.RadioButton_User = new System.Windows.Forms.RadioButton();
            this.RadioButton_Admin = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.LinkLabel_CAPTCHA = new System.Windows.Forms.LinkLabel();
            this.TextBox_CAPTCHA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // TextBox_UserName
            // 
            this.TextBox_UserName.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TextBox_UserName.Location = new System.Drawing.Point(80, 15);
            this.TextBox_UserName.Name = "TextBox_UserName";
            this.TextBox_UserName.Size = new System.Drawing.Size(141, 27);
            this.TextBox_UserName.TabIndex = 1;
            // 
            // TextBox_UserPassword
            // 
            this.TextBox_UserPassword.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TextBox_UserPassword.Location = new System.Drawing.Point(80, 44);
            this.TextBox_UserPassword.Name = "TextBox_UserPassword";
            this.TextBox_UserPassword.Size = new System.Drawing.Size(141, 27);
            this.TextBox_UserPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "密   码";
            // 
            // TextBox_UserPassword2
            // 
            this.TextBox_UserPassword2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TextBox_UserPassword2.Location = new System.Drawing.Point(80, 73);
            this.TextBox_UserPassword2.Name = "TextBox_UserPassword2";
            this.TextBox_UserPassword2.Size = new System.Drawing.Size(141, 27);
            this.TextBox_UserPassword2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "确认密码";
            // 
            // Button_Regist
            // 
            this.Button_Regist.Location = new System.Drawing.Point(15, 185);
            this.Button_Regist.Name = "Button_Regist";
            this.Button_Regist.Size = new System.Drawing.Size(95, 33);
            this.Button_Regist.TabIndex = 5;
            this.Button_Regist.Text = "注册";
            this.Button_Regist.UseVisualStyleBackColor = true;
            this.Button_Regist.Click += new System.EventHandler(this.Button_Regist_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(126, 185);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(95, 33);
            this.Button_Cancel.TabIndex = 6;
            this.Button_Cancel.Text = "取消";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // RadioButton_User
            // 
            this.RadioButton_User.AutoSize = true;
            this.RadioButton_User.Location = new System.Drawing.Point(148, 114);
            this.RadioButton_User.Name = "RadioButton_User";
            this.RadioButton_User.Size = new System.Drawing.Size(60, 24);
            this.RadioButton_User.TabIndex = 8;
            this.RadioButton_User.TabStop = true;
            this.RadioButton_User.Text = "用户";
            this.RadioButton_User.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Admin
            // 
            this.RadioButton_Admin.AutoSize = true;
            this.RadioButton_Admin.Checked = true;
            this.RadioButton_Admin.Location = new System.Drawing.Point(80, 114);
            this.RadioButton_Admin.Name = "RadioButton_Admin";
            this.RadioButton_Admin.Size = new System.Drawing.Size(75, 24);
            this.RadioButton_Admin.TabIndex = 7;
            this.RadioButton_Admin.TabStop = true;
            this.RadioButton_Admin.Text = "管理员";
            this.RadioButton_Admin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "身份组";
            // 
            // LinkLabel_CAPTCHA
            // 
            this.LinkLabel_CAPTCHA.AutoSize = true;
            this.LinkLabel_CAPTCHA.Location = new System.Drawing.Point(173, 144);
            this.LinkLabel_CAPTCHA.Name = "LinkLabel_CAPTCHA";
            this.LinkLabel_CAPTCHA.Size = new System.Drawing.Size(54, 20);
            this.LinkLabel_CAPTCHA.TabIndex = 14;
            this.LinkLabel_CAPTCHA.TabStop = true;
            this.LinkLabel_CAPTCHA.Text = "1a2b3";
            // 
            // TextBox_CAPTCHA
            // 
            this.TextBox_CAPTCHA.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TextBox_CAPTCHA.Location = new System.Drawing.Point(80, 141);
            this.TextBox_CAPTCHA.Name = "TextBox_CAPTCHA";
            this.TextBox_CAPTCHA.Size = new System.Drawing.Size(77, 27);
            this.TextBox_CAPTCHA.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "验证码";
            // 
            // RegistForm
            // 
            this.AcceptButton = this.Button_Regist;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(237, 231);
            this.Controls.Add(this.LinkLabel_CAPTCHA);
            this.Controls.Add(this.TextBox_CAPTCHA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RadioButton_User);
            this.Controls.Add(this.RadioButton_Admin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Regist);
            this.Controls.Add(this.TextBox_UserPassword2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox_UserPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_UserName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书管理系统 - 注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_UserName;
        private System.Windows.Forms.TextBox TextBox_UserPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_UserPassword2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_Regist;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.RadioButton RadioButton_User;
        private System.Windows.Forms.RadioButton RadioButton_Admin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel LinkLabel_CAPTCHA;
        private System.Windows.Forms.TextBox TextBox_CAPTCHA;
        private System.Windows.Forms.Label label4;
    }
}