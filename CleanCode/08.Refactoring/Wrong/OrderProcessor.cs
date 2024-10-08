namespace CleanCode._07.Refactoring.Wrong;

/// <summary>
/// En este ejemplo, la clase OrderProcessor tiene demasiadas responsabilidades y el c�digo es dif�cil de mantener.
/// Por ejemplo, si queremos cambiar la forma en que se procesan los pagos, tendr�amos que modificar la clase OrderProcessor.
/// </summary>
public class OrderProcessor
{
    public void ProcessOrder(Order order)
    {
        // Validar el pedido
        if (order == null || order.Items.Count == 0)
        {
            throw new ArgumentException("El pedido no es v�lido");
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

        // Enviar confirmaci�n por correo electr�nico
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
