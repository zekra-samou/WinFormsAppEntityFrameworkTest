using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppEntityFrameworkTest.Presenters.User;
using WinFormsAppEntityFrameworkTest.Views.Interface;

namespace WinFormsAppEntityFrameworkTest
{
    public partial class FormAddUser : Form ,IUser
    {
        #region ImplementInterface
        public int id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string code { get => Convert.ToString(txtCode.Text); set => txtCode.Text=value.ToString(); }
        public string name { get => Convert.ToString(txtUsername); set => txtUsername.Text=value.ToString(); }
        public string email { get => Convert.ToString(txtEmail); set => txtEmail.Text=value.ToString(); }
        public string password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string role { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int branch_id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string photo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string first_name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string middle_name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string last_name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int phone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int mobile { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int national_number { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string notes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool active { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object dataGridView { get => ; set => throw new NotImplementedException(); }
        #endregion
        UserPresenter userPresenter;
        public FormAddUser()
        {
            InitializeComponent();
            userPresenter = new UserPresenter(this);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            userPresenter.insert();
            userPresenter.clearFields();
        }
    }
}
