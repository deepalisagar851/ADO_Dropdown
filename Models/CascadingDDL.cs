using ADO_Dropdown.Views.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ADO_Dropdown.Models
{
    public class CascadingDDL
    {
        private DbConfig db = new DbConfig();

        public List<Entity> GetCountries()
        {
            SqlCommand cmd = new SqlCommand("SP_GET_COUNTRY", db.sql);

            cmd.CommandType = CommandType.StoredProcedure;

            if (db.sql.State == ConnectionState.Closed)
                db.sql.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            List<Entity> countryList = new List<Entity>();
            while (reader.Read())
            {
                Entity obj = new Entity();
                obj.Id = (int)reader[0];
                obj.Name = reader[1].ToString();

                countryList.Add(obj);
            }
            db.sql.Close();
            return countryList;
        }


        public List<Entity> GetState(int id)
        {
            SqlCommand cmd = new SqlCommand("SP_GET_STATE", db.sql);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter.ParameterName = "@id";
            sqlParameter.Value = id;
            sqlParameter.DbType = DbType.Int32;
            cmd.Parameters.Add(sqlParameter);
                if (db.sql.State == ConnectionState.Closed)
                db.sql.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            List<Entity> stateList = new List<Entity>();
            while (reader.Read())
            {
                Entity obj = new Entity();
                obj.Id = (int)reader[0];
                obj.Name = reader[1].ToString();

                stateList.Add(obj);
            }
            db.sql.Close();
            return stateList;
        }



        public List<Entity> GetCity(int id)
        {
            SqlCommand cmd = new SqlCommand("SP_GET_CITY", db.sql);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter.ParameterName = "@id";
            sqlParameter.Value = id;
            sqlParameter.DbType = DbType.Int32;
            cmd.Parameters.Add(sqlParameter);
            if (db.sql.State == ConnectionState.Closed)
                db.sql.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            List<Entity> cityList = new List<Entity>();
            while (reader.Read())
            {
                Entity obj = new Entity();
                obj.Id = (int)reader[0];
                obj.Name = reader[1].ToString();

                cityList.Add(obj);
            }
            db.sql.Close();
            return cityList;
        }
    }
}