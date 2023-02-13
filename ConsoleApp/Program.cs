using FileProviders.Repositories;

var userRepository = new UserRepository();

Console.WriteLine("Введите имя пользователя");
var firstName = Console.ReadLine();

Console.WriteLine("Введите фамилию пользователя");
var secondName = Console.ReadLine();

var user = userRepository.GetUserByName(firstName!, secondName!);

if (user is null)
    Console.WriteLine("Пользователь не найден");
else
    Console.WriteLine($"Пользователь найден: {user}");
