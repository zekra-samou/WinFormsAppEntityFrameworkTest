using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppEntityFrameworkTest
{
    public class UserModel 
    {

        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public int branch_id { get; set; }
        public string photo { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public int phone { get; set; }
        public int mobile { get; set; }
        public int national_number { get; set; }
        public string notes { get; set; }
        public bool active { get; set; }


    }
}
