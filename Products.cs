using System;
namespace DapperClass
{
    public class Products
    {
        public Products()
        {
        }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int CetegoryId { get; set; }
        public bool OnSale { get; set; }
        public int StockLevel { get; set; }
    }
}
