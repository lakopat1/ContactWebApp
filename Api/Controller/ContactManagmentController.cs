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
        public IActionResult Create(Api.Contact.Contact contact)
        {
            bool res = storage.AddContact(contact);

            if (res)
                return Ok(contact);
            else
                return Conflict("Контакт с указанным ID существует");
        }
            


        [HttpGet("contacts")]
        public IActionResult GetContacts()
        {
            return Ok(storage.GetContacts());
        }

        [HttpDelete("contacts/{id}")]
        public IActionResult DeleteContacts(int id)
        {
            bool res = storage.RemoveContact(id);

            if(res)
                return NoContent();
            else
                return BadRequest("Ошибка удаления");
        }

        [HttpPut("contacts/{id}")]
        public IActionResult UpdateContacts([FromBody] ContactDto contactDto, int id)
        {

            bool res = storage.UpdateConatct(contactDto, id);

            if(res)
                return Ok(contactDto);
            else
                return Conflict("Информация о контакте не обновилась");
        }
    }
}