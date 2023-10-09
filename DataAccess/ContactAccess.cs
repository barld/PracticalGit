
public class ContactAccess : JsonAccessLayer<ContactModel>
{
    protected override string path => Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"DataSources/contacts.json"));
}
