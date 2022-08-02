using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/Person")]
    public class PersonController : ApiController
    {
        static List<Person> personlist = new List<Person>()
        {
            new Person{Id=1, Name="Kamal",City="Pune"},
            new Person{Id=2, Name="Prem",City="Hyderabad"},
            new Person{Id=3, Name="Shivam",City="Bangalore"},
            new Person{Id=4, Name="Akshay",City="Mumbai"},
        };
        [HttpGet]
          [Route("persondetails")]

        public IEnumerable<Person> Get()
        {
            return personlist;
        }

        [HttpGet]
        [Route("personlist")]

        public HttpResponseMessage GetPersonList()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, personlist);
            return response;
        }

        [HttpGet]
        [Route("p")]
        public HttpResponseMessage GetP(int pid)
        {
            var person = personlist.Find(x => x.Id == pid);

            if (person == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, pid);
            }
            return Request.CreateResponse(HttpStatusCode.OK, person);
        }

        
        //Post

        public Person Post([FromBody]Person p)
        {
            personlist.Add(p);
            return p;
        }

        //put
        public IEnumerable<Person> Put(int id,[FromBody] Person person)
        {
            personlist[id - 1] = person;
            return personlist;
        }

        [HttpGet]
        [Route("ById")]
        public IHttpActionResult GetID(int pid)
        {
            var person = personlist.Find(x => x.Id == pid);

            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }

        [HttpGet]
        [Route("Name")]
        public IHttpActionResult GetName(int pid)
        {
            string person = personlist.Where(x => x.Id == pid).SingleOrDefault()?.Name;

            if (person == null)
            {
                return NotFound();
            }
           // return Ok(person);
            return new MyResult(person, Request);


        }
    }
}
