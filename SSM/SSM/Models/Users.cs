using System.ComponentModel.DataAnnotations;

namespace SSM.Models
{
    public class Users
    {
        [Key]
        public int id { get; set; }
        public String email { get; set; }
        public String first_name { get; set; }
        public String last_name { get; set; }
        public String password { get; set; }
    }
}
