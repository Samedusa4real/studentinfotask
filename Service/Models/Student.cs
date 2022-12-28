namespace student_service.Service.Models
{
    internal class Student
    {
        public static int id;
        private string _name;
        public string Name {
            get
            {
                return _name;
            } 
            set
            {
                if(value.Length> 3 && value.Length<15)
                {
                    value = _name;
                }
                else
                {
                    Console.WriteLine("Zehmet olmasa duzgun daxil edin");
                }
            } 
        }
        private string _surname;
        public string SurName
        {
            get
            {
                return _surname;
            }
            set
            {
                if (value.Length > 3 && value.Length < 15)
                {
                    value = _surname;
                }
                else
                {
                    Console.WriteLine("Zehmet olmasa duzgun daxil edin");
                }
            }
        }
        private int _avarage;
        public int Avarage {
            get
            {
                return _avarage;
            } 
            set
            {
                if(value>0 && value <= 100)
                {
                    _avarage = value;
                }
                else
                {
                    Console.WriteLine("Zehmet olmasa duzgun daxil edin");
                }
            }
        }
    }
}
