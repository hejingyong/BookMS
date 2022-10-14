using System;
using System.Windows.Forms;

namespace BookMS
{
    public partial class AdminEditForm : Form
    {
        private string EditCAPTCHA;

        private int ID;
        //构造函数
        public AdminEditForm(string id, string ISBN, string BookName, string BookAuthor, string Publisher, string Store)
        {
            InitializeComponent();
            this.ID = int.Parse(id);
            TextBox_ISBN.Text = ISBN;
            TextBox_BookName.Text = BookName;
            TextBox_BookAuthor.Text = BookAuthor;
            TextBox_Publisher.Text = Publisher;
            TextBox_Store.Text = Store;

            UpdateCAPTCHA();
        }
        /// <summary>
        /// 验证码更新
        /// </summary>
        /// <returns>无返回</returns>
        private void UpdateCAPTCHA()
        {
            EditCAPTCHA = Guid.NewGuid().ToString().Substring(0, 5).ToLower();
            LinkLabel_CAPTCHA.Text = EditCAPTCHA;
        }
        /// <summary>
        /// 修改点击事件
        /// </summary>
        /// <returns>无返回</returns>
        private void Button_Edit_Click(object sender, EventArgs e)
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
                MessageBox.Show("存在空数据，请检查后再修改", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateCAPTCHA();
                return;
            }

            if (string.IsNullOrEmpty(CAPTCHA))
            {
                MessageBox.Show("请输入验证码", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateCAPTCHA();
                return;
            }

            if (!CAPTCHA.Equals(EditCAPTCHA))
            {
                MessageBox.Show("验证码输入错误", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateCAPTCHA();
                return;
            }

            string sqlStr = $"update Book_List set ISBN='{ISBN}',BookName=N'{BookName}',BookAuthor=N'{BookAuthor}',Publisher=N'{Publisher}',Store='{Store}' where ID={ID}";

            int reslut = SqlHelper.ExecuteNonQuery(sqlStr);
            if (reslut == 1)
            {
                // 更新数据
                AdminForm.updateDataGridView();

                MessageBox.Show("修改图书信息成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UpdateCAPTCHA();
                this.Close();
            }
            else
            {
                MessageBox.Show("修改图书信息失败", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
