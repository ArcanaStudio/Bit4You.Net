using System.Text.Json;

namespace Net.Arcanastudio.Bit4You.Extensions
{
    internal static class ObjectExtensions
    {
        internal static string JsonSerialize(this object o)
        {
            return JsonSerializer.Serialize(o);
        }
    }
}
