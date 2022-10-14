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
    public partial class BorrowBookForm : Form
    {
        private int id;
        private string iSBN;
        private string bookName;
        private string bookAuthor;
        private string publisher;
        private int store;
        
        //构造函数
        public BorrowBookForm(string id, string iSBN, string bookName, string bookAuthor, string publisher, string store)
        {
            InitializeComponent();
            this.id = int.Parse(id);
            this.iSBN = iSBN;
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.publisher = publisher;
            this.store = int.Parse(store);
            TextBox_ISBN.Text = iSBN;
            TextBox_BookName.Text = bookName;

        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <returns>无返回</returns>
        private void BorrowBookForm_Load(object sender, EventArgs e)
        {
            monthCalendar1.Hide();

        }
        /// <summary>
        /// 取消点击事件
        /// </summary>
        /// <returns>无返回</returns>
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool flag = true;
        /// <summary>
        /// 选择按钮点击事件
        /// </summary>
        /// <returns>无返回</returns>
        private void button_SelectDate1_Click(object sender, EventArgs e)
        {
            if(flag)
            {
                monthCalendar1.Show();
                button_SelectDate1.Text = "隐藏";
                flag = false;
            }
            else
            {
                monthCalendar1.Hide();
                button_SelectDate1.Text = "选择";
                flag = true;
            }
        }

        /// <summary>
        /// 日历点击事件
        /// </summary>
        /// <returns>无返回</returns>
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            TextBox_Rtime.Text = monthCalendar1.SelectionStart.ToShortDateString();
           
        }
        /// <summary>
        /// 借书点击事件
        /// </summary>
        /// <returns>无返回</returns>
        private void Button_Edit_Click(object sender, EventArgs e)
        {
            string ISBN = TextBox_ISBN.Text.Trim();
            string BookName = TextBox_BookName.Text.Trim();
            string BookQuantity = TextBox_BookQuantity.Text.Trim();
            string Rtime = TextBox_Rtime.Text.Trim();
            string Btime = DateTime.Now.ToShortDateString();

            if (string.IsNullOrEmpty(ISBN) ||
           string.IsNullOrEmpty(BookName) ||
           string.IsNullOrEmpty(BookQuantity) ||
           string.IsNullOrEmpty(Rtime) )
            {
                MessageBox.Show("存在空数据，请检查后再修改", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.Parse(BookQuantity) <= store)
            {
                string sqlStr1 = $"update Book_List set Store='{store - int.Parse(BookQuantity)}' where ID={id}";
                string sqlStr2 = $"insert into Borrow_Book (Name,ISBN,BookName,BookQuantity,BTime,RTime) values (N'{LoginForm.user}','{ISBN}',N'{BookName}',{int.Parse(BookQuantity)},'{Btime}','{Rtime}')";
                int reslut1 = SqlHelper.ExecuteNonQuery(sqlStr1);
                int reslut2 = SqlHelper.ExecuteNonQuery(sqlStr2);

                if (reslut1 == 1 && reslut2 == 1)
                {
                    // 更新数据

                    MessageBox.Show("借书成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(LoginForm.isAdmin == true)
                    {
                        AdminForm.updateDataGridView();
                    }
                    else
                    {

                        UserForm.updateDataGridView();
                    }
                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show("借书失败", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {

                MessageBox.Show("库存不足,借书失败", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        /// <summary>
        /// 取消点击事件
        /// </summary>
        /// <returns>无返回</returns>
        private void Button_Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
