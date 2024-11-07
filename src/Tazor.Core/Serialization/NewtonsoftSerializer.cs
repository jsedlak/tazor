using Newtonsoft.Json;

namespace Tazor.Serialization;

/// <summary>
/// Provides a newtonsoft implementation of the common serializer interface
/// </summary>
public class NewtonsoftSerializer : ISerializer
{
    private readonly JsonSerializerSettings _settings;

    /// <summary>
    /// Constructor.
    /// </summary>
    public NewtonsoftSerializer()
    {
        _settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.Objects
        };
    }
    
    /// <summary>
    /// Constructor.
    /// </summary>
    public NewtonsoftSerializer(JsonSerializerSettings settings)
    {
        _settings = settings;
    }

    /// <inheritdoc />
    public TModel? Deserialize<TModel>(string data)
    {
        return JsonConvert.DeserializeObject<TModel>(data, _settings);
    }

    /// <inheritdoc />
    public string Serialize(object obj)
    {
        return JsonConvert.SerializeObject(obj, _settings);
    }
}
