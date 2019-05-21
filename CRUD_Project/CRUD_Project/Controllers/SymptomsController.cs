using CRUD_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//add using Symptoms.Models;

namespace CRUD_Project.Controllers
{
    public class SymptomsController : ApiController
    {
        // add read function to read all the 
        //add an isntance of the repo
        static readonly ISymptomsRepository repository = new SymptomsRepository();

        //To get the list of all symptoms, add this method to the SymptomsController class:
        public IEnumerable<Symptom> GetAllSymptoms()
        {
            return repository.All;
        }
        // ....
        ///

        public Symptom GetSymptom(int id)
        {
            Symptom item = repository.GetAll(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

        //Get sysmptom by the type of symptom it is
        //public IEnumerable<Symptom> GetSymptomsByCategory(string category)
        //{
        //    return repository.GetAll().Where(
        //        p => string.Equals(p.Symptom_Type,
        //                           category,
        //                           StringComparison.OrdinalIgnoreCase));
        //}
    }
}
