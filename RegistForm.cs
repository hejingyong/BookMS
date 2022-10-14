using System;
using System.Windows.Forms;

namespace BookMS
{
    public partial class RegistForm : Form
    {
        private string LoginCAPTCHA;

        //构造函数 
        public RegistForm()
        {
            InitializeComponent();
            UpdateCAPTCHA();
        }

        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <returns>无返回</returns>
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 验证码更新
        /// </summary>
        /// <returns>无返回</returns>
        private void UpdateCAPTCHA()
        {
            LoginCAPTCHA = Guid.NewGuid().ToString().Substring(0, 5).ToLower();
            LinkLabel_CAPTCHA.Text = LoginCAPTCHA;
        }
        /// <summary>
        /// 注册点击事件
        /// </summary>
        /// <returns>无返回</returns>
        private void Button_Regist_Click(object sender, EventArgs e)
        {
            //用户名，密码，第二次密码，验证码
            string user_name = TextBox_UserName.Text.Trim();
            string user_password = TextBox_UserPassword.Text.Trim();
            string user_password2 = TextBox_UserPassword2.Text.Trim();
            string CAPTCHA = TextBox_CAPTCHA.Text.Trim();

            //用户密码为空
            if (string.IsNullOrEmpty(user_name) || string.IsNullOrEmpty(user_password))
            {
                MessageBox.Show("用户名或密码为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateCAPTCHA();
                return;
            }
            //两次密码不一致
            if (!user_password.Equals(user_password2))
            {
                MessageBox.Show("两次输入密码不一致", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateCAPTCHA();
                return;
            }
            //验证码为空
            if (string.IsNullOrEmpty(CAPTCHA))
            {
                MessageBox.Show("请输入验证码", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateCAPTCHA();
                return;
            }
            //验证码不匹配
            if (!CAPTCHA.Equals(LoginCAPTCHA))
            {
                MessageBox.Show("验证码输入错误", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateCAPTCHA();
                return;
            }

            string sqlStr0 = $"select * from Login_Admin where Name=N'{user_name}'";

            if (RadioButton_User.Checked == true)
            {
                sqlStr0 = $"select * from Login_User where Name=N'{user_name}'";
            }
            //用户名存在
            object result0 = SqlHelper.ExecuteScalar(sqlStr0);
            if (result0 != null && (int)result0 != 0)
            {
                MessageBox.Show("用户名已存在", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateCAPTCHA();

                return;
            }

            //////////////////////////////////////////
            user_password = MD5Utils.Md5Hex(user_password);

            string sqlStr = $"insert into Login_Admin (Name, Password) values (N'{user_name}', '{user_password}')";
            if (RadioButton_User.Checked == true)
            {
                sqlStr = $"insert into Login_User (Name, Password) values (N'{user_name}', '{user_password}')";
            }

            int result = SqlHelper.ExecuteNonQuery(sqlStr);
            if (result != -1 && result != 0)
            {
                MessageBox.Show("注册成功", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("注册失败，请检查填写内容", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateCAPTCHA();
            }
        }
    }
}
