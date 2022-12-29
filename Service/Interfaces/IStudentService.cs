using student_service.Service.Models;

namespace student_service.Service.Interfaces
{
    internal interface IStudentService
    {
        public void Create(string name, string surname);
        public void Delete(int id);
        public void Edit(int id, string name, string surname);
        public Student[] GetAll();
        public Student GetById(int id);
    }
}
