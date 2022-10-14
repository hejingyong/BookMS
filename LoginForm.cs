using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookMS
{
    public partial class LoginForm : Form
    {
        public static Action showForm;
        public static string user;
        public static bool isAdmin = true;
        private string LoginCAPTCHA;
        
        //构造函数
        public LoginForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 显示窗体
        /// </summary>
        /// <returns>无返回</returns>
        private void ShowLoginForm()
        {
            this.Show();
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <returns>无返回</returns>
        private void LoginForm_Load(object sender, EventArgs e)
        {
            showForm = ShowLoginForm;
            UpdateCAPTCHA();
            int result = (int)SqlHelper.ExecuteScalar("select 1");
            if (result == 1)
            {
                Label_ConnState.Text = "数据库连接成功";
            }
            else
            {
                this.Close();
            }
            //单选按钮选择
            if(RadioButton_Admin.Checked == true)
            {
                RadioButton_Admin_CheckedChanged(sender, e);
                

            }
            else if (RadioButton_User.Checked == true)
            {
                
                RadioButton_User_CheckedChanged(sender, e);
            }
        }
        /// <summary>
        /// 窗体关闭事件
        /// </summary>
        /// <returns>无返回</returns>
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 清空全部连接池
            SqlConnection.ClearAllPools();
        }

        /// <summary>
        /// 验证码更新
        /// </summary>
        /// <returns>无返回</returns>
        private void UpdateCAPTCHA()
        {
            LoginCAPTCHA = Guid.NewGuid().ToString().Substring(0, 5).ToLower();
            LinkLabel_CAPTCHA.Text = LoginCAPTCHA;
            TextBox_CAPTCHA.Text = LoginCAPTCHA;

        }
        /// <summary>
        /// 超级链接被点击
        /// </summary>
        /// <returns>无返回</returns>
        /// 
        private void LinkLabel_CAPTCHA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdateCAPTCHA();
        }
         /// <summary>
        /// 登录按钮
        /// </summary>
        /// <returns>无返回</returns>
        private void Button_Login_Click(object sender, EventArgs e)
        {
       
            //获取用户名，密码，验证码
            string user_name = TextBox_UserName.Text.Trim();
            user = user_name;
            string user_password = TextBox_UserPassword.Text.Trim();
            string CAPTCHA = TextBox_CAPTCHA.Text.Trim();
            //用户名或密码为空
            if (string.IsNullOrEmpty(user_name) || string.IsNullOrEmpty(user_password))
            {
                MessageBox.Show("用户名或密码为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            user_password = MD5Utils.Md5Hex(user_password);
           //查询管理员表
           string sqlStr = $"select * from Login_Admin where Name='{user_name}' and Password='{user_password}'";
            bool isAdmin = true;
 

            if (RadioButton_User.Checked == true)
            {
                //查询普通用户表
                sqlStr = $"select * from Login_User where Name='{user_name}' and Password='{user_password}'";
                isAdmin = false;
            
            }

            object result = SqlHelper.ExecuteScalar(sqlStr);
            if (result != null && (int)result != 0)
            {
                MessageBox.Show("登陆成功", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //判断普通用户还是管理员
                if (isAdmin) 

                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    UserForm userForm = new UserForm();
                    userForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("登陆失败，用户名或密码错误", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateCAPTCHA();
            }
        }
        /// <summary>
        /// 注册点击事件
        /// </summary>
        /// <returns>无返回</returns>
        private void Button_Regist_Click(object sender, EventArgs e)
        {
            RegistForm registForm = new RegistForm();
            registForm.ShowDialog();
        }
        /// <summary>
        /// 忘记密码点击事件
        /// </summary>
        /// <returns>无返回</returns>
        private void LinkLabel_ForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("请与管理员联系", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        /// <summary>
        /// 管理员单选按钮点击事件
        /// </summary>
        /// <returns>无返回</returns>
        private void RadioButton_Admin_CheckedChanged(object sender, EventArgs e)
        {
            TextBox_UserName.Text = "admin";
            TextBox_UserPassword.Text = "admin";
            TextBox_CAPTCHA.Text = LoginCAPTCHA;
            isAdmin = true;
        }
        /// <summary>
        /// 普通用户单选按钮点击事件
        /// </summary>
        /// <returns>无返回</returns>
        private void RadioButton_User_CheckedChanged(object sender, EventArgs e)
        {
            TextBox_UserName.Text = "user001";
            TextBox_UserPassword.Text = "user001";
            TextBox_CAPTCHA.Text = LoginCAPTCHA;
            isAdmin = false;
        }
    }
}
