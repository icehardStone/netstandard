using System.Collections.Concurrent;
using System.Threading;
using System;
using System.Threading.Tasks;

namespace sample_collection_concurrent
{
    public class BlockCollectionTest
    {
        public static void TryTakenTest()
        {
            using(BlockingCollection<Person> persons = new BlockingCollection<Person>())
            {
                int NUMSIZE = 1000;
                for(int i =0;i<NUMSIZE;i++)
                {
                    persons.Add(new Person{Name=$"Person-{i}"});
                }
                persons.CompleteAdding();

                int outSum = 0;

                Action action = () => {
                    Person localItem;
                    int localSum = 0;

                    while(persons.TryTake(out localItem)) localSum += 1;
                    Interlocked.Add(ref outSum,localSum);
                };

                Parallel.Invoke(action,action,action,action);
                Console.WriteLine($"outSum values is {outSum}");
                Console.WriteLine($"persons.IsCompleted =  {persons.IsCompleted}");
            }
        }
    }
    public class Person
    {
        public string Name {set;get;}
    }
}