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
    public class ProductController : ApiController
    {
        #region [- ctor -]
        public ProductController()
        {
            Ref_ProductViewModel = new ProductViewModel();
        }
        #endregion

        #region [- Props -]
        public ProductViewModel Ref_ProductViewModel { get; set; }
        #endregion

        #region [- Get_Product() -]
        [Route("wapi/vi/Product/Get")]
        public async Task<IHttpActionResult> Get_Product()
        {
            var productList = await Ref_ProductViewModel.Get_Product();
            return Ok(new { productList });
        }

        #endregion

        #region [- Post_Product(JObject jObject) -]
        [HttpPost]
        [Route("wapi/v1/Product/Post")]
        public IHttpActionResult Post_Product(JObject jObject)
        {
            ProductViewModel produc = jObject["category"].ToObject<ProductViewModel>();
            Ref_ProductViewModel.Post_Product(produc);
            return Ok();

        }
        #endregion
    }
}
