﻿using Newtonsoft.Json;

namespace CosmicSpaceWebsiteDll
{
    public static class DllUtils
    {
        public static string SerializeObject(object o)
        {
            return JsonConvert.SerializeObject(o);
        }

        public static T DeserializeObject<T>(string o)
        {
            return JsonConvert.DeserializeObject<T>(o);
        }
    }
}