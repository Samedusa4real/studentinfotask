using student_service.Service.Interfaces;

namespace student_service.Service.Models
{
    internal class StudentService : Group,IStudentService
    {
        Group group = new Group();

        public void Create(string name, string surname)
        {
            Student student = new Student()
            {
                Name = name,
                SurName = surname
            };

            Array.Resize(ref group.Students, group.Students.Length + 1);
            group.Students[group.Students.Length - 1] = student;
        }

        public void Delete(int id)
        {
            for (int i = 0, i< group.Students.Length; i++) 
            {
                if (group.Students[i].Id == id)
                {
                    group.Students[i] = group.Students[group.Students.Length - 1];
                    Array.Resize(ref group.Students,group.Students.Length - 1);
                    return;
                }
                else
                {
                    Console.WriteLine("WRONG ID");
                }
            }
        }

        public void Edit(int id, string name, string surname)
        {
            for (int i = 0, i< group.Students.Length; i++)
            {
                if (group.Students[i].Id == id)
                {
                    group.Students[i].Name = name;
                    group.Students[i].SurName = surname;

                    return;
                }
                else
                {
                    Console.WriteLine("WRONG ID");
                }
            }
        }

        public Student[] GetAll()
        {
            return group.Students;
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
