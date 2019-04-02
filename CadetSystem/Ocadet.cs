using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadetSystem
{
    public class Ocadet
    {
        public int Id { get; set; }
        public int Userid { get; set; }
        public string Name { get; set; }        
        public string Password { get; set; }
        public string Emailaddress { get; set; }
        public int Intake{ get; set; }
        public bool Userstatus { get; set; }
        public string TodayDate { get; set; }

    }
}

