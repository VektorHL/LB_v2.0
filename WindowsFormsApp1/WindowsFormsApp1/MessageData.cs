using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class MessageData
    {
        public string M_OperationType { get; set; }
        public string M_login { get; set; }
        public string M_password { get; set; }
        public string M_memberName { get; set; }
        public List<string[]> data { get; set; }  /* = new List<string[]>()*/
    }
}
