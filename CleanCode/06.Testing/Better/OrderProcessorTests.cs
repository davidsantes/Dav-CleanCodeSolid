using CleanCode._05.ErrorHandling.Better;
using FluentAssertions;
using Xunit;

namespace CleanCode._06.Testing.Better;

public class OrderProcessorTests
{
    [Fact]
    public void ProcessOrder_ShouldProcessPayment_WhenOrderIsValid()
    {
        // Arrange
        var orderProcessor = new OrderProcessor();
        var order = new Order
        {
            Customer = new Customer { Name = "John Doe" },
            Items =
            [
                new OrderItem { Price = 10, Quantity = 2 },
                new OrderItem { Price = 5, Quantity = 1 }
            ]
        };

        // Act
        Action act = () => orderProcessor.ProcessOrder(order);

        // Assert
        act.Should().NotThrow();
    }

    [Fact]
    public void ProcessPayment_ShouldThrowPaymentProcessingException_WhenPaymentFails()
    {
        // Arrange
        var orderProcessor = new OrderProcessor();
        var order = new Order
        {
            Customer = new Customer { Name = "John Doe" },
            Items =
            [
                new OrderItem { Price = 10, Quantity = 2 },
                new OrderItem { Price = 5, Quantity = 1 }
            ]
        };

        // Simulate a failure in the payment processor
        var paymentProcessor = new PaymentProcessor();
        var exception = new Exception("Payment gateway error");

        // Act
        Action act = () =>
        {
            paymentProcessor.ProcessPayment(order.Customer, 25);
            throw new PaymentProcessingException("Failed to process payment", exception);
        };

        // Assert
        act.Should()
            .Throw<PaymentProcessingException>()
            .WithMessage("Failed to process payment")
            .WithInnerException<Exception>()
            .WithMessage("Payment gateway error");
    }
}
