using System;
namespace Suppliers.SuppModels
{
    public class BaseEntity{
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
