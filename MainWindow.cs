using LagerRatte0._01.Holders;
using LagerRatte0._01.Engine;
using System;
using System.Windows.Forms;

namespace LagerRatte0._01
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Shared.engine = Engines.getInstance();
            Shared.eventBus = EventBus.getInstance();
            Shared.engine.start();


            Shared.eventBus.notify(new StartEvent());
            Console.WriteLine();
        }
    }
}
