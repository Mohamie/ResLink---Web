using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BackendlessAPI;
using ResLink.BL.Models;
using ResLink.DAL.Repositories;


namespace CoreLibrary
{

    class Program
    {
        private static string APPLICATIONID = "B5ACCDD7-2895-D5A4-FFF1-63C024AFED00";
        private static string APIKEY = "E68870EC-779E-4591-A4F5-A426E26023EE";

        static async Task Main(string[] args)
        {
            BackendlessAPI.Backendless.InitApp(APPLICATIONID, APIKEY);
            await DisplayComplaints();
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

       
    }

}

