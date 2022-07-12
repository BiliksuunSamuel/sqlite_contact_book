using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sqlitedb.model;
using System.Data;
using sqlitedb.controller;
using sqlitedb.utilities;
namespace sqlitedb.services
{
    public class PersonsServices
    {

        PersonController controller=new PersonController();
        public  List<PersonModel> GetPersons()
        {
            DataTable table=controller.GetPersons();
            List<PersonModel> persons = new List<PersonModel>();
            //foreach(DataRow row in table.Rows)
            //{
            //   persons.Add(row2Person(row));
            //}
            persons = controller.QueryPersons();
            return persons;

        }

        private PersonModel row2Person(DataRow info)
        {
            PersonModel person = new PersonModel();
            person.name = info["name"].ToString();
            person.id = info["id"].ToString();
            person.email = info["email"].ToString();
            person.phone = info["phone"].ToString();
            return person;
        }

        public void AddNewPerson(PersonModel model)
        {
            try
            {
                Utils.validatePerson(model);
                controller.AddPerson(model);
                Utils.handleMessage("Person Added Successfull", "Add Person");
            }
            catch (Exception ex)
            {

                Utils.handleException(ex);
            }
        }

        public void UpdatePerson(PersonModel model)
        {
            try
            {
                Utils.validatePerson(model);
                controller.UpdatePerson(model);
                Utils.handleMessage("Person Info Updated Successfull", "Update Person");
            }
            catch (Exception ex)
            {

                Utils.handleException(ex);
            }
        }

        public void DeletePerson(PersonModel model) {
            try
            {
                controller.DeletePerson(model);
                Utils.handleMessage("Person Deleted Successfully", "Delete Person");
            }
            catch (Exception ex)
            {

                Utils.handleException(ex);
            }
        }

        public DataTable SearchPerson(PersonModel model) {
            try
            {
                return controller.SearchPerson(model);
            }
            catch (Exception )
            {

                throw;
            }
        }

        
    }
}
