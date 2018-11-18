using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ExerciseApi.Models;

namespace ExerciseApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly ExerciseContext _context;

        public ExerciseController(ExerciseContext context)
        {
            _context = context;

            //if (_context.Exercises.Count() == 0 )
            //{
                // Create a new Exercise if collection is empty,
                // which means you can't delete all.Exercises.
                _context.Exercises.Add(new Exercise { name = "NoExercisesAdded" });
                _context.SaveChanges();
            //}
        }

        [HttpGet("/test")]
        public ActionResult<IEnumerable<string>> Get(){
                return new string[] { "Exersice1", "Exercise2" };
        }

        [HttpGet]
        public ActionResult<List<Exercise>> GetAll()
        {
            return _context.Exercises.ToList();
        }

        [HttpGet("{id}", Name = "GetExercise")]
        public ActionResult<Exercise> GetById(long id)
        {
            var item = _context.Exercises.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;   
        }
    }
}