namespace Api.Storage
{
    public class ContactStorage
    {
        public List<Api.Contact.Contact> Contacts { get; set; }

        public ContactStorage()
        {
            this.Contacts = new List<Api.Contact.Contact>();
            for(int i = 1; i < 5; i++)
            {
                this.Contacts.Add (new Api.Contact.Contact()
                {
                    Id = i,
                    Name = $"Полное имя {i}",
                    Email = $"{Guid.NewGuid().ToString().Substring(0,5)}_{i}@mail.ru"

                });
            }
        }

    }
}
