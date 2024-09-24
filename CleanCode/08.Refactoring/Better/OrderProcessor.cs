namespace CleanCode._07.Refactoring.Right;

/// <summary>
/// En este ejemplo, las responsabilidades se dividen en clases más cohesivas y el código es más fácil de mantener.
/// Explicación
/// 1. OrderProcessor: Clase que coordina las operaciones de procesamiento de pedidos, delegando responsabilidades a otras clases.
/// 2. IOrderValidator y OrderValidator: Interfaz y clase que validan el pedido.
/// 3. ITotalCalculator y TotalCalculator: Interfaz y clase que calculan el total del pedido.
/// 4. IPaymentProcessor y PaymentProcessor: Interfaz y clase que procesan el pago.
/// 5. IEmailService y EmailService: Interfaz y clase que envían la confirmación del pedido por correo electrónico.
/// Beneficios del Refactorizado
/// • Cohesión: Cada clase tiene una única responsabilidad, lo que mejora la cohesión.
/// • Mantenibilidad: El código es más fácil de mantener y extender.
/// • Testabilidad: Las clases más pequeñas y específicas son más fáciles de probar unitariamente.
/// • Reutilización: Las clases e interfaces pueden ser reutilizadas en otros contextos.
/// </summary>
public class OrderProcessor
{
    private readonly IOrderValidator _orderValidator;
    private readonly ITotalCalculator _totalCalculator;
    private readonly IPaymentProcessor _paymentProcessor;
    private readonly IEmailService _emailService;

    public OrderProcessor(
        IOrderValidator orderValidator,
        ITotalCalculator totalCalculator,
        IPaymentProcessor paymentProcessor,
        IEmailService emailService
    )
    {
        _orderValidator = orderValidator;
        _totalCalculator = totalCalculator;
        _paymentProcessor = paymentProcessor;
        _emailService = emailService;
    }

    public void ProcessOrder(Order order)
    {
        _orderValidator.Validate(order);
        decimal total = _totalCalculator.CalculateTotal(order);
        _paymentProcessor.ProcessPayment(order.Customer, total);
        _emailService.SendOrderConfirmation(order.Customer.Email, total);
    }
}

public interface IOrderValidator
{
    void Validate(Order order);
}

public class OrderValidator : IOrderValidator
{
    public void Validate(Order order)
    {
        if (order == null || order.Items.Count == 0)
        {
            throw new ArgumentException("El pedido no es válido");
        }
    }
}

public interface ITotalCalculator
{
    decimal CalculateTotal(Order order);
}

public class TotalCalculator : ITotalCalculator
{
    public decimal CalculateTotal(Order order)
    {
        decimal total = 0;
        foreach (var item in order.Items)
        {
            total += item.Price * item.Quantity;
        }
        return total;
    }
}

public interface IPaymentProcessor
{
    void ProcessPayment(Customer customer, decimal amount);
}

public class PaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(Customer customer, decimal amount)
    {
        Console.WriteLine($"Processing payment of {amount:C} for customer {customer.Name}");
    }
}

public interface IEmailService
{
    void SendOrderConfirmation(string email, decimal total);
}

public class EmailService : IEmailService
{
    public void SendOrderConfirmation(string email, decimal total)
    {
        Console.WriteLine($"Sending order confirmation to {email} for total amount {total:C}");
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
