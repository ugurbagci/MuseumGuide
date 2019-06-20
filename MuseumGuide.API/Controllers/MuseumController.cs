using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MuseumGuide.Data.Abstract;
using MuseumGuide.DTO;
using MuseumGuide.Entity.Models;

namespace MuseumGuide.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MuseumController : Controller
    {
        private IAppRepository _appRepository;
        private IMapper _mapper;

        public MuseumController(IAppRepository appRepository, IMapper mapper)
        {
            _appRepository = appRepository;
            _mapper = mapper;
        }
        public ActionResult GetMuseums()
        {
            var museums = _appRepository.GetMuseums();
            var museumsToReturn = _mapper.Map<List<MuseumForList>>(museums);
            return Ok(museumsToReturn);
        }

        [HttpPost]
        [Route("add")]
        public ActionResult Add([FromBody]Museum museum)
        {
            _appRepository.Add(museum);
            _appRepository.SaveAll();
            return Ok(museum);

        }

        [HttpGet]
        [Route("detail")]
        public ActionResult GetMuseumById(int id)
        {
            var museum = _appRepository.GetMuseumById(id);
            var museumToReturn = _mapper.Map<MuseumForDetail>(museum);
            return Ok(museumToReturn);
        }

        [HttpGet]
        [Route("Photos")]
        public ActionResult GetPhotosByMuseum(int museumId)
        {
            var photos = _appRepository.GetPhotosByMuseum(museumId);
            return Ok(photos);
        }

    }
}