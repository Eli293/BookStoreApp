using System.Text.Json;

namespace BookStoreApp.Models
{
    public static class SessionExtensions
    {
        public static void SetObject<T>(this ISession session, string key, T value)
        {
            //SERIALIZE object to json and STORE value in session
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T? GetObject<T>(this ISession session, string key)
        {
            //DESERIALIZE json and RETURN value by key, or else return null
            var json = session.GetString(key);
            return (string.IsNullOrEmpty(json)) ? default(T) :
                JsonSerializer.Deserialize<T>(json);
        }
    }
}
