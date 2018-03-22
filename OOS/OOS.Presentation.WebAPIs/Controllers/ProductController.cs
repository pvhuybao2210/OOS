﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OOS.Presentation.ApplicationLogic.Products;
using OOS.Presentation.ApplicationLogic.Products.Messages;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OOS.Presentation.WebAPIs.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductsBusinessLogic _productsBusinessLogic;

        public ProductController(IProductsBusinessLogic productsBusinessLogic)
        {
            _productsBusinessLogic = productsBusinessLogic;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            var products = _productsBusinessLogic.GetProduct();
            return Ok(products);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var result = _productsBusinessLogic.GetProduct(id);
            return Ok(result);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]CreateProductRequest value)
        {
            var rs = _productsBusinessLogic.CreateProduct(value);
            return Ok(rs);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody]EditProductResquest request)
        {
            _productsBusinessLogic.EditProduct(id, request);
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            _productsBusinessLogic.DeleteProduct(id);
            return Ok();
        }

        [HttpGet]
        [Route("{code}/checkexistedcode")]
        public IActionResult checkExistedCode(string code)
        {
            CheckExistedCodeResponse response = new CheckExistedCodeResponse();
            response.IsCodeExisted = _productsBusinessLogic.checkExistedCode(code);
            return Ok(response);
        }

        [HttpGet]
        [Route ("{keyword}/searchproduct")]
        public IActionResult searchProduct(string keyword)
        {
            var products = _productsBusinessLogic.SearchProduct(keyword);
            return Ok(products);
        }

        [HttpGet]
        [Route("{widget}/widget")]
        public IActionResult widgetProduct(string widget)
        {
            var products = _productsBusinessLogic.ProductWidget(widget);
            return Ok(products);
        }

        //Get product base on ID Category
        [HttpGet]
        [Route("{idCategory}/category")]
        public IActionResult GetProductBaseOnIDCategory(string idCategory)
        {
            var products = _productsBusinessLogic.GetProductsBaseOnIDCategory(idCategory);
            return Ok(products);
        }

        [HttpGet]
        [Route("{idCategory}&{keyword}/search")]
        public IActionResult searchProductByIdCategory(string idCategory, string keyword)
        {
            var products = _productsBusinessLogic.SearchProductByIdCategory(idCategory, keyword);
            return Ok(products);
        }
    }
}