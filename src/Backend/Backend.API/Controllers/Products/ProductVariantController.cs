﻿using Backend.Domain.Entities.Products;
using Backend.Infrastructure.Services.Products;
using Microsoft.AspNetCore.Mvc;

namespace Backend.API.Controllers.Products
{
    [ApiController]
    [Route("ProductVariants")]
    public class ProductVariantController : ControllerBase
    {
        private readonly ProductVariantService _productVariantService;
        public ProductVariantController(ProductVariantService productVariantService)
        {
            _productVariantService = productVariantService;
        }

        [HttpGet]
        [Route("GetAllVariantsByProduct")]
        public ActionResult GetAllVariantsByProduct(Guid tenantId, Guid productId)
        {
            try
            {
                return Ok(_productVariantService.GetAllVariantsByProduct(tenantId, productId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult> CreateVariant(ProductVariant model)
        {
            try
            {
                return Ok(await _productVariantService.CreateVariantBasedParentProduct(model));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}