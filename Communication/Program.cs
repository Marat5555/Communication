using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствуем Вас на агрегаторе мессенджеров!");
            int onOrOff = 0;
            List<string> telHistory = new List<string>();
            List<string> vibHistory = new List<string>();
            List<string> whatsHistory = new List<string>();

            while (true)
            {
                Console.WriteLine("Хотите продолжить общение - нажмите цифру 0. Если хотите выйти из программы - нажмите цифру 4.");
                onOrOff =Convert.ToInt32(Console.ReadLine());

                if (onOrOff == 4)
                {
                    Console.WriteLine("Ждем Вас снова! До свидания!");
                    break;
                }
                else
                {
                    User1 user1 = new User1("Боб", 1);
                    Console.WriteLine($"Имя: {user1.Name}, Номер Id: {user1.Id}");

                    User2 user2 = new User2("Сэм", 2);
                    Console.WriteLine($"Имя: {user2.Name}, Номер Id: {user2.Id}");

                    User3 user3 = new User3("Кейт", 3);
                    Console.WriteLine($"Имя: {user3.Name}, Номер Id: {user3.Id}");

                    Console.Write("Выберите отправителя по Номеру Id: ");
                    int sender = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Выберите получателя по Номеру Id: ");
                    int recipient = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Выберите Мессенджер по Номеру (Telegram - 1, Viber - 2, Whatsapp - 3): ");
                    int messengerNumber = Convert.ToInt32(Console.ReadLine());

                    switch (messengerNumber)
                    {
                        case 1:
                            user1.TReceiveMessage(telHistory);
                            telHistory.Add(user1.TSendMessage());                            
                            break;
                        case 2:
                            user1.VReceiveMessage(vibHistory);
                            vibHistory.Add(user1.VSendMessage());                            
                            break;
                        case 3:
                            user1.WReceiveMessage(whatsHistory);
                            whatsHistory.Add(user1.WSendMessage());
                            break;
                    }
                }
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
