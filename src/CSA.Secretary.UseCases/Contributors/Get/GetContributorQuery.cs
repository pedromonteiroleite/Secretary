using Ardalis.Result;
using Ardalis.SharedKernel;

namespace CSA.Secretary.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
