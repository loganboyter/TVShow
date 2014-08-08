using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TvShow2.Data.Models;
using TVShow2.Web.Adapters;
using TVShow2.Web.Adapters.Interfaces;
using TVShow2.Web.Models;

namespace TVShow2.Web.Controllers
{
    public class apiTvShowController : ApiController
    {
        private ITvShow _adapter;
        public apiTvShowController()
        {
            _adapter = new TvShowAdapter();
        }
        [HttpGet]
        public IHttpActionResult Get(int id = -1)
        {
            if (id == -1) return Ok(_adapter.GetShows()); // if no id is provided, get all shows
            else return Ok(_adapter.GetShow(id));         // if an id is provided, getshow
        }
        [HttpPost]
        public IHttpActionResult Post(TvShow show)
        {
            _adapter.CreateShow(show);
            return Ok();
        }
        [HttpPut]
        public IHttpActionResult Put(TvShow show, int id)
        {
            _adapter.UpdateShow(show, id);
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult Delete(DeleteShowVM VM)
        {
            _adapter.DeleteShow(VM.Id);
            return Ok();
        }
    }
}
