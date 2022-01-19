using System;
using System.Threading;

namespace TP3
{
    public class Exercice2
    {
            Mutex mut = new Mutex();
            public void fct(string x, int time, int timer)
            {
                while (timer != 0)
                {
                    mut.WaitOne();
                    Console.Write(x);
                    mut.ReleaseMutex();
                    Thread.Sleep(time);
                    timer -= 1;
                
                }
            
            }


            public void launch()
            {
                var t1 = new Thread( ()=> fct(" ", 50,200));
                var t2 = new Thread( ()=> fct("*", 40,275));
                var t3 = new Thread( ()=> fct("°", 20,450));
            
                t1.Start();
                t2.Start();
                t3.Start();

                t1.Join();
                t2.Join();
                t3.Join();
            }
        
        
    }
}