using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AtchleyGameCenter.Models
{
    public enum Sex
    {
        Male, Female
    }
    public class Player
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Sex Sex { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        public DateTime Birthday { get; set; }

        public virtual ICollection<Signup> Signups { get; set; }
    }
}