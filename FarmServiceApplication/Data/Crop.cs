using System.ComponentModel.DataAnnotations.Schema;

namespace FarmServiceApplication.Data
{
    [Table("Crop")]
    public class Crop
    {
        public int CropId { get; set; }
        [ForeignKey(nameof(FarmId))]                    
        public int FarmId { get; set; } 
        public string CropName { get; set;}
        public DateTime PlantingDate { get; set; }
        public DateTime HervestDate { get; set; }       
    }
}
