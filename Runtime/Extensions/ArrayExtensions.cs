using System;
using System.Collections.Generic;

namespace StephanHooft.Extensions
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Checks whether a specific <paramref name="item"/> appears in the <see cref="Array"/>.
        /// </summary>
        /// <param name="item">The item to check the <see cref="Array"/> for.</param>
        /// <returns><see cref="true"/> if the <see cref="Array"/> contains <paramref name="item"/>.</returns>
        public static bool Contains<T>(this T[] a, T item)
        {
            foreach (T entry in a)
                if (entry.Equals(item))
                    return 
                        true;
            return 
                false;
        }

        /// <summary>
        /// Returns <see cref="true"/> if the <see cref="Array"/> is empty.
        /// </summary>
        /// <returns><see cref="true"/> if the <see cref="Array"/> is empty.</returns>
        public static bool IsEmpty<T>(this T[] a)
        {
            return 
                a.Length == 0;
        }

        /// <summary>
        /// Returns <see cref="true"/> if the <see cref="Array"/> is <see cref="null"/> or empty.
        /// </summary>
        /// <returns><see cref="true"/> if the <see cref="Array"/> is <see cref="null"/> or empty.</returns>
        public static bool IsNullOrEmpty<T>(this T[] a)
        {
            return 
                a.Length == 0 || a == null;
        }

        /// <summary>
        /// Ensures that the <see cref="Array"/> contains a set <typeparamref name="T"/> <paramref name="item"/>.
        /// <para>An <see cref="ArgumentException"/> featuring <paramref name="arrayName"/> is thrown otherwise.</para>
        /// </summary>
        /// <param name="item">The <typeparamref name="T"/> to check for.</param>
        /// <param name="arrayName">The <see cref="Array"/> name to use if an <see cref="ArgumentException"/> is thrown.</param>
        /// <returns>The original <see cref="Array"/>.</returns>
        public static T[] MustContain<T>(this T[] a, T item, string arrayName)
        {
            foreach (T entry in a)
                if (entry.Equals(item))
                    return 
                        a;
            throw
                new ArgumentException(string.Format("{0} must be present in {1}[] {2}.", item, typeof(T), arrayName));
        }

        /// <summary>
        /// Ensures that the <see cref="Array"/> does not contain a set <typeparamref name="T"/> <paramref name="item"/>.
        /// <para>An <see cref="ArgumentException"/> featuring <paramref name="arrayName"/> is thrown if it does.</para>
        /// </summary>
        /// <param name="item">The <typeparamref name="T"/> to check against.</param>
        /// <param name="arrayName">The <see cref="Array"/> name to use if an <see cref="ArgumentException"/> is thrown.</param>
        /// <returns>The original <see cref="Array"/>.</returns>
        public static T[] MustNotContain<T>(this T[] a, T item, string arrayName)
        {
            foreach (T entry in a)
                if (entry.Equals(item))
                    throw
                        new ArgumentException(string.Format("{0} must not be present in {1}[] {2}.", item, typeof(T), arrayName));
            return
                a;
        }

        /// <summary>
        /// Converts an <see cref="Array"/> to a <see cref="List{T}"/>.
        /// </summary>
        /// <returns>A <see cref="List{T}"/>.</returns>
        public static List<T> ToList<T>(this T[] a)
        {
            List<T> output = new List<T>();
            output.AddRange(a);
            return 
                output;
        }
    }
}
