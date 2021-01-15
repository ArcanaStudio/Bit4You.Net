using System.Text.Json;

namespace Bit4You.Service.Tests.Helpers
{
    public static class Extensions
    {
        public static FakeMessage<T> ToFakeMessage<T>(this string json)
        {
            return JsonSerializer.Deserialize<FakeMessage<T>>(json);
        }

        public static string Serialize(this object o)
        {
            return JsonSerializer.Serialize(o);
        }
    }
}
