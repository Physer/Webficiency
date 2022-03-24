using AutoBogus;
using Business.Models;

namespace Business.Generation;

public class DataGenerator : IDataGenerator
{
    private readonly Random _random = new();

    public IEnumerable<User> GenerateUsers(int? amount = null)
    {
        if (amount is null || amount == 0)
            amount = _random.Next(10, 100);

        return AutoFaker.Generate<IEnumerable<User>>(c => c.WithRepeatCount(amount.Value));
    }
}

public interface IDataGenerator
{
    IEnumerable<User> GenerateUsers(int? amount = null);
}
