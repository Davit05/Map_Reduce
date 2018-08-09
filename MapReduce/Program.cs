using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapReduce
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public static class Extension
    {
        public static U Reduce<T, U>(this List<T> list, Func<T, U, U> f, U u = default(U))
        {
            U result = u;

            foreach (T item in list)
            {
                u = f(item, u);
            }
            return u;
        }

        public static List<U> Map<T, U>(this List<T> list,Func<T,U> f)
        {
            List<U> result = new List<U>();
            foreach (T item in list)
            {
                result.Add(f(item));
            }
            return result;
        }
    }
}
