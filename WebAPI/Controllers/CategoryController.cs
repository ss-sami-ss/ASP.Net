using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebAPI.Models.ViewModel;
using Newtonsoft.Json.Linq;



namespace WebAPI.Controllers
{
    public class CategoryController : ApiController
    {
        #region [- ctor -]
        public CategoryController()
        {
            Ref_CategoryViewModel = new CategoryViewModel();
        }
        #endregion

        #region [- Props -]
        public CategoryViewModel Ref_CategoryViewModel { get; set; }
        #endregion

        #region [- Get_Category() -]
        [Route("wapi/vi/Category/Get")]
        public async Task<IHttpActionResult> Get_Category()
        {
            var categoryList = await Ref_CategoryViewModel.Get_Category();
            return Ok(new { categoryList });
        }

        #endregion

        #region [- Post_Category(JObject jObject) -]
        [HttpPost]
        [Route("wapi/v1/Category/Post")]
        public IHttpActionResult Post_Category(JObject jObject)
        {
            CategoryViewModel category = jObject["category"].ToObject<CategoryViewModel>();
            Ref_CategoryViewModel.Post_Category(category);
            return Ok();

        } 
        #endregion
    }
}
