using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communication
{
    internal interface ITelegram
    {
        string TSendMessage();

        void TReceiveMessage(List<string> text);
    }
}
