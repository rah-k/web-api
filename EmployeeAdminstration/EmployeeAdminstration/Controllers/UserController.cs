using EmployeeAdminstration.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAdminstration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public UserController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string querry = @"
                            select DepartmentId,DepartmentName from dbo.DepartmentData
                            ";
            DataTable table = new DataTable();
            string sqlDatSource = _configuration.GetConnectionString("DbContetext");
            SqlDataReader myReader;
            using (SqlConnection mycon = new SqlConnection(sqlDatSource))
            {
                mycon.Open();
                using (SqlCommand mycommand = new SqlCommand(querry, mycon))
                {
                    myReader = mycommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult(table);
        }
        [HttpGet("{Id}")]
        public JsonResult GetUser(int Id)
        {
            string querry = @"
                            Select DepartmentId,DepartmentName from dbo.DepartmentData  where DepartmentId = @DepartmentId

                            ";
            DataTable table = new DataTable();
            string sqlDatSource = _configuration.GetConnectionString("DbContetext");
            SqlDataReader myReader;
            using (SqlConnection mycon = new SqlConnection(sqlDatSource))
            {
                mycon.Open();
                using (SqlCommand mycommand = new SqlCommand(querry, mycon))
                {
                    mycommand.Parameters.AddWithValue("@DepartmentId", Id);

                    myReader = mycommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult(table);
        }
        [HttpPost]
        public JsonResult Post(DepartmentData dep)
        {
            string querry = @"
                            Insert into dbo.DepartmentData
                            values(@DepartmentName)
                            ";
            DataTable table = new DataTable();
            string sqlDatSource = _configuration.GetConnectionString("DbContetext");
            SqlDataReader myReader;
            using (SqlConnection mycon = new SqlConnection(sqlDatSource))
            {
                mycon.Open();
                using (SqlCommand mycommand = new SqlCommand(querry, mycon))
                {
                    mycommand.Parameters.AddWithValue("@DepartmentName", dep.DepartmentName);
                    myReader = mycommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult("Added Succesffully");
        }
        [HttpPut]
        public JsonResult Put(DepartmentData dep)
        {
            string querry = @"
                            Update dbo.DepartmentData set DepartmentName =@DepartmentName where DepartmentId = @DepartmentId

                            ";
            DataTable table = new DataTable();
            string sqlDatSource = _configuration.GetConnectionString("DbContetext");
            SqlDataReader myReader;
            using (SqlConnection mycon = new SqlConnection(sqlDatSource))
            {
                mycon.Open();
                using (SqlCommand mycommand = new SqlCommand(querry, mycon))
                {
                    mycommand.Parameters.AddWithValue("@DepartmentId", dep.DepartmentId);
                    mycommand.Parameters.AddWithValue("@DepartmentName", dep.DepartmentName);
                    myReader = mycommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult("Update is Succesffully");
        }
        [HttpDelete("{Id}")]
        public JsonResult Delete(int Id)
        {
            string querry = @"
                            Delete from dbo.DepartmentData  where DepartmentId = @DepartmentId

                            ";
            DataTable table = new DataTable();
            string sqlDatSource = _configuration.GetConnectionString("DbContetext");
            SqlDataReader myReader;
            using (SqlConnection mycon = new SqlConnection(sqlDatSource))
            {
                mycon.Open();
                using (SqlCommand mycommand = new SqlCommand(querry, mycon))
                {
                    mycommand.Parameters.AddWithValue("@DepartmentId",Id);
                   
                    myReader = mycommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult("Data was removed");
        }
    }
}
