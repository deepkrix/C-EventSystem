using com.sun.net.ssl.@internal.www.protocol.https;
using LagerRatte0._01.Events;
using LagerRatte0._01.Holders;
using System;

namespace LagerRatte0._01.Engine
{
    class Engines : EventWatcherAdapter
    {
        private static Engines mInstance = null;
        private Handler mHandler;



        private Engines()
        {
            mHandler = new Handler();
        }

        public static Engines getInstance()
        {
            if (mInstance == null)
            {
                mInstance = new Engines();
            }
            return mInstance;
        }

        public void start()
        {
            Shared.eventBus.listen(StartEvent.TYPE, this);
            
        }



        public override void OnEvent(StartEvent @event) {

            Console.WriteLine("event gestartet");

        }










        }
}
