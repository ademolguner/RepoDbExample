using RepoDbExample.Core.Entities;

namespace RepoDbExample.Entites.Models.Sql.Northwind
{
    public class OrderDetail : IEntity, ISqlEntityType
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}