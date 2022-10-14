
namespace BookMS
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_UserName = new System.Windows.Forms.TextBox();
            this.TextBox_UserPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RadioButton_Admin = new System.Windows.Forms.RadioButton();
            this.RadioButton_User = new System.Windows.Forms.RadioButton();
            this.Button_Login = new System.Windows.Forms.Button();
            this.Button_Regist = new System.Windows.Forms.Button();
            this.TextBox_CAPTCHA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LinkLabel_CAPTCHA = new System.Windows.Forms.LinkLabel();
            this.LinkLabel_ForgetPassword = new System.Windows.Forms.LinkLabel();
            this.ToolTip_Main = new System.Windows.Forms.ToolTip(this.components);
            this.Label_ConnState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书管理系统";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名";
            // 
            // TextBox_UserName
            // 
            this.TextBox_UserName.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TextBox_UserName.Location = new System.Drawing.Point(204, 89);
            this.TextBox_UserName.Name = "TextBox_UserName";
            this.TextBox_UserName.Size = new System.Drawing.Size(156, 27);
            this.TextBox_UserName.TabIndex = 1;
            // 
            // TextBox_UserPassword
            // 
            this.TextBox_UserPassword.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TextBox_UserPassword.Location = new System.Drawing.Point(204, 118);
            this.TextBox_UserPassword.Name = "TextBox_UserPassword";
            this.TextBox_UserPassword.PasswordChar = '●';
            this.TextBox_UserPassword.Size = new System.Drawing.Size(156, 27);
            this.TextBox_UserPassword.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "密   码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "身份组";
            // 
            // RadioButton_Admin
            // 
            this.RadioButton_Admin.AutoSize = true;
            this.RadioButton_Admin.Checked = true;
            this.RadioButton_Admin.Location = new System.Drawing.Point(204, 186);
            this.RadioButton_Admin.Name = "RadioButton_Admin";
            this.RadioButton_Admin.Size = new System.Drawing.Size(75, 24);
            this.RadioButton_Admin.TabIndex = 6;
            this.RadioButton_Admin.TabStop = true;
            this.RadioButton_Admin.Text = "管理员";
            this.RadioButton_Admin.UseVisualStyleBackColor = true;
            this.RadioButton_Admin.CheckedChanged += new System.EventHandler(this.RadioButton_Admin_CheckedChanged);
            // 
            // RadioButton_User
            // 
            this.RadioButton_User.AutoSize = true;
            this.RadioButton_User.Location = new System.Drawing.Point(272, 186);
            this.RadioButton_User.Name = "RadioButton_User";
            this.RadioButton_User.Size = new System.Drawing.Size(60, 24);
            this.RadioButton_User.TabIndex = 7;
            this.RadioButton_User.TabStop = true;
            this.RadioButton_User.Text = "用户";
            this.RadioButton_User.UseVisualStyleBackColor = true;
            this.RadioButton_User.CheckedChanged += new System.EventHandler(this.RadioButton_User_CheckedChanged);
            // 
            // Button_Login
            // 
            this.Button_Login.Location = new System.Drawing.Point(267, 225);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(93, 33);
            this.Button_Login.TabIndex = 4;
            this.Button_Login.Text = "登录";
            this.Button_Login.UseVisualStyleBackColor = true;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // Button_Regist
            // 
            this.Button_Regist.Location = new System.Drawing.Point(147, 225);
            this.Button_Regist.Name = "Button_Regist";
            this.Button_Regist.Size = new System.Drawing.Size(93, 33);
            this.Button_Regist.TabIndex = 5;
            this.Button_Regist.Text = "注册";
            this.Button_Regist.UseVisualStyleBackColor = true;
            this.Button_Regist.Click += new System.EventHandler(this.Button_Regist_Click);
            // 
            // TextBox_CAPTCHA
            // 
            this.TextBox_CAPTCHA.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TextBox_CAPTCHA.Location = new System.Drawing.Point(204, 147);
            this.TextBox_CAPTCHA.Name = "TextBox_CAPTCHA";
            this.TextBox_CAPTCHA.Size = new System.Drawing.Size(84, 27);
            this.TextBox_CAPTCHA.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "验证码";
            // 
            // LinkLabel_CAPTCHA
            // 
            this.LinkLabel_CAPTCHA.AutoSize = true;
            this.LinkLabel_CAPTCHA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkLabel_CAPTCHA.Location = new System.Drawing.Point(310, 150);
            this.LinkLabel_CAPTCHA.Name = "LinkLabel_CAPTCHA";
            this.LinkLabel_CAPTCHA.Size = new System.Drawing.Size(54, 20);
            this.LinkLabel_CAPTCHA.TabIndex = 8;
            this.LinkLabel_CAPTCHA.TabStop = true;
            this.LinkLabel_CAPTCHA.Text = "1a2b3";
            this.ToolTip_Main.SetToolTip(this.LinkLabel_CAPTCHA, "看不清，换一张");
            this.LinkLabel_CAPTCHA.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_CAPTCHA_LinkClicked);
            // 
            // LinkLabel_ForgetPassword
            // 
            this.LinkLabel_ForgetPassword.AutoSize = true;
            this.LinkLabel_ForgetPassword.Location = new System.Drawing.Point(375, 231);
            this.LinkLabel_ForgetPassword.Name = "LinkLabel_ForgetPassword";
            this.LinkLabel_ForgetPassword.Size = new System.Drawing.Size(69, 20);
            this.LinkLabel_ForgetPassword.TabIndex = 9;
            this.LinkLabel_ForgetPassword.TabStop = true;
            this.LinkLabel_ForgetPassword.Text = "忘记密码";
            this.LinkLabel_ForgetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_ForgetPassword_LinkClicked);
            // 
            // Label_ConnState
            // 
            this.Label_ConnState.AutoSize = true;
            this.Label_ConnState.Location = new System.Drawing.Point(6, 277);
            this.Label_ConnState.Name = "Label_ConnState";
            this.Label_ConnState.Size = new System.Drawing.Size(81, 20);
            this.Label_ConnState.TabIndex = 11;
            this.Label_ConnState.Text = "等待连接...";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.Button_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 299);
            this.Controls.Add(this.Label_ConnState);
            this.Controls.Add(this.LinkLabel_ForgetPassword);
            this.Controls.Add(this.LinkLabel_CAPTCHA);
            this.Controls.Add(this.TextBox_CAPTCHA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Button_Regist);
            this.Controls.Add(this.Button_Login);
            this.Controls.Add(this.RadioButton_User);
            this.Controls.Add(this.RadioButton_Admin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBox_UserPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox_UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书管理系统 - 登录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_UserName;
        private System.Windows.Forms.TextBox TextBox_UserPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RadioButton_Admin;
        private System.Windows.Forms.RadioButton RadioButton_User;
        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.Button Button_Regist;
        private System.Windows.Forms.TextBox TextBox_CAPTCHA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel LinkLabel_CAPTCHA;
        private System.Windows.Forms.LinkLabel LinkLabel_ForgetPassword;
        private System.Windows.Forms.ToolTip ToolTip_Main;
        private System.Windows.Forms.Label Label_ConnState;
    }
}

