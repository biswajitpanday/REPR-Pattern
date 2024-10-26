namespace REPR_Pattern.Repository.Interfaces;

public interface IUserRepository
{
    Task<List<UserEntity>> GetAllUser();
    Task<UserEntity?> GetByUserId(Guid id);
    Task<UserEntity> CreateUser(UserEntity user);
}