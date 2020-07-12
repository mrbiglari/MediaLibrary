using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace MediaLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaController : ControllerBase
    {
        //GET api/media
        [HttpGet]
        public ActionResult<IEnumerable<object>> GetAllMedia()
        {
            return Ok();
        }

        //GET api/media/{id}
        [HttpGet("{id}", Name = "GetCommandById")]
        public ActionResult<object> GetMediaById(int id)
        {
            return Ok();
        }

        //POST api/media
        [HttpPost]
        public ActionResult<object> CreateMedia(object commandCreateDto)
        {
            return CreatedAtRoute(nameof(GetMediaById), new { Id = 0 }, new object());
        }

        //PUT api/media/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateMedia(int id, object commandUpdateDto)
        {
            return NoContent();
        }

        //PATCH api/media/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialUpdateMedia(int id, JsonPatchDocument<object> patchDoc)
        {
            return NoContent();
        }

        //DELETE api/media/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteMedia(int id)
        { 
            return NoContent();
        }
    }
}
