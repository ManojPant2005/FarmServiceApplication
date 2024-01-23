using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmServiceApplication.Data
{
    [Table("Expense")]
    public class Expense
    {
        [Key]
        public int ExpensesId { get; set; }
        [ForeignKey(nameof(FarmId))]        
        public string FarmId { get; set; }    
        public string ExpensesType { get; set; }    
        public int ExpensesAmount { get; set; } 
        public DateTime ExpensesDate { get; set; }  

    }
}
