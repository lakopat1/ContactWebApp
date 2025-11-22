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
            storage.AddContact(contact);
        }

        [HttpGet("contacts")]
        public List<Api.Contact.Contact> GetContacts()
        {
            return storage.GetContacts();
        }

        [HttpDelete("contacts/{id}")]
        public void DeleteContacts(int id)
        {
            storage.RemoveContact(id);
        }

        [HttpPut("contacts/{id}")]
        public void UpdateContacts([FromBody] ContactDto contactDto, int id)
        {

            storage.UpdateConatct(contactDto, id);
        }
    }
}