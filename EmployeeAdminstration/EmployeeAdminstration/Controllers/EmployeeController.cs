using EmployeeAdminstration.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAdminstration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _env;

        public EmployeeController(IConfiguration configuration, IWebHostEnvironment env)
        {
            _configuration = configuration;
            _env = env;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string querry = @"
                            select EmployeeId,EmployeeName,Department,convert(varchar(10),DataofJoining,120) as DataofJoining,PhotofileName from dbo.EmployeeData
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
                            Select  EmployeeId,EmployeeName,Department,convert(varchar(10),DataofJoining,120) as DataofJoining,PhotofileName from dbo.EmployeeData  where EmployeeId = @EmployeeId

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
        public JsonResult Post(EmployeeData emp)
        {
            string querry = @"
                            Insert into dbo.EmployeeData
                            (EmployeeName,Department,DataofJoining,PhotofileName)
                            values(@EmployeeName,@Department,@DataofJoining,@PhotofileName)
                            ";
            DataTable table = new DataTable();
            string sqlDatSource = _configuration.GetConnectionString("DbContetext");
            SqlDataReader myReader;
            using (SqlConnection mycon = new SqlConnection(sqlDatSource))
            {
                mycon.Open();
                using (SqlCommand mycommand = new SqlCommand(querry, mycon))
                {
                    mycommand.Parameters.AddWithValue("@EmployeeName", emp.EmployeeName);
                    mycommand.Parameters.AddWithValue("@Department", emp.Department);
                    mycommand.Parameters.AddWithValue("@DataofJoining", emp.DataofJoining);
                    mycommand.Parameters.AddWithValue("@PhotofileName", emp.PhotofileName);
                    myReader = mycommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult("Added Succesffully");
        }
        [HttpPut]
        public JsonResult Put(EmployeeData emp)
        {
            string querry = @"
                            Update dbo.EmployeeData set EmployeeName =@EmployeeName,Department = @Department,DataofJoining = @DataofJoining ,PhotofileName = @PhotofileName where EmployeeId = @EmployeeId

                            ";
            DataTable table = new DataTable();
            string sqlDatSource = _configuration.GetConnectionString("DbContetext");
            SqlDataReader myReader;
            using (SqlConnection mycon = new SqlConnection(sqlDatSource))
            {
                mycon.Open();
                using (SqlCommand mycommand = new SqlCommand(querry, mycon))
                {
                    mycommand.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
                    mycommand.Parameters.AddWithValue("@EmployeeName", emp.EmployeeName);
                    mycommand.Parameters.AddWithValue("@Department", emp.Department);
                    mycommand.Parameters.AddWithValue("@DataofJoining", emp.DataofJoining);
                    mycommand.Parameters.AddWithValue("@PhotofileName", emp.PhotofileName);
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
                            Delete from dbo.EmployeeData  where EmployeeId = @EmployeeId

                            ";
            DataTable table = new DataTable();
            string sqlDatSource = _configuration.GetConnectionString("DbContetext");
            SqlDataReader myReader;
            using (SqlConnection mycon = new SqlConnection(sqlDatSource))
            {
                mycon.Open();
                using (SqlCommand mycommand = new SqlCommand(querry, mycon))
                {
                    mycommand.Parameters.AddWithValue("@EmployeeId", Id);

                    myReader = mycommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult("Data was removed");
        }
        [Route("SaveFile")]
        [HttpPost]
        public JsonResult SaveFile()
        {
            try
            {
                var httprequest = Request.Form;
                var postedFile = httprequest.Files[0];
                string filename = postedFile.FileName;
                var physicalpath = _env.ContentRootPath + "/Photos/" + filename;

                using(var stream = new FileStream(physicalpath,FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                }
                return new JsonResult(filename);
            }
            catch(Exception e)
            {
                return new JsonResult("Anonymous.png");
            }
        }
    }

}
