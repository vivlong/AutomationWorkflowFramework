using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DeveloperTools.Classes
{
    abstract class ThreadHelper
    {
        Thread thread = null;

        abstract public void run();

        public void start()
        {
            if (thread == null)
                thread = new Thread(run);
            thread.Start();
        }

        public ThreadState threadState()
        {
            if (thread == null)
                thread = new Thread(run);
            return thread.ThreadState;
        }

        public void abort()
        {
            if (thread == null)
                thread = new Thread(run);
            thread.Abort();
        }
    }
}
