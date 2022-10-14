using System;
using System.Windows.Forms;

namespace BookMS
{
    public partial class AdminAddForm : Form
    {
        private string AddCAPTCHA;

        //构造函数
        public AdminAddForm()
        {
            InitializeComponent();
            UpdateCAPTCHA();
        }
        /// <summary>
        /// 验证码更新
        /// </summary>
        /// <returns>无返回</returns>
        private void UpdateCAPTCHA()
        {
            AddCAPTCHA = Guid.NewGuid().ToString().Substring(0, 5).ToLower();
            LinkLabel_CAPTCHA.Text = AddCAPTCHA;
        }

        /// <summary>
        /// 清理编辑框
        /// </summary>
        /// <returns>无返回</returns>
        private void ClearTextBox()
        {
            TextBox_ISBN.Clear();
            TextBox_BookName.Clear();
            TextBox_BookAuthor.Clear();
            TextBox_Publisher.Clear();
            TextBox_Store.Clear();
            TextBox_CAPTCHA.Clear();
        }
        /// <summary>
        /// 添加点击事件
        /// </summary>
        /// <returns>无返回</returns>
        private void Button_Add_Click(object sender, EventArgs e)
        {
            string ISBN = TextBox_ISBN.Text.Trim();
            string BookName = TextBox_BookName.Text.Trim();
            string BookAuthor = TextBox_BookAuthor.Text.Trim();
            string Publisher = TextBox_Publisher.Text.Trim();
            string Store = TextBox_Store.Text.Trim();

            string CAPTCHA = TextBox_CAPTCHA.Text.Trim();

            if (string.IsNullOrEmpty(ISBN) ||
                string.IsNullOrEmpty(BookName) ||
                string.IsNullOrEmpty(BookAuthor) ||
                string.IsNullOrEmpty(Publisher) ||
                string.IsNullOrEmpty(Store))
            {
                MessageBox.Show("存在空数据，请检查后再添加", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateCAPTCHA();
                return;
            }

            if (string.IsNullOrEmpty(CAPTCHA))
            {
                MessageBox.Show("请输入验证码", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateCAPTCHA();
                return;
            }

            if (!CAPTCHA.Equals(AddCAPTCHA))
            {
                MessageBox.Show("验证码输入错误", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateCAPTCHA();
                return;
            }

            string sqlStr = $"insert into Book_List (ISBN,BookName,BookAuthor,Publisher,Store) values ('{ISBN}',N'{BookName}',N'{BookAuthor}',N'{Publisher}',{int.Parse(Store)})";

            int reslut = SqlHelper.ExecuteNonQuery(sqlStr);
            if (reslut == 1)
            {
                // 更新数据
                AdminForm.updateDataGridView();

                MessageBox.Show("添加图书信息成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UpdateCAPTCHA();
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("添加图书信息失败", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateCAPTCHA();
            }
        }
        /// <summary>
        /// 取消点击事件
        /// </summary>
        /// <returns>无返回</returns>
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
