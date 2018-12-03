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
    public class FindFriendsController : ControllerBase
    {
        [HttpPost]
        [Route("FindFriendsDS")]
        public DataSet Post([FromBody] FindFriendsClass ffObject) {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPFindUsersByName";
            objCommand.Parameters.Clear();

            objCommand.Parameters.AddWithValue("@userEmail", ffObject.userEmail);

            DataSet mySearchResults = objDB.GetDataSetUsingCmdObj(objCommand);
            return mySearchResults;
        }
    }
}