using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shopping.Dtos;
using Shopping.Models;
using Shopping.Repository;

namespace Shopping.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public UserController(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<UserReadDto>> Get()
        {
            var user = await _repository.GetUsersAsync();
            var UserReadDto = _mapper.Map<IEnumerable<UserReadDto>>(user);
            return Ok(UserReadDto);
        }

        [HttpGet]
        [Route("id:guid")]
        public async Task<ActionResult> GetById(Guid id)
        {
            var user = await _repository.GetUserAsync(id);
            if (user == null) return NotFound("User Not Found");
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<UserReadDto>> Post(UserCreateDto userCreateDto)
        {
            var userModel = _mapper.Map<User>(userCreateDto);
            await _repository.PostAsync(userModel);

            var UserReadDto = _mapper.Map<UserReadDto>(userModel);
            return CreatedAtAction("Get", new { id = userModel.Id }, userModel);
        }

        [HttpDelete]
        public ActionResult Delete(Guid id)
        {
            _repository.Delete(id);
            return NoContent();
        }


    }
}