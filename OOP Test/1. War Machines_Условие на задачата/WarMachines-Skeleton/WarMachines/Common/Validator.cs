using System;

namespace WarMachines.Common
{
   public static class Validator
    {
        public static void CheckIfNull(object obj,string str=null)
        {
            if (obj == null)
            {
                throw new NullReferenceException(str);
            }
        }
        public static void CheckIfStringIsNullOrEmpty(string text,string msg = null)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new NullReferenceException(msg);
            }
        }
    }
}
