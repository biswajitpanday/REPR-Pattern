using FastEndpoints;
using REPR_Pattern.Repository;
using REPR_Pattern.Repository.Interfaces;
using REPR_Pattern.Requests.Users;
using REPR_Pattern.Responses.Users;

namespace REPR_Pattern.Endpoints.Users;

public class UserPostEndpoint(IUserRepository userRepository) : Endpoint<CreateUserRequest, CreateUserResponse>
{
    public override void Configure()
    {
        Post("api/users");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CreateUserRequest req, CancellationToken ct)
    {
        var userEntity = new UserEntity
        {
            FirstName = req.FirstName,
            LastName = req.LastName,
            Email = req.Email,
            PhoneNumber = req.PhoneNumber
        };
        var user = await userRepository.CreateUser(userEntity);
        var response = new CreateUserResponse(user);
        await SendCreatedAtAsync<UserGetByIdEndpoint>(new UserByIdResponse(user), response, cancellation: ct);
    }
}