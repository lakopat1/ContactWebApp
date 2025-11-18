namespace Api.Storage
{
    public class ContactStorage
    {
        public List<Api.Contact.Contact> Contacts { get; set; }

        public ContactStorage()
        {
            this.Contacts = new List<Api.Contact.Contact>();
        }

    }
}
