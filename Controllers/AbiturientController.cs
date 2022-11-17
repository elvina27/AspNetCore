using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using AspNetCore.Models;

namespace AspNetCore.Controllers
{
    [Route("AbiturientRegisty/[controller]")]
    [ApiController]
    public class AbiturientController : ControllerBase
    {
        private static readonly IList<Abiturient> Abiturients = new List<Abiturient>();

        [HttpGet]
        public IEnumerable<Abiturient> Get()
        {
            var abiturient = new Abiturient();
            abiturient.Sum = abiturient.Matem * abiturient.Rus * abiturient.Inf;
            return Abiturients;
        }
        [HttpGet("stats")]
        public Statistic GetStatistic()
        {
            var result = new Statistic
            {
                Count = Abiturients.Count,
                SumGood = Abiturients.Where(x => x.Sum > 150).Count()
            };
            return result;
        }

        [HttpPost]
        public Abiturient Add(AddAbiturientModel model)
        {
            var abitur = new Abiturient
            {
                Id = Guid.NewGuid(),
                FullName = model.FullName,
                Gender = model.Gender,
                Birthday = model.Birthday,
                FormaObucheniya = model.FormaObucheniya,
                Matem = model.Matem,
                Rus = model.Rus,
                Inf = model.Inf,
                Sum = model.Matem + model.Rus + model.Inf
            };
            Abiturients.Add(abitur);
            return abitur;
        }

        [HttpPut("{id:guid}")]
        public Abiturient Update([FromRoute] Guid id, [FromBody] AddAbiturientModel model)
        {
            var upabitur = Abiturients.FirstOrDefault(x => x.Id == id);
            if (upabitur != null)
            {
                upabitur.FullName = model.FullName;
                upabitur.Gender = model.Gender;
                upabitur.Birthday = model.Birthday;
                upabitur.FormaObucheniya = model.FormaObucheniya;
                upabitur.Matem = model.Matem;
                upabitur.Rus = model.Rus;
                upabitur.Inf = model.Inf;
                upabitur.Sum = model.Matem + model.Rus + model.Inf;
            }
            return upabitur;
        }

        [HttpDelete("{id:guid}")]
        public bool Remove(Guid id)
        {
            var reabitur = Abiturients.FirstOrDefault(x => x.Id == id);
            if (reabitur != null)
            {
                return Abiturients.Remove(reabitur);
            }
            return false;
        }
    }
}
