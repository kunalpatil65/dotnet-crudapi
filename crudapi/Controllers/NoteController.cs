using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using crudapi.Repository;
using crudapi.Models;

namespace crudapi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class NoteController : ApiController
    {
        private NoteRepository noteRepository = new NoteRepository();

        [Route("Note/All")]
        [HttpGet]
        public List<Note> GetNotes()
        {
            return noteRepository.GetNotes();
        }
    }
}
