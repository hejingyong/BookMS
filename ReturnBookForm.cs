using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookMS
{
    public partial class ReturnBookForm : Form
    {

        public static Action updateDataGridView;
        //构造函数
        public ReturnBookForm()
        {
            InitializeComponent();
            ComboBox_QueryBuilder.SelectedIndex = 0;
            DataGridView_BookList.BackgroundColor = Color.White;
            DataGridView_BookList.AllowUserToAddRows = false;
            DataGridView_BookList.ReadOnly = true;
            DataGridView_BookList.MultiSelect = false;
            DataGridView_BookList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView_BookList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        /// <summary>
        /// 查询点击事件
        /// </summary>
        /// <returns>无返回</returns>
        private void ReturnBookForm_Load(object sender, EventArgs e)
        {
            updateDataGridView = QueryAllBook;
            QueryAllBook();
        }
        /// <summary>
        /// 查询所有借书表记录
        /// </summary>
        /// <returns>无返回</returns>
        private void QueryAllBook()
        {
            string sqlStr = $"select * from Borrow_Book where name = N'{LoginForm.user}'";

            // 把DataGridView的数据源绑定到DataSet上的第一个表中
            DataGridView_BookList.DataSource = SqlHelper.ExcuteDataSet(sqlStr).Tables[0];

            // 设置表格上显示的列标题
            DataGridView_BookList.Columns[0].HeaderText = "序号";
            DataGridView_BookList.Columns[1].HeaderText = "用户";
            DataGridView_BookList.Columns[2].HeaderText = "书号";
            DataGridView_BookList.Columns[3].HeaderText = "书名";
            DataGridView_BookList.Columns[4].HeaderText = "数量";
            DataGridView_BookList.Columns[5].HeaderText = "借书日期";
            DataGridView_BookList.Columns[6].HeaderText = "还书日期";

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
                case "数量":
                    str1 = "BookQuantity";
                    break;
                case "借书日期":
                    str1 = "BTime";
                    break;
                case "还书日期":
                    str1 = "RTime";
                    break;
                default:
                    str1 = "";
                    break;
            }

            if (string.IsNullOrEmpty(TextBox_QueryText.Text))
            {
                QueryAllBook();
            }
            else if (!string.IsNullOrEmpty(str1))
            {
                string sqlStr = $"select * from Borrow_Book where {str1} like N'%{TextBox_QueryText.Text}%' and name = N'{LoginForm.user}'";

                DataGridView_BookList.DataSource = SqlHelper.ExcuteDataSet(sqlStr).Tables[0];
                // 设置表格上显示的列标题
                DataGridView_BookList.Columns[0].HeaderText = "序号";
                DataGridView_BookList.Columns[1].HeaderText = "用户";
                DataGridView_BookList.Columns[2].HeaderText = "书号";
                DataGridView_BookList.Columns[3].HeaderText = "书名";
                DataGridView_BookList.Columns[4].HeaderText = "数量";
                DataGridView_BookList.Columns[5].HeaderText = "借书日期";
                DataGridView_BookList.Columns[6].HeaderText = "还书日期";
            }
        }

 
        /// <summary>
        /// 确认点击事件
        /// </summary>
        /// <returns>无返回</returns>
        private void button_certain_Click(object sender, EventArgs e)
        {
            int selectCount = DataGridView_BookList.SelectedRows.Count;
            if (selectCount != 0)
            {
                string id = DataGridView_BookList.SelectedRows[0].Cells[0].Value.ToString();
                string user = DataGridView_BookList.SelectedRows[0].Cells[1].Value.ToString();
                string ISBN = DataGridView_BookList.SelectedRows[0].Cells[2].Value.ToString();
                string BookName = DataGridView_BookList.SelectedRows[0].Cells[3].Value.ToString();
                string BookQuantity = DataGridView_BookList.SelectedRows[0].Cells[4].Value.ToString();
                string BTime = DataGridView_BookList.SelectedRows[0].Cells[5].Value.ToString();
                string Rtime = DataGridView_BookList.SelectedRows[0].Cells[6].Value.ToString();

                ReturnBookOptions returnBookOptions  = new ReturnBookOptions(id, user,ISBN , BookName, BookQuantity, BTime,Rtime);
                returnBookOptions.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选择正确的数据", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
