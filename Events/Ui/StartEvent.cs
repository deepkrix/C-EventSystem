using LagerRatte0._01.Events;
using System;

namespace LagerRatte0._01
{
   public class StartEvent : AbstractEvent
    {

        public static String TYPE = typeof(StartEvent).ToString();

        public override void Fire(EventWatcher eventWatcher)
        {
            eventWatcher.OnEvent(this);
        }

        public override string getType()
        {
            return TYPE;
        }


      
    }
}
