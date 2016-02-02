using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant__namespace
{
    interface IRestourant
    {
        Dictionary<String,String> return_weakly_menu();
        void Take_order();
        void addEmploye(Employe e);
        void removeEmploye(String name);
        List<Orders> list_of_orders();
        List<Employe> list_of_emloyes();
        String Employes_toString();

    }
}
