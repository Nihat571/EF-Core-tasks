using Azure.Identity;
using EF_CORE_new_task.Models;
using EF_CORE_new_task.Services;

namespace EF_CORE_new_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoginServices loginServices = new LoginServices();
            User user = new User() 
            {
                UserName = "nihat",
                Password = "nihat12345"
            };

            start:
            do
            {
                Console.WriteLine("1.Qeydiyyatdan kec\n2.Daxil ol\n0.Exit");
                string userNumber = Console.ReadLine();
                User? baseUser = loginServices.ReadUser();


                switch (userNumber)
                {
                    case "1":
                        Console.WriteLine("Kullanici adi daxil edin:");
                        string userName = Console.ReadLine();
                        Console.WriteLine("Parolunuzu daxil edin:");
                        string userPassword = Console.ReadLine();
                       
                        if (userName == baseUser.UserName && userPassword == baseUser.Password)
                        {
                            Console.WriteLine("Siz artiq qeydiyyatdan kecmisiniz.");
                        goto start;
                        }
                    else
                        {
                            loginServices.AddUser(user);
                            Console.WriteLine("Qeydiyyatdan kecdiniz");
                        }

                        break;
                    case "2":
                        Console.WriteLine("Kullanici adi daxil edin:");
                        string userName1 = Console.ReadLine();
                        Console.WriteLine("Parolunuzu daxil edin:");
                        string userPassword1 = Console.ReadLine();
                        if (userName1 == baseUser.UserName && userPassword1 == baseUser.Password)
                        {
                            Console.WriteLine("Daxil oldunuz");
                            Console.WriteLine("1.Sifremi deyis.\n2.Exit");
                            string userName2 = Console.ReadLine();
                            switch (userName2)
                            {
                                case "1":
                                    User updatedUser = new User()
                                    {
                                       
                                        UserName = userName1,
                                        Password = userPassword1
                                    };

                                    loginServices.UpdateUser(baseUser.Id,updatedUser);
                                    Console.WriteLine("Sifreniz yenilendi");

                                    break;
                            }

                        }
                        else
                        {  
                            Console.WriteLine("Kullanici tapilmadi");
                            goto start;
                        }
                        break;
                    default:
                        break;
                }

            }
            while (true);









        }


      
    }
}
