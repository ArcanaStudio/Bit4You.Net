using System.Text.Json;
using Arcana.Toolkit.Testing.MsTest;

namespace Net.Arcanastudio.Bit4You.Tests.Helpers
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
