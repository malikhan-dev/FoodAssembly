using System.Collections;

namespace FoodAssembly.Utilities
{
    public static class Ensure
    {
        public static bool NotNull<T>(T? item) where T : class => item != null;
        public static bool NotNull<T>(this IEnumerable<T> item) where T : class => item != null;

    }
}
