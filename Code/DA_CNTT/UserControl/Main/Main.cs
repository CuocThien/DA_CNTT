using DA_CNTT.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_CNTT
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            CUsers cUsers = new CUsers();
            var users = cUsers.findAll();
            var user = users.Where(u => u.Username == txt_Username.Text.Trim()).SingleOrDefault();
            if(!(user is null) && user.Password==txt_Password.Text.Trim())
            {
                
                var isAdmin = user.isAdmin;
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                Form1 frm = new Form1(isAdmin);
                frm.Show();

            }    
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }    
        }
    }
}
