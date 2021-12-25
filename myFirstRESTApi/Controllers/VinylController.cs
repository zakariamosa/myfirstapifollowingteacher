using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myFirstRESTApi.DTOs;
using myFirstRESTApi.Entities;
using myFirstRESTApi.Repo;

namespace myFirstRESTApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VinylController : ControllerBase
    {

        private readonly IVinylRepo _repo;

        public VinylController(IVinylRepo repo)
        {
            _repo = repo;

        }
        //Get/api/vinyl
        [HttpGet]
        [Route("")]
        public IActionResult GetVinyls()
        {
            var vinyls = _repo.GetAll().ToList().MapToVinylDTOs();
            return Ok(vinyls);

        }
        //Get/api/vinyl/:id
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetVinylByID(int id)
        {
            Vinyl vinyl = _repo.GetByID(id);
            if (vinyl == null)
            {
                return NotFound("could not find vinyl with id: " + id.ToString());
            }
            VinylDTO vinylDTO = MapVinylToVinylDTO(vinyl);
            return Ok(vinylDTO);
        }

        [HttpDelete("{id}")]
        
        public IActionResult DeleteVinyl(int Id)
        {
            _repo.DeleteVinyl(Id);
            return NoContent();
        }

        [HttpPost("")]
        public IActionResult CreateVinyl([FromBody]CreateVinylDTO createVinylDTO)
        {
            Vinyl createdVinyl=_repo.CreateVinyl(createVinylDTO);
            //VinylDTO vinylDTO= MapVinylToVinylDTO(createdVinyl);
            VinylDTO vinylSavedDTO=_repo.GetByID(createdVinyl.Id).MapToVinylDTO();
            return CreatedAtAction(nameof(GetVinylByID),new {id= vinylSavedDTO.Id}, vinylSavedDTO);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateVinyl([FromBody] Vinyl vinyl,int id)
        {
            Vinyl updatedVinyl=_repo.UpdateVinyl(vinyl, id);
            //VinylDTO updatedDTO = MapVinylToVinylDTO(vinyl);
            VinylDTO vinylDTO = _repo.GetByID(id).MapToVinylDTO();
            return Ok(vinylDTO);
        }

        private VinylDTO MapVinylToVinylDTO(Vinyl vinyl)
        {
            return new VinylDTO
            {
                Id = vinyl.Id,
                Title = vinyl.Title
            };
        }
    }
}
