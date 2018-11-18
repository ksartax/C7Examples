using System;

namespace C7Examples
{
    public static class Helper
    {
        public static T Tee<T>(this T @this, Action<T> action)
        {
            action(@this);

            return @this;
        }
    }
}
