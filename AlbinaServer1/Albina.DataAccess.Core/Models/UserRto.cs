

using System.ComponentModel.DataAnnotations.Schema;

namespace Albina.DataAccess.Core.Models
{
    [Table("User")]
    class UserRto
    {
        public int MyProperty { get; set; }
    }
}
