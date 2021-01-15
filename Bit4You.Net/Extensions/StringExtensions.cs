using System.Text.Json;

namespace Bit4You.Net.Extensions
{
    internal static class StriµngExtensions
    {
        public static T Deserialize<T>(this string s)
        {
            return string.IsNullOrWhiteSpace(s) ? default : JsonSerializer.Deserialize<T>(s);
        }
    }
}
