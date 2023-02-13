using Data.Entities;
using Data.Repositories;

namespace FirstWinFormApp
{
    internal static class Program
    {
        private static IUserRepository _userRepository = new MemoryProviders.Repositories.UserRepository();
                                                         //new FileProviders.Repositories.UserRepository();

        //new MemoryProviders.Repositories.UserRepository();

        private static void InitData()
        {
            _userRepository.Add(
                new User()
                {
                    Id = 0,
                    FirstName = "Дмитрий",
                    SecondName = "Медведев",
                    Address = "Москва, кремль"
                });

            _userRepository.Add(
                new User()
                {
                    Id = 1,
                    FirstName = "Владимир",
                    SecondName = "Путин",
                    Address = "Москва, кремль"
                });

            _userRepository.Add(
                new User()
                {
                    Id = 2,
                    FirstName = "Сергей",
                    SecondName = "Лавров",
                    Address = "Москва, кремль"
                });

            _userRepository.Add(
                new User()
                {
                    Id = 3,
                    FirstName = "Сергей",
                    SecondName = "Собянин",
                    Address = "Москва, кремль"
                });
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // InitData();

            ApplicationConfiguration.Initialize();
            Application.Run(
                new UserInfoForm(
                    userRepository: _userRepository,
                    userId: 3
                    ));
        }
    }
}