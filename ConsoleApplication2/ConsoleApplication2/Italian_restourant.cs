using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant__namespace
{
    public class Italian_Restourant  : Restourant,IRestourant
    {
        List<Employe> employe_list;
        List<Orders> orders_list;

        public Italian_Restourant(String n)
        {
            name = n;
            employe_list = new List<Employe>();
            orders_list = new List<Orders>();
        }
        public void addEmploye(Employe e){
            employe_list.Add(e);
        }

        public string Employes_toString() {
            return "LIST OF EMPLOYES \n"+
                string.Join("\n", employe_list.Select(i => string.Format("Employe: {0} {1}", i.name, i.surname))); ;
        }

        public List<Employe> list_of_emloyes(){
            return this.employe_list;
        }

        public List<Orders> list_of_orders(){
            return this.orders_list;
        }

        public void removeEmploye(string name){
            var e = employe_list.Find(x=>x.name == name);
            employe_list.Remove(e);
        }

        public Dictionary<string, string> return_weakly_menu()
        {
            throw new NotImplementedException();
        }

        public void Take_order()
        {
            throw new NotImplementedException();
        }
    }
}
