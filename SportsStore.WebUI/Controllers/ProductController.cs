﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;

namespace SportsStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductsRepository repository;

        public ProductController(IProductsRepository repositoryParam)
        {
            repository = repositoryParam;
        }

        public ActionResult List()
        {
            return View(repository.Products);
        }
    }
}