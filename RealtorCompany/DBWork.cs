using RealtorCompany.Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RealtorCompany
{
    //для мирации  создания новой миграции изменений
    //Add-Migration Add_NameMigration
    //для внесение изменений в БД
    //Update-DataBase 
    class DBWork
    {
        private static DBWork _inctance;
        public static DBWork Instance
        {
            get
            {
                if (_inctance == null)
                    _inctance = new DBWork();
                return _inctance;
            }
        }

        //Возврат всех работников
        public List<Employee> GetEmployee()
        {
            using (RealtorContext db = new RealtorContext())
            {
                return db.Employees.ToList();
            }
        }

        //добав нового работника
        public void AddEmployee(string FName, string LName, string Email, string Password, string Position)
        {
            Employee em = new Employee();
            using (RealtorContext db = new RealtorContext())
            {
                em.FirstName = FName;
                em.SecondName = LName;
                em.Email = Email;
                em.Password = Password;
                em.Position = Position;

                db.Employees.Add(em);
                db.SaveChanges();
            }
        }

        //Добав квартиры
        public int AddApartment(string title, int area, int countRoom, int floor, int number, int price, string address)
        {
            Apartment ap = new Apartment();
            using (RealtorContext db = new RealtorContext())
            {
                ap.Title = title;
                ap.Area = area;
                ap.CountRoom = countRoom;
                ap.Floor = floor;
                ap.Number = number;
                ap.Price = price;
                ap.Address = address;

                db.Apartments.Add(ap);
                db.SaveChanges();

                return db.Apartments.Where(ap2 => ap2.Title == title).Select(ap1 => ap1.Id).FirstOrDefault();
            }
        }

        //добавление картинки
        public void AddPicture(int index, byte[] bt)
        {
            Picture pc = new Picture();
            using (RealtorContext db = new RealtorContext())
            {
                pc.ApartmentId = index;
                pc.Image = bt;

                db.Pictures.Add(pc);
                db.SaveChanges();

            }
        }

        //измен данных о работнике
        internal void ChangeEmployee(string FName, string LName, string Password, string Email, string Position, int index)
        {
            using (RealtorContext db = new RealtorContext())
            {
                Employee e = db.Employees.Where(em => em.Id == index).FirstOrDefault();
                e.FirstName = FName;
                e.SecondName = LName;
                e.Email = Email;
                e.Password = Password;
                e.Position = Position;
                db.SaveChanges();
            }
        }


        //поиск квартиры 
        public Apartment SearchApart(string searchStr)
        {
            using (RealtorContext db = new RealtorContext())
            {
                return db.Apartments.Where(ap => ap.Title.Contains(searchStr) == true).FirstOrDefault();
            }
        }


        //поиск картинки по id 
        public byte[] SearchApart(int indexApart)
        {
            using (RealtorContext db = new RealtorContext())
            {
                return db.Pictures.Where(pc => pc.ApartmentId == indexApart).Select(pc1 => pc1.Image).FirstOrDefault();
            }
        }

        //изменение данных о квартире
        internal void ChangeApartment(string title, int area, int countRoom, int floor, int number, int price, string address, int index)
        {

            using (RealtorContext db = new RealtorContext())
            {
                Apartment ap = db.Apartments.Where(a => a.Id == index).FirstOrDefault();
                if (ap != null) {
                    ap.Title = title;
                    ap.Area = area;
                    ap.CountRoom = countRoom;
                    ap.Floor = floor;
                    ap.Number = number;
                    ap.Price = price;
                    ap.Address = address;

                    db.SaveChanges();
                }
            }
        }

        //изменение данных о картинке
        internal void ChangePicture(int indexApart, byte[] bt)
        {
            using (RealtorContext db = new RealtorContext())
            {
                Picture pc = db.Pictures.Where(p => p.ApartmentId == indexApart).FirstOrDefault();
                pc.ApartmentId = indexApart;
                pc.Image = bt;

                db.SaveChanges();

            }
        }

        //выборка всей квартир которых нету в брони
        public List<Apartment> GetApartment()
        {
            using (RealtorContext db = new RealtorContext())
            {
                //var query = from ap in db.Apartments
                //            from bk in db.Bookings
                //            where ap.Id != bk.ApartmentId
                //            select ap;
                return db.Apartments.ToList();
            }
        }


        public void SaleApart(int indexApart)
        {
            Purchase pr = new Purchase();
            using (RealtorContext db = new RealtorContext())
            {
                db.Clients.Add(new Client { FirstName = "2", SecondName = "1" });
                pr.ApartmentId = indexApart;
                pr.ClientId = 1;
                pr.DatePurchase = DateTime.Now;
                db.Purchases.Add(pr);
                db.SaveChanges();
            }
        }
    }
}
