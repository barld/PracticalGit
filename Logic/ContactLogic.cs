
public class ContactLogic {
    public void AddContact(ContactModel model)
    {
        if (string.IsNullOrWhiteSpace(model.Name))
        {
            throw new Exception("Had je maar een naam moeten invullen");
        }

        var accessLayer = new ContactAccess();

        accessLayer.AddContact(model);
    }
}