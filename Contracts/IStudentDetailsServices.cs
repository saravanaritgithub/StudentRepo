using Entities.Models;
public interface IStudentDetailsServices
{
    Task<IEnumerable<StudentDetails>>GetStudentDetails();
    Task<StudentDetails>GetStudentDetailsById(int id);
    Task<StudentDetails>AddStudentDetails(StudentDetails studentDetails);
    Task<StudentDetails>UpdateStudentDetails(StudentDetails studentDetails);
    Task DeleteStudentDetails(int id);
}