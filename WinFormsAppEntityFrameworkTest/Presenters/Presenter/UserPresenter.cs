using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppEntityFrameworkTest.Views.Interface;

namespace WinFormsAppEntityFrameworkTest.Presenters.User
{
    public class UserPresenter
    {
        IUser interfaceUser;
        UserModel userModel = new UserModel();

        public UserPresenter(IUser view)
        {
            this.interfaceUser = view;
        }
        private void connectBetweenModelInterface()
        {
            userModel.id = interfaceUser.id;
            userModel.code = interfaceUser.code;
            userModel.name = interfaceUser.name;
            userModel.email = interfaceUser.email;
            userModel.password = interfaceUser.password;
            userModel.branch_id = interfaceUser.branch_id;
            userModel.role = interfaceUser.role;
            userModel.first_name = interfaceUser.first_name;
            userModel.middle_name = interfaceUser.middle_name;
            userModel.last_name = interfaceUser.last_name;
            userModel.phone = interfaceUser.phone;
            userModel.mobile = interfaceUser.mobile;
            userModel.national_number = interfaceUser.national_number;
            userModel.notes = interfaceUser.notes;
            userModel.active = interfaceUser.active;
        }

        public void insert()
        {
            connectBetweenModelInterface();
            UserService.insert(userModel);
        }
        public void update()
        {
            connectBetweenModelInterface();
            UserService.update(userModel);
        }
        public void delete()
        {
            connectBetweenModelInterface();
            UserService.delete(userModel);
        }
        public void clearFields()
        {
            connectBetweenModelInterface();
            interfaceUser.id =0 ;
            interfaceUser.name = "";

        }

    }
}
