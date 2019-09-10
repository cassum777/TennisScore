using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisScore.Services
{
    public class JsonMatchRepository
    {
        static readonly JsonSerializerSettings _jsonSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-dd HH-mm-ss" };
        public string aplicationPath = Environment.CurrentDirectory;
        public string folderName = "MatchStat";
        public JsonMatchRepository()
        {
            var folderPath = Path.Combine(aplicationPath, folderName);
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        //public T Get<T>(string name) where T : Match, new()
        //{
        //    var fileName = string.Format("{0}.json", name);
        //    var path = Path.Combine(aplicationPath, folderName, fileName);

        //    if (!File.Exists(path))
        //    {
        //        return null;
        //    }
        //    using (var sr = new StreamReader(path))
        //    {
        //        var json = sr.ReadToEnd();
        //    }
        //    using (var sr = new StreamReader(path))
        //    {
        //        var json = sr.ReadToEnd();
        //        var player = SerializeHelper.DeSerialize<T>(json);
        //        return player;
        //    }
        //}

        public void SaveMatch(Match match)
        {
            var filename = string.Format("{0}.json", match.TimeStarting.ToString("yyyy'-'MM'-'dd'T'HH'-'mm'-'ss"));

            var path = Path.Combine(aplicationPath, folderName, filename);
            var json = JsonConvert.SerializeObject(match, _jsonSettings);

            using (var sw = new StreamWriter(path))
            {
                sw.Write(json);
            }
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
