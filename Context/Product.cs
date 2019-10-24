
namespace UnitOfWorkSample.Context
{
    public class Product: BaseEntity
    {
        public string ProductCode { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
