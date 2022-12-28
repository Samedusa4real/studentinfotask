using student_service.Service.Interfaces;

namespace student_service.Service.Models
{
    internal class StudentService : Group,IStudentService
    {
        public void Create(string name, string surname)
        {
            Array.Resize(ref Id, Id.Length + 1);
            Id[Id.Length - 1] = id++;
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = $"Id : {id}, Ad : {name}, Soyad : {surname}";
        }

        public void Delete(int id)
        {
            foreach (int i in Id)
            {
                if (id <= Id.Length-1)
                {
                    if (i == id - 1)
                    {
                        Students[i] = "Silindi!";
                    }
                }
                else
                {
                    Console.WriteLine("Bu id'de telebe tapilmadi");
                }
            }
        }

        public void Edit(int id, string name, string surname)
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            foreach (string student in Students)
            {
                Console.WriteLine(student);
            }
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
