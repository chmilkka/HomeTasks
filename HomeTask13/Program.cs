namespace HomeTask13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var emptyList = new InMemoryContactProvider();
            var contactStore = new ContactStore(emptyList);
            bool flag = true;


            while (flag)
            {
                Console.WriteLine("Оберіть дію:");
                Console.WriteLine("1. Показати контакти");
                Console.WriteLine("2. Додати контакт");
                Console.WriteLine("3. Видалити контакт за id");
                Console.WriteLine("4. Вихід");

                string input = Console.ReadLine();
                Console.Clear();

                switch (input)
                {
                    case "1":
                        foreach (var contact in contactStore)
                        {
                            Console.WriteLine($"Id: {contact.Id}, Ім'я: {contact.Name}, Номер телефону: {contact.PhoneNumber}");
                        }
                        break;

                    case "2":
                        Console.Write("Введіть ім'я контакта: ");
                        string name = Console.ReadLine();

                        Console.Write("Введіть номер телефону контакта: ");
                        string phoneNumber = Console.ReadLine();

                        try
                        {
                            contactStore.Create(new Contact 
                            { 
                                Name = name,
                                PhoneNumber = phoneNumber 
                            });
                            Console.WriteLine("Контакт створено!");
                        }
                        catch (DeniedOperationException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Ooops... something went wrong");
                        }
                        break;

                    case "3":
                        Console.Write("Введіть Id контакту для видалення: ");
                        int id = int.Parse(Console.ReadLine());

                        try
                        {
                            contactStore.Remove(id);
                            
                            Console.WriteLine("Contact removed successfully");                           
                        }
                        catch (DeniedOperationException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Ooops... something went wrong");
                        }
                        break;

                    case "4":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Невідома дія!");
                        break;
                }
            }
            Console.WriteLine("Ви вийшли з програми");
        }
    }
}