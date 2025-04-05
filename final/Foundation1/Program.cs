using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("The complete history of World of the Myths of Legends", "RestingSugar", 1386);
        video1.GetComments();
        video1.DisplayVideo();
        Video video2 = new Video("ShrimpCraft episode 27: Gubble Bump Shrimp!", "JumbleMumble", 1532);
        video2.GetComments();
        video2.DisplayVideo();
        Video video3 = new Video("HistoryPark: The history of Harold Porter's wizardland", "HistoryPark", 1927);
        video3.GetComments();
        video3.DisplayVideo();
    }
}