using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    public class Service1 : IService1
    {
        Entities db = new Entities();

        public int register(string username,string password,string email)
        {
           
            var kontrol =db.Müşteri.Where(w => w.username == username).FirstOrDefault();
            if (kontrol ==null)
            {
                Müşteri yenimüşteri = new Müşteri();
                yenimüşteri.username = username;
                yenimüşteri.password = password;
                yenimüşteri.email = email;
                db.Müşteri.Add(yenimüşteri);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
            
        }
        public int login(string username, string password,string adres,string sipariş)
        {
            var kontrol = db.Müşteri.Where(w => w.username == username).FirstOrDefault();

            if (kontrol.password==password)
            {
                kontrol.adres = adres;
                kontrol.sipariş = sipariş;
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
            
        }
        public int şifre_değiştir(string username, string password, string yeni_şifre)
        {
            var kontrol = db.Müşteri.Where(w => w.username == username).FirstOrDefault();

            if (kontrol == null)
            {
                return 0; //kullanıcı adı yanlış
            }
            else if (kontrol.password != password)
            {
                return 1; // şifre yanlış
            }
            else
            {
                kontrol.password = yeni_şifre;
                db.SaveChanges();
                return 2; //şifre başarıyla değiştirildi.
            }

        }

    }
}
