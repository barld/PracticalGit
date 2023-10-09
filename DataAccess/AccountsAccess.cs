using System.Text.Json;

public class AccountsAccess: JsonAccessLayer<AccountModel>
{
    protected override string path => Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"DataSources/accounts.json"));
}