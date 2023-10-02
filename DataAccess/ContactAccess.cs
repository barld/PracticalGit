
using System.Text.Json;

public class ContactAccess : JsonAccessLayer
{
    static string path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"DataSources/contacts.json"));
    public IEnumerable<ContactModel>? LoadAll()
    {
        string json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<IEnumerable<ContactModel>>(json, jsonOptions);
    }


    public static void WriteAll(IEnumerable<ContactModel> contacts)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(contacts, options);
        File.WriteAllText(path, json);
    }

    public void AddContact(ContactModel model) {
        WriteAll(LoadAll().Append(model));
    }
}