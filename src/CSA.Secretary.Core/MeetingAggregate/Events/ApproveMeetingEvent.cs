using Ardalis.SharedKernel;

namespace CSA.Secretary.Core.MeetingAggregate.Events;

internal sealed class ApproveMeetingEvent(int meetingId) : DomainEventBase
{
  public int MeetingId { get; init; } = meetingId;
}
