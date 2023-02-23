using System.ComponentModel.DataAnnotations;

namespace SSM.Models
{
    public class User_role
    {
        public int user_id {get; set;}
        [Key]
        public int role_id { get; set;}
    }
}
