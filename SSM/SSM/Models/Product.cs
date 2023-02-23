using System.ComponentModel.DataAnnotations;

namespace SSM.Models
{
    public class Product
    {
        [ Key]
        public int id { get; set; }
        public string description { get; set; }
        public string image_name { get; set; }

        public string name { get; set; }
        public decimal price { get; set; }
        
        public int catogory_id { get; set; }
    }
}
