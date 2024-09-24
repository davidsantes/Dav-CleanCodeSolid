namespace CleanCode._03.Comments.Wrong;

/// <summary>
/// En este ejemplo, los comentarios explican lo que el código ya debería dejar claro
/// por sí mismo.
/// </summary>
public class OrderProcessor
{
    public void ProcessOrder(Order order)
    {
        // Validar el pedido ¿no sería mejor llamar a un método ValidateOrder?
        if (order == null || order.Items.Count == 0)
        {
            throw new ArgumentException("El pedido no es válido");
        }

        // Calcular el total ¿no sería mejor llamar a un método CalculateTotal?
        decimal total = 0;
        foreach (var item in order.Items)
        {
            total += item.Price * item.Quantity;
        }

        // Procesar el pago ¿no sería mejor llamar a un método ProcessPayment?
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
