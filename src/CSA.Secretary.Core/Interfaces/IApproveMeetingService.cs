using Ardalis.Result;

namespace CSA.Secretary.Core.Interfaces;
public interface IApproveMeetingService
{
  public Task<Result> ApproveMeeting(int meetingId);
}
