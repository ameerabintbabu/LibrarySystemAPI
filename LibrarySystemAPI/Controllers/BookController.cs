using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LibrarySystemAPI.Controllers
{
    
    public class BookController : ApiController
    {
        LibrarySystemDB lb = new LibrarySystemDB();
        [HttpGet]
        public IHttpActionResult Book(int? ParentCategoryId,int? SubCategoryId)
        {
            var result = lb.GetAllBooks(SubCategoryId, ParentCategoryId).ToList();
            return Ok(result);
        }


       

    }
}
