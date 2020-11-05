using LagerRatte0._01.Events;

namespace LagerRatte0._01
{
    public abstract class AbstractEvent : Event
    {
      
        public abstract string getType();

        public abstract void Fire(EventWatcher eventWatcher);
    }
}
