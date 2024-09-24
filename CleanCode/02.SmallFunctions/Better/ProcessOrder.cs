namespace CleanCode._02.SmallFunctions.Better;

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

/// <summary>
/// Esta clase sigue el principio de funciones pequeñas, dividiendo la lógica en
/// métodos más pequeños y específicos, lo que mejora la legibilidad y mantenibilidad del
/// código.
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

class Init
{
    static void Start()
    {
        Order order = new Order
        {
            Customer = new Customer { Name = "John Doe" },
            Items = new List<OrderItem>
            {
                new OrderItem { Price = 10, Quantity = 2 },
                new OrderItem { Price = 5, Quantity = 1 }
            }
        };

        OrderProcessor orderProcessor = new OrderProcessor();
        orderProcessor.ProcessOrder(order);
    }
}
