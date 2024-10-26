using REPR_Pattern.Repository.Interfaces;

namespace REPR_Pattern.Repository;

public class UserRepository : IUserRepository
{
    public async Task<List<UserEntity>> GetAllUser()
    {
        var users = GetData();
        return await Task.Run(() => users);
    }

    public async Task<UserEntity?> GetByUserId(Guid id)
    {
        var users = GetData();
        var user = users.FirstOrDefault(x => x.Id == id);
        return await Task.Run(() => user);
    }

    public async Task<UserEntity> CreateUser(UserEntity user)
    {
        var users = GetData();
        var isExist = users.FirstOrDefault(x => x.Id == user.Id);
        if (isExist != null)
            throw new Exception("User Already Exists.");

        user.Id = Guid.NewGuid();
        users.Add(user);
        return await Task.Run(() => user);
    }


    private List<UserEntity> GetData()
    {
        var users = new List<UserEntity>
        {
            new()
            {
                Id = new Guid("4c9ca0ce-f28e-4502-825e-ebb1015bfa3d"),
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = DateTime.UtcNow.AddYears(-22),
                Email = "johndoe@gmail.com",
                PhoneNumber = "+0233445566"
            },
            new()
            {
                Id = new Guid("4fbd1ca0-dea7-4db4-9ef2-bbe365a049a7"),
                FirstName = "Jane",
                LastName = "Doe",
                DateOfBirth = DateTime.UtcNow.AddYears(-20),
                Email = "janedoe@gmail.com",
                PhoneNumber = "+0233445577"
            },
            new()
            {
                Id = new Guid("68dd672e-39ee-4e12-b4b1-bc2d3f73708b"),
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
    public Guid? Id { get; set; }
    public required string FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public required string Email { get; set; }
    public string? PhoneNumber { get; set; }
}