namespace VendingMachine
{
    public class ProductsManager : IProductManager
    {
        public List<Product> ProductsList { get; set; }
        public void FillUpStock()
        {
            ProductsList = new List<Product>
                {
                    new Product{Name="Fanta",Price=10},
                    new Product{Name="Coke",Price=30},
                    new Product{Name="Pepsi",Price=20},
                    new Product{Name="Snadwich",Price=70},
                    new Product{Name="Kvikk Lunsj",Price=25},
                    new Product{Name="Crossiant",Price=40},
                    new Product{Name="Coffee",Price=50},
                    new Product{Name="Tea",Price=50},
                    new Product{Name="Protein Bar",Price=30},
                    new Product{Name="Polse",Price=40},
                };
        }

        public List<Product> GetProductsList()
        {
            if (ProductsList == null)
            {
                FillUpStock();
            }

            return ProductsList;
        }
    }
}
