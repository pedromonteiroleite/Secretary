using Ardalis.Result;
using Ardalis.SharedKernel;

namespace CSA.Secretary.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
