using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communication
{
    internal class Users
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public Users(string name, int id)
        {
            Name = name;
            
            Id = id;             
        }
    }
}
