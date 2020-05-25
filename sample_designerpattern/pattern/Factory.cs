using System;

namespace sample_designerpattern
{
    public class Factory
    {
        /// <summary>
        /// the factory pattern
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public IThings CreateThings(bool input)
        {
            switch (input)
            {
                case true: return new Cheep();
                default: return new Expensive();
            }
        }
    }
}