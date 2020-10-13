using System;
using System.Threading;

namespace DataSturctures
{
    public class String
    {
        private string identity;

        public String(char[] array)
        {
            if (array == null || array.Length <= 0)
            {
                throw new Exception("chararray can't be null");
            }
            identity = new string(array);
        }


        public int Length { get { return identity.Length; } }

        public static string Concat(string str0, string str1)
        {
            if (str0 == null || str1 == null)
                throw new ArgumentNullException("the params can't be null");
            return string.Concat(str0, str1);
        }
    }
}
