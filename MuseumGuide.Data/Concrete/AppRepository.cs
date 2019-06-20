using Microsoft.EntityFrameworkCore;
using MuseumGuide.Data.Abstract;
using MuseumGuide.Data.Context;
using MuseumGuide.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MuseumGuide.Data.Concrete
{
    public class AppRepository : IAppRepository
    {
        private DataContext _context;

        public AppRepository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public Museum GetMuseumById(int MuseumId)
        {
            var museum = _context.Museums.Include(x => x.Photos).FirstOrDefault(x => x.Id == MuseumId);
            return museum;
        }

        public List<Museum> GetMuseums()
        {
            var museums = _context.Museums.Include(x => x.Photos).ToList();
            return museums;
        }

        public Photo GetPhoto(int id)
        {
            var photo = _context.Photos.FirstOrDefault(x => x.Id == id);
            return photo;
        }

        public List<Photo> GetPhotosByMuseum(int museumId)
        {
            var photos = _context.Photos.Where(x => x.Id == museumId).ToList();
            return photos;
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
