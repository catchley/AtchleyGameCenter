using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AtchleyGameCenter.Models
{

    //  New Enum for choosing the gender of the player
    public enum Sex
    {
        Male, Female
    }
    public class Player
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }


        //Formatting to display the email address
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //gender property for the player
        public Sex Sex { get; set; }

        //property determining whether the player is a member
        public bool Member { get; set; }

        //Formatting for displaying the date for birthdate
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        public DateTime Birthday { get; set; }

        public virtual ICollection<Signup> Signups { get; set; }
    }
}