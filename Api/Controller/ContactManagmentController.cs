using Api.Storage;  // ← добавить эту строку
using Api.Contact;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controller
{
    public class ContactManagmentController : Basecontroller
    {
        private readonly ContactStorage storage;
        public ContactManagmentController(ContactStorage storage)
        {
            this.storage = storage;
        }

        [HttpPost("contacts")]
        public void Create(Api.Contact.Contact contact)
        {
            storage.Contacts.Add(contact);
        }

        [HttpGet("contacts")]
        public List<Api.Contact.Contact> GetContacts()
        {
            return storage.Contacts;
        }

        [HttpDelete("contacts/{id}")]
        public void DeleteContacts(int id)
        {
            for (int i = 0; i < storage.Contacts.Count; i++)
            {
                if (storage.Contacts[i].Id == id)
                {
                    storage.Contacts.RemoveAt(i);
                }

            }
        }
    }
}