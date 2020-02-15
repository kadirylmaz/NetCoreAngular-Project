

using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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

    public List<City> GetCities()
    {
        var cities = _context.Cities.Include(x=>x.Photos).ToList();
        return cities;
    }

    public City GetCity(int id)
    {
       var city = _context.Cities.Include(x=>x.Photos).Where(x=>x.Id == id).FirstOrDefault();
       return city;
    }

    public Photo GetPhoto(int id)
    {
       var photo = _context.Photos.FirstOrDefault(x=>x.Id == id);
       return photo;
    }

    public List<Photo> GetPhotosByCity(int id)
    {
       var photos = _context.Photos.Where(x=>x.CityId ==id).ToList();
       return photos;
    }

    public bool SaveAll()
    {
       return  _context.SaveChanges() > 0;
    }

    public void Update<T>(T entity)
    {
        _context.Update(entity);
    }
}