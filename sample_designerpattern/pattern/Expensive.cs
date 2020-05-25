using System;

namespace sample_designerpattern
{
    public class Expensive : IThings
    {
        public void Says()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Expensive!");
        }
    }
}