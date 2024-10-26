using REPR_Pattern.Repository.Interfaces;

namespace REPR_Pattern.Repository;

public class UserRepository : IUserRepository
{
    public List<UserEntity> GetAllUser()
    {
        var users = GetData();
        return users;
    }

    public UserEntity? GetByUserId(Guid id)
    {
        var users = GetData();
        var user = users.FirstOrDefault(x => x.Id == id);
        return user;
    }

    public UserEntity StoreUser(UserEntity user)
    {
        var users = GetData();
        var isExist = users.FirstOrDefault(x => x.Id == user.Id);
        if (isExist != null)
            throw new Exception("User Already Exists.");

        user.Id = new Guid();
        users.Add(user);
        return user;
    }


    private List<UserEntity> GetData()
    {
        var users = new List<UserEntity>
        {
            new()
            {
                Id = new Guid(),
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = DateTime.UtcNow.AddYears(-22),
                Email = "johndoe@gmail.com",
                PhoneNumber = "+0233445566"
            },
            new()
            {
                Id = new Guid(),
                FirstName = "Jane",
                LastName = "Doe",
                DateOfBirth = DateTime.UtcNow.AddYears(-20),
                Email = "janedoe@gmail.com",
                PhoneNumber = "+0233445577"
            },
            new()
            {
                Id = new Guid(),
                FirstName = "Biswajit",
                LastName = "Panday",
                DateOfBirth = DateTime.UtcNow.AddYears(-30),
                Email = "biswajitmailid@gmail.com",
                PhoneNumber = "+0233445588"
            },
        };
        return users;
    }
}


public class UserEntity
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
}