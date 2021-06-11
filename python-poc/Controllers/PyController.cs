using Microsoft.AspNetCore.Mvc;
using Python.Runtime;

namespace python_poc.Controllers
{
    [ApiController]
    [Route("py")]
    public class PyController : Controller
    {
        [HttpGet]
        public string Get()
        {
            Person person = new("John", "Smith");
            string fullNameStr;

            using (Py.GIL())
            {
                // create a Python scope
                using PyScope scope = Py.CreateScope();

                // convert the Person object to a PyObject
                PyObject pyPerson = person.ToPython();

                // create a Python variable "person"
                scope.Set("person", pyPerson);

                // the person object may now be used in Python
                string code = "fullName = person.FirstName + ' ' + person.LastName";
                scope.Exec(code);

                PyObject fullName = scope.Get("fullName");
                fullNameStr = fullName.As<string>();
            }

            return fullNameStr;
        }
    }
}
