using Ardalis.Result;
using Ardalis.SharedKernel;
using CSA.Secretary.Core.Interfaces;
using CSA.Secretary.Core.MeetingAggregate;
using CSA.Secretary.Core.MeetingAggregate.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CSA.Secretary.Core.Services;
public class ApproveMeetingService(IRepository<Meeting> _repository,
  IMediator _mediator,
  ILogger<ApproveMeetingService> _logger) : IApproveMeetingService
{
  public async Task<Result> ApproveMeeting(int meetingId)
  {
    _logger.LogInformation("Approving Meeting {meetingId}", meetingId);
    
    Meeting? aggregate = await _repository.GetByIdAsync(meetingId);
    if (aggregate == null) return Result.NotFound();

    aggregate.Approved = true;
    await _repository.UpdateAsync(aggregate);

    var domainEvent = new ApproveMeetingEvent(meetingId);
    await _mediator.Publish(domainEvent);

    return Result.Success();
  }
}
