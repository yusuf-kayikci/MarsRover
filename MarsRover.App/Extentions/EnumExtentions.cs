using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover.App.Extentions
{
    public static class EnumExtentions
    {
        public static T GetNext<T>(this T v) where T : Enum
        {
            var values = Enum.GetValues(v.GetType()).Cast<T>().ToList();
            var index = values.FindIndex(d => d.ToString() == v.ToString());
            if (index == values.Count - 1)
                return values.TakeWhile(e => !v.Equals(e)).First();
            else
                return values.SkipWhile(e => !v.Equals(e)).Skip(1).First();
        }

        public static T GetPrevious<T>(this T v) where T : Enum
        {
            var values = Enum.GetValues(v.GetType()).Cast<T>().Reverse().ToList();
            var index = values.FindIndex(d => d.ToString() == v.ToString());
            if (index == values.Count - 1)
                return values.TakeWhile(e => !v.Equals(e)).First();
            else
                return values.SkipWhile(e => !v.Equals(e)).Skip(1).First();
        }

    }
}
