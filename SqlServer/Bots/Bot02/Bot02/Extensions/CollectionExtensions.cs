﻿using Newtonsoft.Json;


namespace Bot02.Extensions
{
    public static class CollectionExtensions
    {
        public static string ToJson(this object value)
        {
            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };

            return JsonConvert.SerializeObject(value, Formatting.Indented, settings);
        }
    }
}