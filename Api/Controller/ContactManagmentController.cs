using Api.Storage; 
using Api.Contact;
using Api;
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
            Api.Contact.Contact contact;
            for (int i = 0; i < storage.Contacts.Count; i++)
            {
                if (storage.Contacts[i].Id == id)
                {
                    contact = storage.Contacts[i];
                    storage.Contacts.Remove(contact);
                    return;
                }

            }
        }
    }
}