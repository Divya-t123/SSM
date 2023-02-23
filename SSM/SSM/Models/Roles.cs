using System.ComponentModel.DataAnnotations;

namespace SSM.Models
{
    public class Roles
    {
        [Key]
        public int role_id { get; set; }
        public string name { get; set; }
    }
}
