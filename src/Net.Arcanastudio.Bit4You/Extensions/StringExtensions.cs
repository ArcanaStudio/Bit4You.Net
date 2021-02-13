using System.Text.Json;

namespace Net.Arcanastudio.Bit4You.Extensions
{
    internal static class StringExtensions
    {
        public static T Deserialize<T>(this string s)
        {
            return string.IsNullOrWhiteSpace(s) ? default : JsonSerializer.Deserialize<T>(s, new JsonSerializerOptions{PropertyNameCaseInsensitive = true});
        }
    }
}
