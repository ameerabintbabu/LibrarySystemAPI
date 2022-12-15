using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LibrarySystemAPI.Controllers
{
    public class CategoryController : ApiController
    {
        LibrarySystemDB lb = new LibrarySystemDB();

        [HttpGet]
        public IHttpActionResult GetSubCategory(int CategoryId)
        {
            var result = lb.GetAllSubCategoryByParentId(CategoryId).ToList();
            return Ok(result);
        }



        [HttpGet]
        public IHttpActionResult GetAllParentCategory()
        {
            var result = lb.GetAllParentCategory().ToList();
            return Ok(result);
        }


        
    }
}
