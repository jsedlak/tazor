namespace Tazor.Serialization;

public interface ISerializer
{
    string Serialize(object obj);

    TModel? Deserialize<TModel>(string data);
}
