using Entities.Models;
public interface IMarkServices
{
    Task<IEnumerable<Marks>> GetMarks();
    Task<Marks> GetMarksById(int id);
    Task<Marks> AddMarks(Marks marks);
    Task<Marks> UpdateMarks(Marks marks);
}