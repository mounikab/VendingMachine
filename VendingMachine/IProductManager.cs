namespace VendingMachine
{
    public interface IProductManager
    {
        void FillUpStock();
        List<Product> GetProductsList();
    }
}
