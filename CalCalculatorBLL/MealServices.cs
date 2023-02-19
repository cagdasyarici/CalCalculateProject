using CalCalculatorDAL;
using CalCalculatorDAL.Repositories;
using CalCalculatorEntities;
using CalCalculatorEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculatorBLL
{
    public class MealServices : BaseRepository<Meal>
    {
        CalCalculateDB _db;

        /// <summary>
        /// ID'si girilen kullanıcıya girilen isimde bir Meal ekler
        /// </summary>
        /// <param name="mealName"></param>
        /// <param name="userId"></param>
        public void CreateMeal(string mealName, int userId)
        {
            using (_db = new CalCalculateDB())
            {
                Meal meal = new Meal
                {
                    MealName = mealName,
                    ContactUserID = userId,
                    CreateTime = DateTime.Now,
                };
                MealServices mealServices = new MealServices();
                mealServices.AddEntity(meal);
            }

        }
        /// <summary>
        /// Girilen kullanıcının girilen tarihteki meal'larını bulur 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="user"></param>
        /// <returns>Bulunan meal'ları Meal Listesi olarak döner</returns>
        public List<Meal> SearchByDate(DateTime date, User user)
        {
            return QueryableList().Where(x => x.CreateTime.Date == date.Date && x.ContactUserID == user.UserID).ToList();
        }

        /// <summary>
        /// Girilen kullanıcının,girilen iki tarih arasındaki meal'larını bulur
        /// </summary>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <param name="user"></param>
        /// <returns>Bulunan mealları Meal Listesi olarak döndürür</returns>
        public List<Meal> SearchByDate(DateTime date1, DateTime date2, User user)
        {

            if (date1 > date2)
            {
                return QueryableList().Where(x => x.CreateTime.Date >= date2.Date && x.CreateTime.Date <= date1 && x.ContactUserID == user.UserID).ToList();
            }
            else if (date1 < date2)
            {
                return QueryableList().Where(x => x.CreateTime.Date >= date1.Date && x.CreateTime.Date <= date2 && x.ContactUserID == user.UserID).ToList();
            }
            else
            {
                return QueryableList().Where(x => x.CreateTime.Date == date1.Date && x.CreateTime.Date == date2 && x.ContactUserID == user.UserID).ToList();
            }


        }

        /// <summary>
        /// Parametre olarak aldığı Meal'ın Food'larını listeler 
        /// </summary>
        /// <param name="meal"></param>
        /// <returns>TempFood Listesi tipinde geriye değer döndürür </returns>
        public List<TempFood> ListeOlustur(Meal meal)
        {
            using (_db = new CalCalculateDB())
            {

                return _db.FoodMeals.Where(x => x.MealID == meal.MealID).Select(x =>

                new TempFood
                {
                    FoodName = x.Food.FoodName,
                    Calories = x.Food.FoodCal * (x.Grams / 100.00),
                    Grams = x.Grams,
                    FoodID = x.FoodID
                }
                ).ToList();

            }
        }

        /// <summary>
        /// Girilen mealName değerinin database'de var olup olmadığını kontrol eder
        /// </summary>
        /// <param name="mealName"></param>
        /// <returns>Eğer girilen mealName database'de mevcutsa True,değilse False değer döner</returns>
        public bool CheckIsMealNameExist(string mealName, User user)
        {
            using (_db = new())
            {
                if (_db.Meals.Where(x => x.ContactUserID == user.UserID).Any(x => x.MealName.Equals(mealName) && x.CreateTime.Day == DateTime.Now.Day))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public void ContactUsMail(User user, string ContactUsText)
        {
            MailAddress MailReceiver = new MailAddress("CalCalculateContactUS@gmail.com", "CalCalculate Team"); //Mail Adresi : CalCalculateContactUS@gmail.com   Şifre: Cal.5224  Üyeler App'in geliştirici takımına bu mail adresinden ulaşacaklar              MailAddress MailSender = new MailAddress("calculatorcodesender@gmail.com", "CodeSender");             MailMessage ContactUsMessage = new MailMessage();              ContactUsMessage.To.Add(MailReceiver);             ContactUsMessage.From = MailSender;             ContactUsMessage.Subject = $"From {user.UserName}";             ContactUsMessage.Body = $"Dear CalCalculate Team : " + ContactUsText;               SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);             smtp.Credentials = new System.Net.NetworkCredential("calculatorcodesender@gmail.com", "ijsqrsxodaulvybc");  //ijsqrsxodaulvybc             smtp.EnableSsl = true;             smtp.DeliveryMethod = SmtpDeliveryMethod.Network;             //smtp.Timeout   // Duruma göre bunu da ekle             smtp.Send(ContactUsMessage);         }
        }
    }
}
