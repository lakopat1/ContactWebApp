using Api.Storage;
using Api.Contact;
using Api;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Api.Storage
{
    public class ContactStorage
    {
        private List<Api.Contact.Contact> Contacts { get; set; }

        //Создание рандомных контактов 
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
        public List<Api.Contact.Contact> GetContacts()
        {
            return this.Contacts;
        }
        public List<Api.Contact.Contact> AddContact(Api.Contact.Contact contact)
        {
            return this.Contacts;
        }

        public void RemoveContact(int id)
        {
            for (int i = 0; i < this.Contacts.Count; i++)
            {
                if (this.Contacts[i].Id == id)
                {
                    this.Contacts.RemoveAt(i);
                    return;

                }
            }
        }

        public void UpdateConatct ([FromBody] ContactDto contactDto, int id)
        {
            Api.Contact.Contact contact1;
            for (int i = 0; i < this.Contacts.Count; i++)
            {
                if (this.Contacts[i].Id == id)
                {
                    contact1 = this.Contacts[i];
                    if (!String.IsNullOrEmpty(contactDto.Email))
                    {
                        contact1.Email = contactDto.Email;
                    }

                    if (!String.IsNullOrEmpty(contactDto.Name))
                    {
                        contact1.Name = contactDto.Name;
                    }

                    return;
                }

            }

        }


    }
}
