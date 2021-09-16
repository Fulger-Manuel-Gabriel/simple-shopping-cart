using SchoolOf.Common.Enums;
using SchoolOf.Data.Abstraction;
using System.Collections.Generic;

namespace SchoolOf.Data.Models
{
    public class Cart : BaseEntityModel
    {
        public CartStatus Status { get; set; }

        public List<Product> Products { get; set; }
    }
}
