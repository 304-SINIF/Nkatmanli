using DAL;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;


namespace LogicLayer
{
    public class Logicresponse
    {
        public static List<Entity> Personellist()
        {
            return DalProcess.Personellistesi();
        }
        public static int personek(Entity e)
        {
            if (e.Namesurname.Length > 2 && e.Namesurname != "" && e.Wage >= 5500)
            {
                return DalProcess.personelEkle(e);
            }
            else
            {
                return -1;
            }

        }
        public static void personelsil(int per)
        {
            DalProcess.personelsil(per);
        }
        public static bool perupdate(Entity u)
        {
            if (u.Wage>=6000 && u.Department.Length>3)
            {
                DalProcess.perguncelle(u);
                return true;
            }
            else
                return false;
        }
    }
}
