﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcDoctoresClienteApi.Models
{
    public class Doctor
    {
        public int IdDoctor { get; set; }
        public String Apellido { get; set; }
        public String Especialidad { get; set; }
        public int Salario { get; set; }
        public int Hospital { get; set; }
    }
}
