

public class AccessContacts 
{
    public void ShowOptions()
    {
        Console.WriteLine("Choose your option:");
        Console.WriteLine("1.) Voeg contact toe");
        Console.WriteLine("2.) Verwijder contact");
        Console.WriteLine("3.) Toon contacten");

        switch (Console.ReadLine()){
            case "1":
                Console.WriteLine("Maak je contact!");
                Console.WriteLine("Naam");
                string name = Console.ReadLine();
                Console.WriteLine("email");
                string email = Console.ReadLine();
                Console.WriteLine("telefoon");
                string telefoon = Console.ReadLine();
                ContactModel model = new ContactModel
                {
                    Name = name,
                    Email = email,
                    PhoneNumber = telefoon,
                };

                var contextLogic = new ContactLogic();
                contextLogic.AddContact(model);
                Console.WriteLine("je contact is toegevoegd");
            break;
            case "2":

            break;
            case "3":

            break;
            default:
                Console.WriteLine("kies volgende keer een goede input!");
                this.ShowOptions();
                break;

        }
    }
}