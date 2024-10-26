namespace REPR_Pattern.Repository.Interfaces;

public interface IUserRepository
{
    List<UserEntity> GetAllUser();
    UserEntity? GetByUserId(Guid id);
    UserEntity StoreUser(UserEntity user);
}