using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_Project.Models
{
    public class Symptoms
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symptom_Type { get; set; }
        public decimal Description { get; set; }
    }
}