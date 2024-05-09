using Ardalis.SharedKernel;

namespace CSA.Secretary.Core.MeetingAggregate;
public class Member : EntityBase
{
  public string Name { get; set; } = string.Empty;
  public string? Role { get; set; }
  public string? Team { get; set; }

}
