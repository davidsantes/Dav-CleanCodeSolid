namespace CleanCode._05.ErrorHandling.Wrong;

/// <summary>
/// En este ejemplo, el manejo de errores es inconsistente y no proporciona información útil sobre los errores.
/// Esto es debido a que el método ProcessOrder no lanza excepciones controladas y todas son genéricas.
/// Además, el mensaje de error no es informativo.
/// </summary>
public class OrderProcessor
{
    public void ProcessOrder(Order order)
    {
        try
        {
            if (order == null || order.Items.Count == 0)
            {
                throw new Exception("Invalid order");
            }

            decimal total = 0;
            foreach (var item in order.Items)
            {
                total += item.Price * item.Quantity;
            }

            PaymentProcessor processor = new PaymentProcessor();
            processor.ProcessPayment(order.Customer, total);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}

public class Order
{
    public Customer Customer { get; set; }
    public List<OrderItem> Items { get; set; } = new List<OrderItem>();
}

public class OrderItem
{
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

public class Customer
{
    public string Name { get; set; }
}

public class PaymentProcessor
{
    public void ProcessPayment(Customer customer, decimal amount)
    {
        Console.WriteLine($"Processing payment of {amount:C} for customer {customer.Name}");
    }
}
