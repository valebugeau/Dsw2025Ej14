namespace Dsw2025Ej14.Api.Domain
{
    public interface IPersistencia
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(String sku);
    }
}
