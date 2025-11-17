using Api.Storage;
using Microsoft.AspNetCore.Mvc;
namespace Api.Controller
{
    public class StorageController : ControllerBase
    {
        private DataContext dataContext;

        public StorageController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet("SetString/{value}")]
        public void SetString(string value)
        {
            dataContext.Str = value;
        }

        [HttpGet("GetString")]
        public string GetString()
        {
            return dataContext.Str;
        }
    }
}
