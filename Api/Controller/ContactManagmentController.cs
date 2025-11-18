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
            
        }
    }


    
}
