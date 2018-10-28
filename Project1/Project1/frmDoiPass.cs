using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class frmDoiPass : Form
    {
        Main main = new Main();
        public frmDoiPass()
        {
            InitializeComponent();
        }
        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        private string _message1;
        public string Message1
        {
            get { return _message1; }
            set { _message1 = value; }
        }
        private void frmDoiPass_Load(object sender, EventArgs e)
        {
            lblTK.Text =_message;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_message1);
            if (txtPass.Text.Trim().Equals("") || txtNewPass.Text.Trim().Equals("") || txtConfirm.Text.Trim().Equals(""))
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtPass.Text.Trim().Equals(_message1))
            {
                if (txtNewPass.Text.Trim().Equals(txtConfirm.Text.Trim()))
                {
                    main.DoiPass(_message, txtNewPass.Text.Trim());                   
                }
                else MessageBox.Show("Xác nhận mật khẩu mới không đúng !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Mật khẩu cũ không đúng !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
