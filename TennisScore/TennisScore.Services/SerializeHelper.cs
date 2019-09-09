using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using System.Collections.Generic;
using System.IO;

namespace TennisScore.Services
{
    public class SerializeHelper
    {
        static readonly JsonSerializerSettings _jsonSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-dd HH-mm-ss" };
        public static string SerializeMatch(Match model)
        {
            return JsonConvert.SerializeObject(model, _jsonSettings);
        }

        //public static T DeSerialize<T>(string json)
        //{
        //    var reader = new JsonTextReader(new StringReader(json));
        //    var validatingReader = new JSchemaValidatingReader(reader);
        //    validatingReader.Schema = schema;

        //    var serializer = new JsonSerializer();
        //    var roles = serializer.Deserialize(reader);

        //    var model = JsonConvert.DeserializeObject<T>(json, _jsonSettings);
        //    return model;
        //}
    }
}