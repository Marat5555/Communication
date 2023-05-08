using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communication
{
    internal interface IViber
    {
        string VSendMessage();
        void VReceiveMessage(List<string> text);
        
    }
}
