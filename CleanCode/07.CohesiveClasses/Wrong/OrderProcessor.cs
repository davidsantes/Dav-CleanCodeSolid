namespace CleanCode._06.Cohesion.Wrong;

/// <summary>
/// En este ejemplo, la clase OrderProcessor tiene demasiadas responsabilidades, lo que la hace menos cohesiva.
/// </summary>
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

        // Enviar confirmación por correo electrónico
        EmailService emailService = new EmailService();
        emailService.SendOrderConfirmation(order.Customer.Email, total);
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
    public string Email { get; set; }
}

public class PaymentProcessor
{
    public void ProcessPayment(Customer customer, decimal amount)
    {
        Console.WriteLine($"Processing payment of {amount:C} for customer {customer.Name}");
    }
}

public class EmailService
{
    public void SendOrderConfirmation(string email, decimal total)
    {
        Console.WriteLine($"Sending order confirmation to {email} for total amount {total:C}");
    }
}
