using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Albina.DataAccess.Core.Models
{
    [Table("VirtualExpense")]
    class VirtualExpenseRto
    {
        [Key] public int Id { get; set; }

        public int MyProperty { get; set; }
    }
}
