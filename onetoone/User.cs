﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onetoone
{
    class User
    {
        public int Id { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }
        public UserProfile Profile { get; set; }
    }
}
