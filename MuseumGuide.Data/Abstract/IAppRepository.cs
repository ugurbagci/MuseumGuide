using MuseumGuide.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuseumGuide.Data.Abstract
{
    public interface IAppRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveAll();

        List<Museum> GetMuseums();
        List<Photo> GetPhotosByMuseum(int museumId);
        Museum GetMuseumById(int MuseumId);
        Photo GetPhoto(int id);
    }
}
