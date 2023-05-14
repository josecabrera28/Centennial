using System.Collections.Generic;
using System.IO;
using System;
internal class Program
{
    public static void Main()
    {
        
        //test harness 
        TikTokManager.Initialize();
            Console.WriteLine("1. Initialize Method: ");
            Console.WriteLine("2. Show all tiktoks: \n");
            TikTokManager.Show();
            Console.WriteLine("3. Show tiktoks with #dance hashtag: \n");
            TikTokManager.Show(tag: "#dance");
            Console.WriteLine("4. Show tiktoks with 4 min length: \n");
            TikTokManager.Show(length: 4);
            Console.WriteLine("5. Show tiktoks with Special Audience: \n");
            TikTokManager.Show(audience: Audience.Special);
    }
}