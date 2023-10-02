using System.Text.Json;

public class AccountsAccess: JsonAccessLayer
{
    static string path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"DataSources/accounts.json"));


    public IEnumerable<AccountModel>? LoadAll()
    {
        string json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<IEnumerable<AccountModel>>(json, jsonOptions);
    }


    public static void WriteAll(List<AccountModel> accounts)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(accounts, options);
        File.WriteAllText(path, json);
    }



}