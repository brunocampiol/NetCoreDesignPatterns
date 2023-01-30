using System.Text.Json;

namespace NetCoreDesignPatterns.Common.Extensions
{
    public static class JsonExtensions
    {
        public static string ToJson(this object objToJson)
        {
            return JsonSerializer.Serialize(objToJson);
        }

        public static T FromJson<T>(this string stringToObject) where T : class
        {
            if (stringToObject == null) throw new ArgumentNullException(nameof(stringToObject));

            var obj = JsonSerializer.Deserialize<T>(stringToObject);

            if (obj == null)
            {
                throw new Exception($"Null object while deserializing to '{nameof(T)}'. Content: '{stringToObject}'");
            }

            return obj;
        }
    }
}