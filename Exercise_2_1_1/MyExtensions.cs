using System;
using System.Collections.Generic;

namespace Exercise2_1
{
    public static class MyExtensions
    {
        public static bool HasSubSetOf(this List<AttributeList> list, AttributeList attrs)
        {
            foreach (var a in list)
            {
                if (attrs.Contains(a) && a.Count < attrs.Count)
                    return true;
            }
            return false;
        }

        public static bool HasSupersetOf(this List<AttributeList> list, AttributeList attrs)
        {
            foreach (var a in list)
            {
                if (a.IsSupersetOf(attrs))
                    return true;
            }
            return false;
        }

        public static void Print(this List<FunctionalDependency> list)
        {
            foreach (var fd in list)
            {
                Console.WriteLine(fd);
            }
        }
    }
}
