using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AngularSPA.Entities;
using AngularSPA.Modules;
using AngularSPA.Services;

namespace AngularSPA.Controllers
{

    public class CountriesController : ApiBaseController
    {
        private readonly ICountryService _countryService;

        public CountriesController(ICountryService countryService)
            : base()
        {
            _countryService = countryService;
        }

        [HttpGet]
        public ApiResponse<IList<Country>> GetAll()
        {
            var result = _countryService.GetAll();
            return new ApiResponse<IList<Country>>(result);

        }

        [HttpGet]
        public Country Get(int id)
        {
            return _countryService.Get(id);
        }

    }
}