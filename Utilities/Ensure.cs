﻿using System.Collections;

namespace FoodAssembly.Utilities
{
    public static class Ensure
    {
        public static bool NotNull<T>(T? item) where T : class => item != null;
        public static bool EnumerableNotNull<T>(T? item) where T : IEnumerable => item != null;

    }
}
