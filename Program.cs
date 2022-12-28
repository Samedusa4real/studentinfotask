using student_service.Service.Models;

StudentService studentinfo = new StudentService();


void Seleccion() {
    Console.WriteLine("1.Telebeni daxil edin;");
    Console.WriteLine("2.Telebeni silin;");
    Console.WriteLine("3.Telebede duzelis;");
    Console.WriteLine("4.Butun melumatlari elde edin;");
    Console.WriteLine("5.Id daxil edin;");
    Console.WriteLine("0.Sistemi dayandirin.");
}





Seleccion();

string select = Console.ReadLine();

do
{
    switch (select)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Telebenin adini ve soyadini daxil edin:");
            studentinfo.Create(Console.ReadLine(), Console.ReadLine());
            Seleccion();
            select = Console.ReadLine();
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("Sistemden silmek istediyiniz telebenin id'sini daxil edin;");
            studentinfo.Delete(int.Parse(Console.ReadLine()));
            Seleccion();
            select = Console.ReadLine();
            break;
        case "3":
            Console.Clear();
            Console.WriteLine();
            Seleccion();
            select = Console.ReadLine();
            break;
        case "4":
            Console.Clear();
            Console.WriteLine("Butun melumatlar:");
            studentinfo.GetAll();
            Seleccion();
            select = Console.ReadLine();
            break;
        case "5":
            Console.Clear();
            Console.WriteLine();
            Seleccion();
            select = Console.ReadLine();
            break;
        case "0":
            Console.WriteLine("Sistem dayandi!");
            break;
    }
} while (select != "0");
