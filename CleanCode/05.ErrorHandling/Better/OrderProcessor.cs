namespace CleanCode._05.ErrorHandling.Better;

/// <summary>
/// En este ejemplo, el manejo de errores es más claro y proporciona información útil sobre los errores.
/// Si el programa es más complejo, se podría manejar con técnicas más avanzadas como el uso de un logger,
/// saneamiento de excepciones, asignar a cada excepción un guid para mejorar la trazabilidad, etc.
/// </summary>
public class OrderProcessor
{
    public void ProcessOrder(Order order)
    {
        try
        {
            ValidateOrder(order);
            decimal total = CalculateTotal(order);
            ProcessPayment(order.Customer, total);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Order validation error: {ex.Message}");
        }
        catch (PaymentProcessingException ex)
        {
            Console.WriteLine($"Payment processing error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }

    private void ValidateOrder(Order order)
    {
        if (order == null || order.Items.Count == 0)
        {
            throw new ArgumentException("The order is not valid");
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
        try
        {
            PaymentProcessor processor = new PaymentProcessor();
            processor.ProcessPayment(customer, total);
        }
        catch (Exception ex)
        {
            throw new PaymentProcessingException("Failed to process payment", ex);
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

public class PaymentProcessingException : Exception
{
    public PaymentProcessingException(string message, Exception innerException)
        : base(message, innerException) { }
}
