using System.Text.Json;

public abstract class JsonAccessLayer<T> 
{
    protected JsonSerializerOptions jsonOptions = new JsonSerializerOptions{
        WriteIndented = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    protected abstract string path { get; }

    public IEnumerable<T>? LoadAll()
    {
        string json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<IEnumerable<T>>(json, jsonOptions);
    }


    public void WriteAll(IEnumerable<T> data)
    {
        string json = JsonSerializer.Serialize(data, jsonOptions);
        File.WriteAllText(path, json);
    }

    public void Add(T model) {
        WriteAll(LoadAll().Append(model));
    }
}
