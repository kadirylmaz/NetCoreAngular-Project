
using System.Collections.Generic;

public interface IAppRepository
{
    void Add<T>(T entity) where T:class;
    void Delete<T>(T entity) where T: class;
    void Update<T>(T entity);
    bool SaveAll();
    List<City> GetCities(); 
    List<Photo> GetPhotosByCity(int id);
    City GetCity(int id);
    Photo GetPhoto(int id);
}