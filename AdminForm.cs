using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookMS
{
    public partial class AdminForm : Form
    {
        public static Action updateDataGridView;


        //构造函数
        public AdminForm()
        {
            InitializeComponent();
            ComboBox_QueryBuilder.SelectedIndex = 0; // 选定的行
            DataGridView_BookList.BackgroundColor = Color.White;// 背景颜色
            DataGridView_BookList.AllowUserToAddRows = false; //添加行
            DataGridView_BookList.ReadOnly = true; //只读
            DataGridView_BookList.MultiSelect = false; //多选择
            DataGridView_BookList.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // 选择模式
            DataGridView_BookList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //自动宽度
            this.Text += "(" + LoginForm.user + ")";
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <returns>无返回</returns>
        private void AdminForm_Load(object sender, EventArgs e)
        {
            updateDataGridView = QueryAllBook;
            QueryAllBook();
        }
        /// <summary>
        /// 窗体关闭事件
        /// </summary>
        /// <returns>无返回</returns>
        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm.showForm();
        }
        /// <summary>
        /// 查询所有图书
        /// </summary>
        /// <returns>无返回</returns>
        private void QueryAllBook()
        {
            string sqlStr = $"select * from Book_List";
            // 把DataGridView的数据源绑定到DataSet上的第一个表中
            DataGridView_BookList.DataSource = SqlHelper.ExcuteDataSet(sqlStr).Tables[0];

            // 设置表格上显示的列标题
            DataGridView_BookList.Columns[0].HeaderText = "序号";
            DataGridView_BookList.Columns[1].HeaderText = "书号";
            DataGridView_BookList.Columns[2].HeaderText = "书名";
            DataGridView_BookList.Columns[3].HeaderText = "作者";
            DataGridView_BookList.Columns[4].HeaderText = "出版社";
            DataGridView_BookList.Columns[5].HeaderText = "库存";
        }


        /// <summary>
        /// 查询点击事件
        /// </summary>
        /// <returns>无返回</returns>
        private void Button_Query_Click(object sender, EventArgs e)
        {
            string str1 = string.Empty;
            
            switch (ComboBox_QueryBuilder.Text)
            {
                case "书号":
                    str1 = "ISBN";
                    break;
                case "书名":
                    str1 = "BookName";
                    break;
                case "作者":
                    str1 = "BookAuthor";
                    break;
                case "出版社":
                    str1 = "Publisher";
                    break;
                default:
                    str1 = "";
                    break;
            }
            //如果TextBox_QueryText内容为空
            if (string.IsNullOrEmpty(TextBox_QueryText.Text))
            {
                QueryAllBook();
            }
            else if (!string.IsNullOrEmpty(str1))
            {
                string sqlStr = $"select * from Book_List where {str1} like N'%{TextBox_QueryText.Text}%'";

                DataGridView_BookList.DataSource = SqlHelper.ExcuteDataSet(sqlStr).Tables[0];

                // 设置表格上显示的列标题
                DataGridView_BookList.Columns[0].HeaderText = "序号";
                DataGridView_BookList.Columns[1].HeaderText = "书号";
                DataGridView_BookList.Columns[2].HeaderText = "书名";
                DataGridView_BookList.Columns[3].HeaderText = "作者";
                DataGridView_BookList.Columns[4].HeaderText = "出版社";
                DataGridView_BookList.Columns[5].HeaderText = "库存";
            }
        }

        /// <summary>
        /// 添加图书
        /// </summary>
        /// <returns>无返回</returns>
        private void Button_Add_Click(object sender, EventArgs e)
        {
            AdminAddForm adminAddForm = new AdminAddForm();
            adminAddForm.ShowDialog();
        }

        /// <summary>
        /// 修改图书
        /// </summary>
        /// <returns>无返回</returns>
        private void Button_Edit_Click(object sender, EventArgs e)
        {
            int selectCount = DataGridView_BookList.SelectedRows.Count;
            if (selectCount != 0)
            {
                string id = DataGridView_BookList.SelectedRows[0].Cells[0].Value.ToString();
                string ISBN = DataGridView_BookList.SelectedRows[0].Cells[1].Value.ToString();
                string BookName = DataGridView_BookList.SelectedRows[0].Cells[2].Value.ToString();
                string BookAuthor = DataGridView_BookList.SelectedRows[0].Cells[3].Value.ToString();
                string Publisher = DataGridView_BookList.SelectedRows[0].Cells[4].Value.ToString();
                string Store = DataGridView_BookList.SelectedRows[0].Cells[5].Value.ToString();

                AdminEditForm adminEditForm = new AdminEditForm(id, ISBN, BookName, BookAuthor, Publisher, Store);
                adminEditForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选择正确的数据", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 删除图书
        /// </summary>
        /// <returns>无返回</returns>
        private void Button_Delete_Click(object sender, EventArgs e)
        {
            int selectCount = DataGridView_BookList.SelectedRows.Count;
            if (selectCount != 0)
            {
                if (MessageBox.Show("你确认要删除当前选中行吗？此操作不可回退", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    int id = int.Parse(DataGridView_BookList.SelectedRows[0].Cells[0].Value.ToString());

                    string sqlStr = $"delete from Book_List where id={id}";

                    int result = SqlHelper.ExecuteNonQuery(sqlStr);
                    if (result != 0)
                    {
                        MessageBox.Show("删除成功", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        QueryAllBook();
                    }
                    else
                    {
                        MessageBox.Show("删除失败", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择正确的数据", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 取消点击事件
        /// </summary>
        /// <returns>无返回</returns>
        private void Button_Refresh__Click(object sender, EventArgs e)
        {
            QueryAllBook();

        }
        private void 注销登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm.showForm();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("版本v1.0", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

 

        private void 借书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectCount = DataGridView_BookList.SelectedRows.Count;
            if (selectCount != 0)
            {
                string id = DataGridView_BookList.SelectedRows[0].Cells[0].Value.ToString();
                string ISBN = DataGridView_BookList.SelectedRows[0].Cells[1].Value.ToString();
                string BookName = DataGridView_BookList.SelectedRows[0].Cells[2].Value.ToString();
                string BookAuthor = DataGridView_BookList.SelectedRows[0].Cells[3].Value.ToString();
                string Publisher = DataGridView_BookList.SelectedRows[0].Cells[4].Value.ToString();
                string Store = DataGridView_BookList.SelectedRows[0].Cells[5].Value.ToString();

                BorrowBookForm borrowBookForm = new BorrowBookForm(id, ISBN, BookName, BookAuthor, Publisher, Store);
                borrowBookForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选择正确的数据", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 还书ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ReturnBookForm returnBookForm = new ReturnBookForm();
            returnBookForm.ShowDialog();
        }


    }
}
