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
    public partial class ReturnBookOptions : Form
    {
        private int id;
        private string user;
        private string iSBN;
        private string bookName;
        private int bookQuantity;
        private string bTime;
        private string rtime;
        //构造函数
        public ReturnBookOptions(string id, string user, string iSBN, string bookName, string bookQuantity, string bTime, string rtime)
        {
            InitializeComponent();
            this.id = int.Parse(id);
            this.user = user;
            this.iSBN = iSBN;
            this.bookName = bookName;
            this.bookQuantity = int.Parse(bookQuantity);
            this.bTime = bTime;
            this.rtime = rtime;
            TextBox_ID.Text = id;
            TextBox_ISBN.Text = iSBN;
            TextBox_BookName.Text = bookName;
        }

        /// <summary>
        /// 取消点击事件
        /// </summary>
        /// <returns>无返回</returns>
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 还书点击事件
        /// </summary>
        /// <returns>无返回</returns>
        private void Button_Edit_Click(object sender, EventArgs e)
        {
            string ID = TextBox_ID.Text.Trim();
            string ISBN = TextBox_ISBN.Text.Trim();
            string BookName = TextBox_BookName.Text.Trim();
            string InBookQuantity = TextBox_BookQuantity.Text.Trim();
            if (
                string.IsNullOrEmpty(ID)||
                string.IsNullOrEmpty(ISBN) ||
                string.IsNullOrEmpty(BookName) ||
                string.IsNullOrEmpty(InBookQuantity))
            {
                MessageBox.Show("存在空数据，请检查后再修改", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (bookQuantity >= int.Parse(InBookQuantity))
            {

                //修改库存
                string sqlStr1 = $"update Book_List set Store=Book_List.Store+{int.Parse(InBookQuantity)} where ISBN='{ISBN}'";
                //修改借书表
                string sqlStr2 = $"update Borrow_Book set Borrow_Book.BookQuantity = 'Borrow_Book.BookQuantity-{int.Parse(InBookQuantity)} where ID={int.Parse(ID)}"; 
                if (bookQuantity == int.Parse(InBookQuantity))//数量相同删除借书记录
                {
                     sqlStr2 = $"delete from Borrow_Book where ID={int.Parse(ID)}";

                }
                int reslut1 = SqlHelper.ExecuteNonQuery(sqlStr1);
                int reslut2 = SqlHelper.ExecuteNonQuery(sqlStr2);
                if (reslut1 != 0 && reslut2 !=0)
                {
                    // 更新数据
                    MessageBox.Show("还书成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (LoginForm.isAdmin == true)
                    {
                        AdminForm.updateDataGridView();
                    }
                    else
                    {
                        UserForm.updateDataGridView();
                    }
                    ReturnBookForm.updateDataGridView();
                   
                    this.Close();
                }
                else
                {
                    MessageBox.Show("还书失败", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("数量错误!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
