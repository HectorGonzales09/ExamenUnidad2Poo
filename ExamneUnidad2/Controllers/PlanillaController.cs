using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamneUnidad2.Services.Planilla;
using Microsoft.AspNetCore.Mvc;

namespace ExamneUnidad2.Controllers
{
    [Route("api/planillas")]
    [ApiController]
    public class PlanillaController : ControllerBase
    {
        private readonly IPlanillaService _Planillas;
    }
}