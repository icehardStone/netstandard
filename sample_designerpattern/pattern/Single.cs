using System;

namespace sample_designerpattern
{
    public class Single
    {
        /// <summary>
        /// test the class is same Single or not flag
        /// </summary>
        /// <value></value>
        public int  Number  {set;get;}
        /// <summary>
        /// 
        /// </summary>
        private Single () 
        {
            // test the class is same Single or not 
            Random random = new Random();
            Number = random.Next();
        }
        /// <summary>
        ///  instance
        /// </summary>
        /// <value></value>
        private static Single Instance {set;get;}
        /// <summary>
        /// lock
        /// </summary>
        /// <returns></returns>
        private static  readonly object locks = new object();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Single  CreateInstance()
        {
            if (Instance == null)
            {
                lock(locks)
                {
                    if(Instance == null)
                    {
                        Instance = new Single();
                    }
                }
            }
            return Instance;
        }
    }
}