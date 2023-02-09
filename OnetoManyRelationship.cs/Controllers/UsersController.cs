using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnetoManyRelationship.cs.Data;
using OnetoManyRelationship.cs.Dto;

namespace OnetoManyRelationship.cs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper; 

        public UsersController(DataContext context , IMapper  mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IMapper Mapper { get; }

        [HttpGet("{id}")]
        public ActionResult<List<Character>> Get(int id)
        {
            var cha = _context.characters.Where(cha => cha.userid == id);
            if (cha is null)
                return BadRequest();
            return cha.ToList();
        }
        [HttpPost("User")]
        public List<User> Post(GetUser request)
        {
            _context.users.Add(_mapper.Map<User>(request));
            _context.SaveChanges();
            return (_context.users.ToList());
        }

        [HttpPost("Character")]
        public List<Character> Post(GetCharacter request)
        {
            _context.characters.Add(_mapper.Map<Character>(request));
            _context.SaveChanges();
            return (_context.characters.ToList());
        }

    }
}
