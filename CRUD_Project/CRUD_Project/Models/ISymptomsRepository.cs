using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_Project.Controllers;

namespace CRUD_Project.Models
{
    interface ISymptomsRepository
    {

        // We need to store a collection of symptoms. 
        //It's a good idea to separate the collection from our service implementation. 
        //That way, we can change the backing store without rewriting the service class. 
        //This type of design is called the repository pattern. 
        //Start by defining a generic interface for the repository.*\

        //Gain access to the database
        public string Connection
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            }
        }

        public DataTable  GetData(string query)

        {

            DataTable dt = new DataTable();

            using (SqlConnection myConnection = new SqlConnection(Connection))

            {

                using (SqlCommand myCommand = new SqlCommand(query, myConnection))

                {

                    myCommand.CommandType = CommandType.Text;

                    using (SqlDataAdapter da = new SqlDataAdapter(myCommand))

                    {

                        da.Fill(dt);

                        return dt;

                    }

                }

            }

        }


        IEnumerable<Symptom> All { get; }

        Symptom Get(int id);
        Symptom Add(Symptom item);
        void Remove(int id);
        bool Update(Symptom item);
        IEnumerable<Symptom> GetAll();
        Symptom GetAll(int id);
    }
}
