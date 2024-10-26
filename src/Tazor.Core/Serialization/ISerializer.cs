namespace Tazor.Serialization;

/// <summary>
/// Provides a common interface for seralizing objects to and from strings
/// </summary>
public interface ISerializer
{
    /// <summary>
    /// Serializes an object to a string
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    string Serialize(object obj);

    /// <summary>
    /// Deserializes an object from a string
    /// </summary>
    /// <param name="data"></param>
    /// <typeparam name="TModel"></typeparam>
    /// <returns></returns>
    TModel? Deserialize<TModel>(string data);
}
