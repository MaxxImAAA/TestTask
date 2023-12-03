using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    internal static class Server
    {
        private static int Count { get; set; }
        private static ReaderWriterLockSlim _lock = new ReaderWriterLockSlim();

        
        public static void GetCount()
        {
            int i = 0;

           while(i < 5)
            {
                try
                {
                    _lock.EnterReadLock();
                    Console.WriteLine($"Read: Thread {Thread.CurrentThread.ManagedThreadId} is reading: {Count}");
                }
                finally
                {
                    _lock.ExitReadLock();
                }

                i++;
                Thread.Sleep(500);

            }
              
            
        }

        public static void AddToCount(int count)
        {
            int i = 0;
            while( i < 5) 
            {
                try
                {
                    _lock.EnterWriteLock();
                    Console.WriteLine($"Writer: Thread {Thread.CurrentThread.ManagedThreadId} is writing: {Count = count}");
                }
                finally
                {
                    _lock.ExitWriteLock();
                }

                i++;
                Thread.Sleep(2000);
            }

        }
    }
}
