namespace Restaurant__namespace
{
    public class Employe
    {
        private string v1;
        private string v2;
        private string v3;

        public string name { get; set; }
        public string surname {get; set; }
        public string genre { get; set; }
        public int age { get; set; }

        public Employe(string name, string surname, string genre, int age)
        {
            this.name = name;
            this.surname = surname;
            this.genre = genre;
            this.age = age;
        }

 

        public override string ToString(){  
            return "Name: "+name+"\n Surname: " + surname + "\n Age:" + age.ToString() + "\n Genre: " + genre;
        }
    }
}