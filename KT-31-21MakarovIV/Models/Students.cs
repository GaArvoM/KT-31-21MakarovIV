namespace KT_31_21MakarovIV.Models
{
    public class Students
    {
        public int StudentId { get; set; } 
        public string LastName { get; set; }
        public int FirstName { get; set; }
        public string MiddleName { get; set; } 
        public int GroupId { get; set; }
        public Groups Group { get; set; }
    }
}
