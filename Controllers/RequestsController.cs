using CreateDictionary.Memory;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using DbGenerate.Kho;
using Microsoft.AspNetCore.Cors;

namespace ConsoleApplication
{
    
    public class requestsController
    {
        [HttpGet]
        [Route("api/[controller]")]
        public string Get()
        {
            var hd=MemoryInfor.GetAllHoaDon();
            return JsonConvert.SerializeObject(hd);
        }
        [HttpGet]
        [Route("api/[controller]/{id:int}")]
        public string Get(int id)
        {
            var hd=MemoryInfor.GetHoaDon(id);
            return JsonConvert.SerializeObject(hd);
        }
        [EnableCors("AllowAll")]
        [HttpPost]
        [Route("api/[controller]")]
        public string Post(HoaDon value){
            return "{\"state\":\"ok\"}";
        }
    }
}