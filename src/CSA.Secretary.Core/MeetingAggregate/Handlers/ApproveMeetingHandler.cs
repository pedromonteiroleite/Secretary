using CSA.Secretary.Core.Interfaces;
using CSA.Secretary.Core.MeetingAggregate.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CSA.Secretary.Core.MeetingAggregate.Handlers;

internal class ApproveMeetingHandler(ILogger<ApproveMeetingHandler> logger,
  IEmailSender emailSender) : INotificationHandler<ApproveMeetingEvent>
{
  public async Task Handle(ApproveMeetingEvent domainEvent, CancellationToken cancellationToken)
  {
    logger.LogInformation("Handling Approved Meeting event for {meetingId}", domainEvent.MeetingId);

    await emailSender.SendEmailAsync("to@test.com",
                                     "from@test.com",
                                     "Meetibg Approved",
                                     $"Meeting with id {domainEvent.MeetingId} was approved.");
  }
}
