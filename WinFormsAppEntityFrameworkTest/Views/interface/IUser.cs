using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppEntityFrameworkTest.Views.Interface
{
    public interface IUser
    {
         int id { get; set; }
         string code { get; set; }
         string name { get; set; }
         string email { get; set; }
         string password { get; set; }
         string role { get; set; }
         int branch_id { get; set; }
         string photo { get; set; }
         string first_name { get; set; }
         string middle_name { get; set; }
         string last_name { get; set; }
         int phone { get; set; }
         int mobile { get; set; }
         int national_number { get; set; }
         string notes { get; set; }
         bool active { get; set; }
        object dataGridView { get; set; }
    }
}
