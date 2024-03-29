﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculatorEntities
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
        public bool IsAdmin { get; set; }
        public byte[]? Photo { get; set; }

        //Navigation
        public virtual ICollection<Meal> Meals { get; set; }
        public User()
        {
            Meals = new List<Meal>();
        }
    }
}
