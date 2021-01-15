using System.Text.Json;

namespace Bit4You.Net.Extensions
{
    internal static class ObjectExtensions
    {
        internal static string JsonSerialize(this object o)
        {
            return JsonSerializer.Serialize(o);
        }
    }
}
