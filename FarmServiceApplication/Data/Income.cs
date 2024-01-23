using System.ComponentModel.DataAnnotations.Schema;

namespace FarmServiceApplication.Data
{
    [Table("Income")]
    public class Income
    {
        public int IncomeId { get; set; }
        [ForeignKey(nameof(FarmId))]        
        public int FarmId { get; set; } 
        public string IncomeType { get; set; }  
        public decimal IncomeAmount { get; set; }   
        public DateTime IncomeDate { get; set; }    
    }
}
