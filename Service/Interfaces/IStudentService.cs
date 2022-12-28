namespace student_service.Service.Interfaces
{
    internal interface IStudentService
    {
        public abstract void Create(string name, string surname);
        public abstract void Delete(int id);
        public abstract void Edit(int id, string name, string surname);
        public abstract void GetAll();
        public abstract void GetById(int id);
    }
}
