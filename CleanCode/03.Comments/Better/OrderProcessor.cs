namespace CleanCode._03.Comments.Better;

/// <summary>
/// En el ejemplo correcto, el código es autodescriptivo y no necesita comentarios
/// innecesarios. Los nombres de las clases, métodos y variables son claros y descriptivos,
/// lo que facilita la comprensión del código sin necesidad de comentarios adicionales.
/// </summary>
public class OrderProcessor
{
    public void ProcessOrder(Order order)
    {
        ValidateOrder(order);
        decimal total = CalculateTotal(order);
        ProcessPayment(order.Customer, total);
    }

    private void ValidateOrder(Order order)
    {
        if (order == null || order.Items.Count == 0)
        {
            throw new ArgumentException("El pedido no es válido");
        }
    }

    private decimal CalculateTotal(Order order)
    {
        decimal total = 0;
        foreach (var item in order.Items)
        {
            total += item.Price * item.Quantity;
        }
        return total;
    }

    private void ProcessPayment(Customer customer, decimal total)
    {
        PaymentProcessor processor = new PaymentProcessor();
        processor.ProcessPayment(customer, total);
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
