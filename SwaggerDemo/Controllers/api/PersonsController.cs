using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SwaggerDemo.Controllers.api
{

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PersonsController : ApiController
    {
        // GET: api/Persons
        public IEnumerable<Person> Get()
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person() { Name = "Gene", Email = "gene.vangampelaere@howest.be" });
            persons.Add(new Person() { Name = "Jef", Email = "jef.daels@howest.be" });
            persons.Add(new Person() { Name = "Simon", Email = "simon.rosseel@howest.be" });

            return persons;
        }


        
    }


    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

}
