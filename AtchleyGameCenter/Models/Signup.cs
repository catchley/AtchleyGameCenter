namespace AtchleyGameCenter.Models
{
    public enum Rating
    {
        A ,B, C, D, F
    }

    public class Signup
    {
        public int SignupID { get; set; }
        public int GameID { get; set; }
        public int PlayerID { get; set; }
        public Rating? Rating { get; set; }

        public virtual Game Game { get; set; }
        public virtual Player Player { get; set; }
    }
}