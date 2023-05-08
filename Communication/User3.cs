using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communication
{
    internal class User3 : Users
    {
        public User3(string name, int id) : base(name, id)
        {
        }

        string mesTel = string.Empty;
        string mesVib = string.Empty;
        string mesWhats = string.Empty;

        public void TReceiveMessage(List<string> text)
        {
            Console.WriteLine("История сообщений: ");
            foreach (var mes in text)
            {
                Console.WriteLine(mes);
            }
        }
        public string TSendMessage()
        {
            Console.WriteLine("Введите сообщение: ");
            return mesTel = Console.ReadLine(); ;
        }

        public void VReceiveMessage(List<string> text)
        {
            Console.WriteLine("История сообщений: ");
            foreach (var mes in text)
            {
                Console.WriteLine(mes);
            }
        }
        public string VSendMessage()
        {
            Console.WriteLine("Введите сообщение: ");
            return mesVib = Console.ReadLine(); ;
        }

        public void WReceiveMessage(List<string> text)
        {
            Console.WriteLine("История сообщений: ");
            foreach (var mes in text)
            {
                Console.WriteLine(mes);
            }
        }

        public string WSendMessage()
        {
            Console.WriteLine("Введите сообщение: ");
            return mesWhats = Console.ReadLine(); ;
        }
    }
}
