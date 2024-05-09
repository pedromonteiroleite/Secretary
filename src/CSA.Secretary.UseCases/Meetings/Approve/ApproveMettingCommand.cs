using Ardalis.Result;
using Ardalis.SharedKernel;
using CSA.Secretary.Core.Interfaces;

namespace CSA.Secretary.UseCases.Meetings.Approve;

public record ApproveMettingCommand(int MeetingId) : ICommand<Result>;

public class ApproveMettingCommandHandler(IApproveMeetingService _approveMeetingService)
  : ICommandHandler<ApproveMettingCommand, Result>
{
  public async Task<Result> Handle(ApproveMettingCommand request, CancellationToken cancellationToken)
  {
    
    return await _approveMeetingService.ApproveMeeting(request.MeetingId);

  }
}
