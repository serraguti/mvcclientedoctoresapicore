using Microsoft.AspNetCore.Mvc;
using MvcDoctoresClienteApi.Models;
using MvcDoctoresClienteApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcDoctoresClienteApi.Controllers
{
    public class DoctoresController : Controller
    {
        ServiceApiDoctores service;

        public DoctoresController(ServiceApiDoctores service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DoctoresClienteAjax()
        {
            return View();
        }

        public async Task<IActionResult> DoctoresServidor()
        {
            List<Doctor> doctores = await this.service.GetDoctoresAsync();
            return View(doctores);
        }
    }
}
