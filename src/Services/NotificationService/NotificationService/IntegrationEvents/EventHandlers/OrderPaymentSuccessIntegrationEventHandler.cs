using EventBus.Base.Abstraction;
using NotificationService.IntegrationEvents.Events;

namespace NotificationService.IntegrationEvents.EventHandlers;

class OrderPaymentSuccessIntegrationEventHandler : IIntegrationEventHandler<OrderPaymentSuccessIntegrationEvent>
{

    public Task Handle(OrderPaymentSuccessIntegrationEvent @event)
    {
        // Send Fail Notification (Sms, EMail, Push)

        //Log.Logger.Information($"Order Payment Success with OrderId: {@event.OrderId}");

        return Task.CompletedTask;
    }
}