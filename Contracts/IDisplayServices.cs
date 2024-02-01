using Entities.Models;
public interface IDisplayServices
{
    Task<Display> GetDisplaysById(int id);
}