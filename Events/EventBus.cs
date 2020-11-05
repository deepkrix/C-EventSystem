using System;
using LagerRatte0._01.Events;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.sun.net.ssl.@internal.www.protocol.https;
using com.sun.tools.javac.main;

namespace LagerRatte0._01
{
    public class EventBus
    {
        private Handler mHandler;
        private static EventBus mInstance = null;
        private readonly Dictionary<String, List<EventWatcher>> events = (new Dictionary<String, List<EventWatcher>>());
        private Object obj = new Object();
        

        private EventBus()
        {
            mHandler = new Handler();
        }

        public static EventBus getInstance()
        {
            if (mInstance == null) 
            {
                mInstance = new EventBus();
            }
            return mInstance;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void listen(String eventType, EventWatcher eventWatcher)
        {
            Console.WriteLine("ausgabe  " + eventType);
            List<EventWatcher> watchers = events[eventType];
            if (watchers == null)
            {
                watchers = (new List<EventWatcher>());
            }
            watchers.Add(eventWatcher);
            events.Add(eventType, watchers);
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void unlisten(String eventType, EventWatcher eventWatcher)
        {
            List<EventWatcher> watchers = events[eventType];
            if (watchers != null)
            {
                watchers.Remove(eventWatcher);
            }
        }


        public void notify(Event e) {
            
            lock(obj) {
                //Console.WriteLine("ausgabe  " + e.GetType().ToString());
                List<EventWatcher> watchers = events[e.GetType().ToString()];
			if (watchers != null) {
				foreach (EventWatcher watcher in watchers) {
					AbstractEvent abstractEvent = (AbstractEvent) e;
                        abstractEvent.Fire(watcher);
                    }
                }
            }
        }

      






    }
}
