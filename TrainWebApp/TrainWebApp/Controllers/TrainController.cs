using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TrainWebApp.Controllers
{
    public class TrainController : ApiController
    {
        private readonly Data.ITrainRepository _repository;
        public TrainController(Data.ITrainRepository repository)
        {
            _repository = repository;
        }
        public IHttpActionResult Get()
        {
            return Ok(new { Nae = "Samudra", SOurce = "Vizag" });
        }
    }
}