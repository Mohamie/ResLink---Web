using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BackendlessAPI;
using ResLink.BL.Models;
using ResLink.DAL.Repositories;
using ResLink.DL;


namespace CoreLibrary
{

    class Program
    {
        private static string APPLICATIONID = "A77E777B-228F-C5D4-FF44-76E32569F500";
        private static string APIKEY = "083CB49F-0C5F-4A06-A8A4-673278F9115A";

        static async Task Main(string[] args)
        {
            BackendlessAPI.Backendless.InitApp(APPLICATIONID, APIKEY);

            BackendlessUser user = new BackendlessUser();
            user.Email = "cut@gmail.com";
            user.Password = "password123";
            user.SetProperty("residenceEmail", "loggies@gmail.com");
            user.SetProperty("userRole", 2);

            BackendlessUser savedUser = await Register(user);
            Console.WriteLine($"Registered Email: {savedUser.Email}"); 
            Console.ReadKey();
        }


        private static async Task DisplayEvents()
        {
            IEnumerable<Event> events = await EventRepository.GetEvents();

            foreach (var e in events)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine($"Event Title: {e.EventTitle}");
                Console.WriteLine($"Event Description: {e.EventDescription}");
                Console.WriteLine("----------------------------------------------");
            }
        }

        private static async Task DisplayAnnouncements()
        {
            IEnumerable<Announcement> events = await AnnouncementRepository.GetAnnouncements();

            foreach (var e in events)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine($"Ann Title: {e.AnnouncementTitle}");
                Console.WriteLine($"Ann Description: {e.AnnouncementDescription}");
                Console.WriteLine("----------------------------------------------");
            }
        }

        private static async Task DisplayComplaints()
        {
            IEnumerable<Complaint> events = await ComplaintRepository.getComplaints();

            foreach (var e in events)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine($"Complaint Title: {e.ComplaintTitle}");
                Console.WriteLine($"Complaint Description: {e.ComplaintDescription}");
                Console.WriteLine("----------------------------------------------");
            }
        }

        private static async Task<BackendlessUser> Register(BackendlessUser user)
        {
            ResidenceManager residenceManager = new ResidenceManager();
            residenceManager.ManagerAccount = user;

            
            return await ResLinkUserRegistration.RegisterManagerAccount(residenceManager);
        }

       
    }

}

