//--------------------------------------------------------------------------------------------------------------------------
// Copyrgith  iceharstone
// Ttitle:    Action 类，用于需要将委托参数执行操作的情况
// DateTime:  2020/01/03
// Author:    胡光华
//---------------------------------------------------------------------------------------------------------------------------
using System;

namespace delegate_action
{
    class Program
    {
        static void Main(string[] args)
        {
           Action_Delegate action = new Action_Delegate();
           
            // 订阅事件
            action.Actions_Event += Dog_Dance;
            action.Actions_Event += Cat_Sing;

            action.Action_Active();
        }
        public static void Dog_Dance()
        {
            Console.WriteLine("dance");
        }
        public static void Cat_Sing()
        {
            Console.WriteLine("sing");
        }
    }
}
