using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant__namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            var r1 = new Italian_Restourant("XiangChing");
            r1.addEmploye(new Employe("Domen","Kupnik","M",26));
            r1.addEmploye(new Employe("Beno", "Kupnik", "M", 26));
            r1.addEmploye(new Employe("Lilijana", "Kupnik", "M", 26));
            r1.addEmploye(new Employe("Ana", "Košir", "M", 26));
            r1.addEmploye(new Employe("Samo", "Kupnik", "M", 26));

            Console.WriteLine(r1.Employes_toString());

            r1.removeEmploye("Domen");

            Console.WriteLine(r1.Employes_toString());

            Console.ReadLine();
        }
    }
}
