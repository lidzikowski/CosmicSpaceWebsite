using Newtonsoft.Json;

namespace CosmicSpaceWebsiteDll
{
    public static class DllUtils
    {
        public static string SerializeObject(object o)
        {
            return JsonConvert.SerializeObject(o, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
        }

        public static T DeserializeObject<T>(string o)
        {
            return JsonConvert.DeserializeObject<T>(o);
        }

        public static T Clone<T>(T o)
        {
            return DeserializeObject<T>(SerializeObject(o));
        }
    }
}