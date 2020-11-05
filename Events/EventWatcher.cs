using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagerRatte0._01.Events
{
    public interface EventWatcher
    {

        void OnEvent(StartEvent e);
        
    }
}
