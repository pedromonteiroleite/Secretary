using Ardalis.SharedKernel;

namespace CSA.Secretary.Core.MeetingAggregate;
public class Meeting : EntityBase, IAggregateRoot
{
  public string? Name { get; set; }
  public DateTime Date { get; set; }
  public string? Location { get; set; }
  public List<Subject>? Subjects { get; set; }
  public List<string>? Attachments { get; set; }
  public bool Approved { get; set; } 
}
