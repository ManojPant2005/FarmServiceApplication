using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace FarmServiceApplication.Data
{
    [Table("Farm")]
    public class Farm
    {
        [Key]
        public int FarmId { get; set; }     
        public string FarmName { get; set; }
        public string Location { get; set; }    
        public string Size { get; set; } 
    }
}
