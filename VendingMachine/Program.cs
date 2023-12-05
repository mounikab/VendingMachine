namespace VendingMachine
{
    public class Program
    {
        private static bool isOrderingComplete = false;
        private static int currentCredit = 0;
        private static IProductManager productManager = new ProductsManager();
        private static List<Product> productsList = new List<Product>();
        static void Main(string[] args)
        {
            productsList = productManager.GetProductsList();
            Console.WriteLine("1.List Of Products." + "\n" +
                              "2.Insert Money" + "\n" +
                              "3.Recall Money" + "\n" +
                              "4.Order Product");
            string value = Console.ReadLine();

            switch (value)
            {
                case "1":
                    productsList.ForEach(i => Console.Write($"{i.Name}-{i.Price} \n"));
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

            while (isOrderingComplete == false)
            {
                value = Console.ReadLine();
                OrderingProcess(value);
            }

        }

        public static void OrderingProcess(string value)
        {
            switch (value)
            {
                case "2":
                    Console.WriteLine("Insert Amount");
                    currentCredit += Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Current Credit:" + currentCredit);
                    break;
                case "3":
                    Console.WriteLine("Giving Out:" + currentCredit);
                    currentCredit = 0;
                    break;
                case "4":
                    Console.WriteLine("Order Product");
                    string productName = Console.ReadLine();
                    Product product = productsList.FirstOrDefault(p => p.Name.ToLower() == productName.ToLower());
                    if (product == null)
                    {
                        Console.WriteLine("Select Valid Product");
                    }
                    if (product.Price > currentCredit)
                    {
                        int amountrequired = product.Price - currentCredit;
                        Console.WriteLine($"Not enough credit,need {amountrequired} more.");
                    }
                    if (product.Price < currentCredit)
                    {
                        int change = currentCredit - product.Price;
                        Console.WriteLine($"Giving out {product.Name}.Giving back change of {change}");
                        isOrderingComplete = true;
                    }
                    break;
            }
        }
    }
}