using System.Linq;

namespace GradeBook.Enums
{
    public static class Extensions
    {
        public static bool In<T>(this T val, params T[] values) where T : struct => values.Contains(val);
    }
}
