﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UtilLibrary.MsSqlRepsoitory
{
    public class Visitor
    {
        public int VisitorsID {get; set;}
        public string IdentityNo {get; set;}
        public string Firstname {get; set;}
        public string Lastname {get; set;} 
        public DateTime JoinDate {get; set;}
        public string Password {get; set;}
        public bool Banned {get; set;}

    }

}
