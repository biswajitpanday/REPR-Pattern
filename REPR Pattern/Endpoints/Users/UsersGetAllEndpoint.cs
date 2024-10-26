using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using REPR_Pattern.Repository;
using REPR_Pattern.Repository.Interfaces;

namespace REPR_Pattern.Endpoints.Users;

[HttpGet("api/users")]
[AllowAnonymous]
public class UsersGetAllEndpoint(IUserRepository userRepository) : EndpointWithoutRequest<List<UserEntity>>
{
    public override async Task HandleAsync(CancellationToken ct)
    {
        var users = await userRepository.GetAllUser();
        await SendAsync(users, cancellation: ct);
    }
}