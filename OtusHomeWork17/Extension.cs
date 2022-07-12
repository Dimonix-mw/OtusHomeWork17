using System.Collections;

namespace OtusHomeWork17
{
    public static class Extension
    {
        public static T GetMax<T>(this IEnumerable e, Func<T, float> getParameter) where T : class
        {
            T max = default(T);
            float min = float.MinValue;
            foreach (T item in e)
            {
                float number = getParameter(item);
                if (number > min)
                {
                    max = item;
                    min = number;
                }
            }
            return max;
        }
    }
}
