using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.DAL
{
    //public class MyDatabase:IDisposable
    //{
    //    private string _ConnectionStringName;
    //    private SqlConnection _SqlConnection;
    //    private string _GetConnectionString(string connectionStringName)
    //    {
    //        return ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
    //    }
    //    public MyDatabase(string connectionStringName)
    //    {
    //        string connectionString = _GetConnectionString(connectionStringName);
    //        _ConnectionStringName = connectionStringName;
    //        _SqlConnection = new SqlConnection(connectionString);
    //    }
    //    public List<Skill> GetAllSkills()
    //    {
    //        List<Skill> skills = new List<Skill>();
    //        try
    //        {
    //            _SqlConnection.Open();
    //            using (SqlCommand sqlCommand=new SqlCommand("SELECT Id,Name FROM Skills",_SqlConnection))
    //            {
    //                using (SqlDataReader reader = sqlCommand.ExecuteReader())
    //                {
    //                    while (reader.Read())
    //                    {
    //                        Skill skill = new Skill
    //                        {
    //                            Id = Convert.ToInt32(reader["Id"].ToString()),
    //                            Name = reader["Name"].ToString()
    //                        };
    //                        skills.Add(skill);

    //                    }
    //                }

    //            }

    //        }catch(SqlException exp)
    //        {
    //            throw exp;
    //        }
    //        return skills;
    //    }
    //    public List<Person> GetAllPeople()
    //    {
    //        List<Person> people = new List<Person>();
    //        try
    //        {
    //            _SqlConnection.Open();
    //            using (SqlCommand sqlCommand = new SqlCommand("SELECT Id,Name,Age FROM People", _SqlConnection))
    //            {
    //                using (SqlDataReader reader = sqlCommand.ExecuteReader())
    //                {
    //                    while (reader.Read())
    //                    {
    //                        Person person = new Person
    //                        {
    //                            Id = Convert.ToInt32(reader["Id"].ToString()),
    //                            Name = reader["Name"].ToString(),
    //                            Age=Convert.ToInt32(reader["Age"].ToString())
    //                        };
    //                        people.Add(person);

    //                    }
    //                }

    //            }

    //        }
    //        catch (SqlException exp)
    //        {
    //            throw exp;
    //        }
    //        return people;
    //    }
    //    public void Dispose()
    //    {
    //        _SqlConnection.Dispose();
    //    }
    //}
    public class MyDB<T> : IDisposable
    {
        private string _ConnectionStringName;
        private SqlConnection _SqlConnection;
        private string _GetConnectionString(string connectionStringName)
        {
            return ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
        } 
        public string GetSelectCommand()
        {
            return "SELECT Id,Name FROM Skills";
        }

        //Reflection
        public MyDB(string connectionStringName)
        {
            string connectionString = _GetConnectionString(connectionStringName);
            _ConnectionStringName = connectionStringName;
            _SqlConnection = new SqlConnection(connectionString);
        }
        public T MapToModel(SqlDataReader sqlDataReader)
        {
            return default(T);
        }
       
        public List<T> GetAll()
        {
            List<T> entities = new List<T>();
            try
            {
                _SqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(GetSelectCommand(), _SqlConnection))
                {
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            T entity = MapToModel(reader);


                            entities.Add(entity);

                        }
                    }

                }

            }
            catch (SqlException exp)
            {
                throw exp;
            }
            return entities;
        }
     
        public void Dispose()
        {
            _SqlConnection.Dispose();
        }
    }
}
