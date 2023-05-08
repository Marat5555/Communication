using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communication
{
    internal interface IWhatsapp
    {
        string WSendMessage(); 
        void WReceiveMessage(List<string> text);
    }
}
