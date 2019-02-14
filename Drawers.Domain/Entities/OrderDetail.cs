namespace Drawers.Domain.Entities
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int UnitPrice { get; set; }
        public short Quantity { get; set; }
        public int Discount { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
