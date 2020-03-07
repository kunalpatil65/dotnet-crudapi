using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using crudapi.Models;
using Dapper;

namespace crudapi.Repository
{
    public class NoteRepository
    {
        private IDbConnection _db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        public List<Note> GetNotes()
        {
            return this._db.Query<Note>("Select NoteId, Content from Note").ToList();
        }

        public bool AddNote(NewNote newNote)
        {

        }
    }
}