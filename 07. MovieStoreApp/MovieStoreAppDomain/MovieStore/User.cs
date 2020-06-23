using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreApp.Domain.ENUM;



namespace MovieStoreApp.Domain.MovieStore.Member
{
    public class User : Member
    {
        public double MemberNumber { get; set; }
        public TypeOfSubscription TypeOfSubscription { get; set; }
        public DateTime ExpireDate { get; set; }
        public Movie[] Movies { get; set; }

        public User(string firstName, string lastName, int age, string userName, string password, int phoneNumber)
        : base(firstName, lastName, age, userName, password, phoneNumber)
        {
            DateOfRegistration = DateTime.Now;
            if (TypeOfSubscription == TypeOfSubscription.Annually)
            {
                ExpireDate = DateTime.Now.AddDays(30);
            }
            else if (TypeOfSubscription == TypeOfSubscription.Monthly)
            {
                ExpireDate = DateOfRegistration.AddDays(30);
            }

        }

        public void SetExpires()
        {
            double expireDate = Math.Abs((DateOfRegistration - ExpireDate).TotalDays);
            Console.WriteLine($"Subscription type - {TypeOfSubscription} \n Days of expiration: {expireDate} days left");
        }

        public User()
        {
        }
    }
}
