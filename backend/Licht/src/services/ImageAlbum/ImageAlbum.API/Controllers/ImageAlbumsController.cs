using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImageAlbum.Application.ImageAlbum.Commands.AddAlbum;
using ImageAlbum.Application.ImageAlbum.Commands.DeleteItem;
using ImageAlbum.Application.ImageAlbum.Commands.UpdateAlbum;
using ImageAlbum.Application.ImageAlbum.Quieries.GetAlbumById;
using ImageAlbum.Application.ImageAlbum.Quieries.GetAlbums;
using LichtDataPack.Dtos.ImageAlbum;
using MediatR;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ImageAlbum.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageAlbumsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ImageAlbumsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<ImageAlbumsController>
        [HttpGet]
        public async Task<IActionResult> GetAllAlbums()
        {
            var query = new GetAllAlbumsQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        // GET api/<ImageAlbumsController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetAlbumByIdQuery(id);
            var result = await _mediator.Send(query);
            return result != null ? (IActionResult)Ok(result) : NotFound(result);
        }

        // POST api/<ImageAlbumsController>
        [HttpPost]
        public async Task<IActionResult> AddAlbum([FromBody] ImageAlbumDto albumDto)
        {
            var query = new AddAlbumCommand(albumDto);
            var result = await _mediator.Send(query);
            return result == true ? (IActionResult)Ok(result) : BadRequest(result);
        }

        // PUT api/<ImageAlbumsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAlbum([FromBody] ImageAlbumDto albumDto)
        {
            var query = new UpdateAlbumCommand(albumDto);
            var result = await _mediator.Send(query);
            return result == true ? (IActionResult)Ok(result) : BadRequest(result);
        }

        // DELETE api/<ImageAlbumsController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var query = new DeleteAlbumCommand(id);
            var result = await _mediator.Send(query);
            return result == true ? (IActionResult)Ok(result) : BadRequest(result);
        }
    }
}
