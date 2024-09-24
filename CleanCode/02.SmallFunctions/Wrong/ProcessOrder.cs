namespace CleanCode._02.SmallFunctions.Wrong;

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

public class OrderProcessor
{
    public void ProcessOrder(Order order)
    {
        // Validar el pedido
        if (order == null || order.Items.Count == 0)
        {
            throw new ArgumentException("El pedido no es válido");
        }

        // Calcular el total
        decimal total = 0;
        foreach (var item in order.Items)
        {
            total += item.Price * item.Quantity;
        }

        // Procesar el pago
        PaymentProcessor processor = new PaymentProcessor();
        processor.ProcessPayment(order.Customer, total);
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
