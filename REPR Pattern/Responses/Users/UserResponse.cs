using REPR_Pattern.Repository;

namespace REPR_Pattern.Responses.Users;

public record UserByIdResponse(UserEntity user);
public record CreateUserResponse(UserEntity user);