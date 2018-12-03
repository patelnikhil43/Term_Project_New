using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Utilities;

namespace TPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        //GET api/user/"name"
        [HttpGet("{name}")]
        public DataSet FindUsersByName(String name)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPFindUsersByName";
            objCommand.Parameters.Clear();

            objCommand.Parameters.AddWithValue("@theName", name);

            DataSet myUsers = objDB.GetDataSetUsingCmdObj(objCommand);

            return myUsers;
        }

        //CAN'T HAVE BOTH OF THESE IN THE SAME API!!!!

        //GET api/user/"organization"
        //[HttpGet("{organization}")]
        //public DataSet FindUsersByOrganization(String organization)
        //{
        //    objCommand.CommandType = CommandType.StoredProcedure;
        //    objCommand.CommandText = "TPFindUsersByOrganization";
        //    objCommand.Parameters.Clear();

        //    objCommand.Parameters.AddWithValue("@theOrganization", organization);

        //    DataSet myUsers = objDB.GetDataSetUsingCmdObj(objCommand);

        //    return myUsers;
        //}
    }
}