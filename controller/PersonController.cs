using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sqlitedb.app_configuration;
using sqlitedb.model;
using sqlitedb.utilities;
using System.Data;
using System.Data.SQLite;
using System.Configuration;
using Dapper;

namespace sqlitedb.controller
{
    public class PersonController
    {
        RootConfiguration root = new RootConfiguration();
        public  DataTable GetPersons()
        {
            try
            {
                string command = "select * from persons";
                root.da = new SQLiteDataAdapter();
                root.dt = new DataTable();
                root.cmd = new SQLiteCommand(command,root.Connection());
                root.da.SelectCommand = root.cmd;
                root.da.Fill(root.dt);
                return root.dt;
            }catch(Exception ex)
            {
                throw ex;
            }


        }

        public List<PersonModel> QueryPersons()
        {
            try
            {
                List<PersonModel> list = new List<PersonModel>();
                using (IDbConnection conn = root.Connection())
                {
                    var output = conn.Query<PersonModel>("select * from persons", new DynamicParameters());
                    list = output.ToList();
                }
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AddPerson(PersonModel model)
        {
            try
            {
                if (GetPersonByEmail(model).Rows.Count > 0)
                {
                    throw new Exception("email address already exist");
                }
                if (GetPersonByPhone(model).Rows.Count > 0)
                {
                    throw new Exception("phone number already exist");
                }
                if (GetPersonById(model).Rows.Count > 0)
                {
                    model.id = Utils.generateOTP();
                }
                
                string command = "insert into persons(id,name,phone,email) values(@id,@name,@phone,@email)";
                using (IDbConnection con = root.Connection())
                {
                    con.Execute(command, model);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdatePerson(PersonModel model)
        {
            try
            {
                
                string command = "update persons set name=@name,phone=@phone,email=@email where id=@id";
                root.cmd = new SQLiteCommand(command, root.Connection());
                root.cmd.Parameters.Add("@id", (DbType)SqlDbType.VarChar).Value = model.id;
                root.cmd.Parameters.Add("@name", (DbType)SqlDbType.VarChar).Value = model.name;
                root.cmd.Parameters.Add("@phone", (DbType)SqlDbType.VarChar).Value = model.phone;
                root.cmd.Parameters.Add("@email", (DbType)SqlDbType.VarChar).Value = model.email;

                root.openConnection();
                root.cmd.ExecuteNonQuery();
                root.closeConnection();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeletePerson(PersonModel model)
        {
            try
            {
                string command = "delete from persons where id=@id";
                root.cmd = new SQLiteCommand(command, root.Connection());
                root.cmd.Parameters.Add("@id", (DbType)SqlDbType.VarChar).Value = model.id;
                root.openConnection();
                root.cmd.ExecuteNonQuery();
                root.closeConnection();
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// search person
        /// </summary>
        /// <returns></returns>
        public DataTable SearchPerson(PersonModel model)
        {
            try
            {
                string cmd = string.Format("select * from persons where  (name like '%{0}%' or email like '%{1}%' or phone like '%{2}%')", model.name, model.email, model.phone);
                root.cmd= new SQLiteCommand(cmd, root.Connection());
                root.da = new SQLiteDataAdapter();
                root.dt = new DataTable();
                root.openConnection();
                root.da.SelectCommand = root.cmd;
                root.da.Fill(root.dt);
                root.closeConnection();
                return root.dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable GetPersonById(PersonModel model)
        {
            try
            {
                root.da = new SQLiteDataAdapter();
                root.dt = new DataTable();
                string command = "select * from persons where id=@id";
                root.cmd = new SQLiteCommand(command, root.Connection());
                root.cmd.Parameters.Add("@id", (DbType)SqlDbType.VarChar).Value = model.id;
                root.openConnection();
                root.da.SelectCommand = root.cmd;
                root.da.Fill(root.dt);
                root.closeConnection();
                return root.dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable GetPersonByEmail(PersonModel model)
        {
            try
            {
                root.da = new SQLiteDataAdapter();
                root.dt = new DataTable();
                string command = "select * from persons where email=@email";

                root.cmd = new SQLiteCommand(command, root.Connection());
                root.cmd.Parameters.Add("@email", (DbType)SqlDbType.VarChar).Value = model.email;
                root.openConnection();
                root.da.SelectCommand = root.cmd;
                root.da.Fill(root.dt);
                root.closeConnection();
                return root.dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable GetPersonByPhone(PersonModel model)
        {
            try
            {
                root.da = new SQLiteDataAdapter();
                root.dt = new DataTable();
                string command = "select * from persons where phone=@phone";

                root.cmd = new SQLiteCommand(command, root.Connection());
                root.cmd.Parameters.Add("@phone", (DbType)SqlDbType.VarChar).Value = model.phone;
                root.openConnection();
                root.da.SelectCommand = root.cmd;
                root.da.Fill(root.dt);
                root.closeConnection();
                return root.dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
