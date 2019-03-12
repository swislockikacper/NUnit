using System;

namespace Project
{
    public class TestClass
    {
        public bool IsString(object s)
        {
            if (s == null)
                throw new ArgumentNullException("Argument cannot be null", "s");

            if (s is string)
                return true;

            return false;
        }
    }
}
