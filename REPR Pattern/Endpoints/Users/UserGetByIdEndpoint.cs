using FastEndpoints;
using REPR_Pattern.Repository.Interfaces;
using REPR_Pattern.Requests.Users;
using REPR_Pattern.Responses.Users;

namespace REPR_Pattern.Endpoints.Users;

// [HttpGet("api/users/{id}")]
// [AllowAnonymous]
public class UserGetByIdEndpoint(IUserRepository userRepository) : Endpoint<UsersByIdRequest, UserByIdResponse>
{
    public override void Configure()
    {
        Get("api/users/{id}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(UsersByIdRequest req, CancellationToken ct)
    {
        var user = await userRepository.GetByUserId(Guid.Parse(req.Id));
        if (user is null)
            await SendNotFoundAsync(ct);
        else
            await SendAsync(new UserByIdResponse(user), cancellation: ct);
    }
}