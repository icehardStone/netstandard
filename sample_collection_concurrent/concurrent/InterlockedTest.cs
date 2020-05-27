using System;
using System.Threading;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace  sample_collection_concurrent
{
    public class InterlockedTest
    {
        private int Temp {set;get;}
        public  void TryAdd()
        {
            Action action = ()=>{
                int sum = 0;
                for(int i = 0;i<10;i++)
                {
                    Temp = i;
                    Interlocked.Add(ref sum, Temp);   // 返回的结果不一样
                    //sum += Temp;                              //  返回的结果不一样
                }
                Console.WriteLine($"the sum is {sum}");
            };
            Parallel.Invoke(action,action,action);
        }
    }
}