using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtchleyGameCenter.Models
{
    public class Game
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GameID { get; set; }
        public string Title { get; set; }
        public int Difficulty { get; set; }

        public virtual ICollection<Signup> Signups { get; set; }
    }
}