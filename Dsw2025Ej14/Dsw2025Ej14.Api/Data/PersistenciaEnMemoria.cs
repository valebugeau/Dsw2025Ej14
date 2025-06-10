using System.Runtime.CompilerServices;
using System.Text.Json;
using Dsw2025Ej14.Api.Domain;

namespace Dsw2025Ej14.Api.Data
{
    public class PersistenciaEnMemoria
    {

        private List<Product> _products = [];

        public PersistenciaEnMemoria()
        {
            LoadProducts();
        }
        public Product getProduct(string sku)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Product> GetProducts()
        {
            return _products.Where(p => p.IsActive);
        }
        public void LoadProducts()
        {
            var json = File.ReadAllText("..\\..\\..\\Data\\products.json");
            _products = JsonSerializer.Deserialize<List<Product>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            }) ?? [];

        }
    }
}
