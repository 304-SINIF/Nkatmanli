using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using EntityLayer;

namespace DAL
{
    public class DalProcess
    {
        public static List<Entity> Personellistesi()
        {
            List<Entity> list = new List<Entity>();
            SqlCommand komut = new SqlCommand("Select * from tbl_personel", Connect.db);
            if (komut.Connection.State != System.Data.ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                Entity ent = new Entity();
                ent.Id = Convert.ToInt32(dr["ID"]);
                ent.Namesurname = dr["AdSoyad"].ToString();
                ent.City = dr["sehir"].ToString();
                ent.Department = dr["departman"].ToString();
                ent.Wage = Convert.ToInt32(dr["maas"]);
              list.Add(ent);
            }
                dr.Close();
            return list;
        }
        public static int personelEkle(Entity P)
        {
            SqlCommand ekle = new SqlCommand("Insert into tbl_personel (AdSoyad,sehir,departman,maas) values(@p1,@p2,@p3,@p4)", Connect.db);
            if (ekle.Connection.State != System.Data.ConnectionState.Open)
            {
                ekle.Connection.Open();
            }
            ekle.Parameters.AddWithValue("@p1", P.Namesurname);
            ekle.Parameters.AddWithValue("@p2", P.City);
            ekle.Parameters.AddWithValue("@p3", P.Department);
            ekle.Parameters.AddWithValue("@p4", P.Wage);
            return ekle.ExecuteNonQuery();
            
        }
        public static void  personelsil(int t)
        {
            SqlCommand del=new SqlCommand("Delete from tbl_personel where ID =@p1",Connect.db);
            if (del.Connection.State != System.Data.ConnectionState.Open)
            {
                del.Connection.Open();
            }
            del.Parameters.AddWithValue("@p1", t);
            del.ExecuteNonQuery();
        }
        public static void perguncelle(Entity g)
        {
            SqlCommand gunc = new SqlCommand("Update tbl_persınel set Adsoyad=@p2,sehir=@p3,departman=@p4,maas=@p5,where ID=@p1", Connect.db);
            if (gunc.Connection.State != System.Data.ConnectionState.Open)
            {
                gunc.Connection.Open();
            }
            gunc.Parameters.AddWithValue("@p1", g.Namesurname);
            gunc.Parameters.AddWithValue("@p2", g.Namesurname);
            gunc.Parameters.AddWithValue("@p3", g.City);
            gunc.Parameters.AddWithValue("@p4", g.Department);
            gunc.Parameters.AddWithValue("@p5", g.Wage);
            gunc.ExecuteNonQuery();

        }
    }
}
