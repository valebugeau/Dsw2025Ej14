namespace Dsw2025Ej14.Api.Domain
{
    public class Product
    {
        public String Sku { get; set; }
        public String Name { get; set; }
        Decimal CurrentUnitPrice { get; set; }
        bool IsActive { get; set; }
    }
}
