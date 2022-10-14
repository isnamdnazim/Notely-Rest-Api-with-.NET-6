using Microsoft.AspNetCore.Mvc;
using NotelyRestApi.Data;
using NotelyRestApi.Models;
using NotelyRestApi.Repositories.Interfaces;
using System.Xml.Serialization;

namespace NotelyRestApi.Repositories.Implementations
{
    public class NoteRepository : INoteRepository
    {
        private readonly NotelyDbContext _context;

        public NoteRepository(NotelyDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Note> GetAllNotes()
        {
            var notes = _context.Notes;
            return notes;
        }

        public Note GetNoteById(long id)
        {
            var note = _context.Notes.Find(id);
            return note;
        }

        public void SaveNote(Note note)
        {
            _context.Notes.Add(note);
            _context.SaveChanges();
        }

        public void EditNote(Note note)
        {
            _context.Notes.Update(note);
            _context.SaveChanges();
        }

        public void DeleteNote(Note note)
        {
            _context.Notes.Remove(note);
            _context.SaveChanges();
        }
    }
}
