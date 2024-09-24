using FluentAssertions;
using Xunit;

namespace Exercises._02.EndCode;

public class OrderProcessorTests
{
    [Fact]
    public void ProcessOrder_ShouldThrowArgumentException_WhenOrderIsNull()
    {
        // Arrange
        var orderProcessor = new OrderProcessor(
            new OrderValidator(),
            new TotalCalculator(),
            new PaymentProcessor(),
            new EmailService()
        );

        // Act
        Action act = () => orderProcessor.ProcessOrder(null);

        // Assert
        act.Should().Throw<ArgumentException>().WithMessage("El pedido no es válido");
    }

    [Fact]
    public void ProcessOrder_ShouldThrowArgumentException_WhenOrderHasNoItems()
    {
        // Arrange
        var orderProcessor = new OrderProcessor(
            new OrderValidator(),
            new TotalCalculator(),
            new PaymentProcessor(),
            new EmailService()
        );
        var order = new Order
        {
            Customer = new Customer { Name = "John Doe" },
            Items = new List<OrderItem>()
        };

        // Act
        Action act = () => orderProcessor.ProcessOrder(order);

        // Assert
        act.Should().Throw<ArgumentException>().WithMessage("El pedido no es válido");
    }

    [Fact]
    public void ProcessOrder_ShouldProcessPayment_WhenOrderIsValid()
    {
        // Arrange
        var orderProcessor = new OrderProcessor(
            new OrderValidator(),
            new TotalCalculator(),
            new PaymentProcessor(),
            new EmailService()
        );
        var order = new Order
        {
            Customer = new Customer { Name = "John Doe" },
            Items = new List<OrderItem>
            {
                new OrderItem { Price = 10, Quantity = 2 },
                new OrderItem { Price = 5, Quantity = 1 }
            }
        };

        // Act
        Action act = () => orderProcessor.ProcessOrder(order);

        // Assert
        act.Should().NotThrow();
    }
}
