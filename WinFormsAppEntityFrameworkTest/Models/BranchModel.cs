using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppEntityFrameworkTest
{
    public class BranchModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public int id_main_branch { get; set; }
        public string address { get; set; }
        public string website { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public int mobile { get; set; }
    }
}
