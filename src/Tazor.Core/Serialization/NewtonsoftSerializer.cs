using Newtonsoft.Json;

namespace Tazor.Serialization;

public class NewtonsoftSerializer : ISerializer
{
    private JsonSerializerSettings _settings;

    public NewtonsoftSerializer()
    {
        _settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All
        };
    }

    public TModel? Deserialize<TModel>(string data)
    {
        return JsonConvert.DeserializeObject<TModel>(data, _settings);
    }

    public string Serialize(object obj)
    {
        return JsonConvert.SerializeObject(obj, _settings);
    }
}
