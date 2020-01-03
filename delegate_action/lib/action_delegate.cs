//--------------------------------------------------------------------------------------------------------------------------
// Copyrgith iceharstone
// Ttitle:    验证委托 Action 类，委托是一种类，定义了方法的的类型，使得可以将函数当作另一个函数的参数进行传递的方式，
//            这种将函数进行动态传递的方法，大大减少了if else 的使用，同时使得程序具有很好的扩展性
// DateTime:  2020/01/03
// Author:    胡光华
//---------------------------------------------------------------------------------------------------------------------------
using System;
// Action 类
namespace delegate_action
{
    public class action_delegate
    {
        public Action Actions_Event;

        public void Action_Active()
        {
            if(Actions_Event != null)
            {
                Actions_Event();
            }
        }   
    }
}