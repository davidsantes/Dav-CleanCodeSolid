namespace CleanCode._04.Formatting.Better;

public class OrderProcessor
{
    public void ProcessOrder(Order order)
    {
        if (order == null || order.Items.Count == 0)
        {
            throw new ArgumentException("El pedido no es válido");
        }
        decimal total = 0;
        foreach (var item in order.Items)
        {
            total += item.Price * item.Quantity;
        }
        PaymentProcessor processor = new PaymentProcessor();
        processor.ProcessPayment(order.Customer, total);
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
