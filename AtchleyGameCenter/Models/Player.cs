﻿using System;
using System.Collections.Generic;

namespace AtchleyGameCenter.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime Birthday { get; set; }

        public virtual ICollection<Signup> Signups { get; set; }
    }
}