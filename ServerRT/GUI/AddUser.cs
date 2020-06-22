using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ServerRT.GUI
{
    public partial class AddUser : DevExpress.XtraEditors.XtraForm
    {
        public AddUser()
        {
            InitializeComponent();
        }

        //public Boolean CheckUserCreated(string name)
        //{
        //    foreach (var item in listUser)
        //    {
        //        if (item.name == tbUserName.Text)
        //            return false;
        //    }
        //    return true;
        //}
        //private void btnCreateUser_Click(object sender, EventArgs e)
        //{
        //    if ((tbUserName.Text == "" && tbPassword.Text == "") || tbUserName.Text == "" || tbPassword.Text == "")
        //    {
        //        MessageBox.Show("Tai khoan hoac mat khau trong!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    else if (CheckUserCreated(tbUserName.Text) == false)
        //    {
        //        MessageBox.Show("Ten tai khoan da duoc dang ky!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    else
        //    {
        //        listUser.Add(new User(tbUserName.Text, tbPassword.Text));
        //        setDataListView();
        //        tbUserName.Clear();
        //        tbPassword.Clear();
        //        MessageBox.Show("Dang ky tai khoan Client thanh cong!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    }
        //}
    }
}