using Ardalis.SharedKernel;

namespace CSA.Secretary.Core.MeetingAggregate;
public class Subject : EntityBase
{
  public string Name { get; set; } = string.Empty;
  public List<Member>? Members { get; set; }
  public List<string>? Notes { get; set; }
  public List<string>? Attachments { get; set; }
  public int Order { get; set; }

}
