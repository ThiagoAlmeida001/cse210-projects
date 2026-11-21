using System;
using System.Transactions;
using YouTubeVideos;
namespace YouTubeVideos;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        Video video1 = new Video("Best Electric Scooters of Every Type & Price: 2026", "RK9 Rides", 1670);
        video1.AddComment(new Comment ("notahero4255", "I was just thinking yesterday i wish there was an updated version of the 2025 one!"));
        video1.AddComment(new Comment ("CaptainPickletron", "genuinely all i need is a scooter that will last about 14 miles and easy to port around"));
        video1.AddComment(new Comment ("JulianRides", "I like that joyor T10 but they put tubless on it wish they went for inner tubes instead"));
        videos.Add(video1);

        Video video2 = new Video("10 Best Electric Scooters for Every Budget in 2026 | Budget to Premium Picks", "eBike Inspection", 743);
        video2.AddComment(new Comment ("Erin_hi", "NIU is good ive been riding it for like a year and a half and my battery just started getting weaker and its time to upgrade"));
        video2.AddComment(new Comment ("bobbytaylor8421", "I'll take my fighter mini pro any day"));
        video2.AddComment(new Comment ("PicaloOneill", "So the Teverun and the Raptor did no make the list"));
        videos.Add(video2);

        Video video3 = new Video("Top 10 Best Electric Scooters with Seats 2026", "Top Picks Today", 1033);
        video3.AddComment(new Comment ("erinmalone2669", "I wish these existed in 1999 when I lived 0.8 miles from my college. The time and effort it would have saved would have been heaven"));
        video3.AddComment(new Comment ("joval3176", "I woulda have put iscooter dx5 at number 2..wich is very fun to drive with that mopped style..it's #1 for the look"));
        video3.AddComment(new Comment ("danplaysbass6294", "I like my HiBoy ECOM 14 as it has done me well over the past few years."));
        videos.Add(video3);
        
        foreach(Video video in videos)
        {            
            video.DisplayVideoDetails();
        }
    }
}