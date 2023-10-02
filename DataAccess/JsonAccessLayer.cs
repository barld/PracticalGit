using System.Text.Json;

public class JsonAccessLayer 
{
    protected JsonSerializerOptions jsonOptions = new JsonSerializerOptions{
        WriteIndented = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };
}
