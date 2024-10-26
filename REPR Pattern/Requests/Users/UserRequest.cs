using REPR_Pattern.Repository;

namespace REPR_Pattern.Requests.Users;

public record UsersByIdRequest(string Id);

public record CreateUserRequest(string FirstName, string LastName, string Email, string PhoneNumber);
