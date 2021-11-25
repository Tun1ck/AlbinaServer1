using Albina.DataAccess.Core.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Albina.DataAccess.Core.Models
{
    [Table("AcceptExpense")]
    public class AcceptExpenseRto
    {
        [Key] public int Id { get; set; }

        public int? USerId { get; set; }
        public UserRto User { get; set; }
        public string WhereSpend { get; set; }
        public float Cost { get; set; }
        public CostCurrencyRto CostCurrency { get; set; }

        public DateTimeOffset CreateDateTime { get; set; }
        public DateTimeOffset RejectDateTime { get; set; }
    }
}
