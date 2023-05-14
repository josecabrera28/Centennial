using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TikTokManager class
class TikTokManager
{
    //private fields belongingto the TikTokManager class
    private static List<TikTok> TIKTOKS;
    private static string FILENAME = "tiktoks.txt";
    //static constructor
    static TikTokManager()
    {
        //creating an empty list of TikToks objects
        TIKTOKS = new List<TikTok>();
        //creating a reader to read the tiktoks.txt file
        TextReader reader = new StreamReader(FILENAME);

        string line;
        //reading each line of tiktoks.txt file which is not empty
        while ((line = reader.ReadLine()) != null)
        {
            //calling the Parse method from TikTok class to get a TikTok object from the data in the file line
            TIKTOKS.Add(TikTok.Parse(line));
        }
        reader.Close();
    }
    //TikTokManager class method to test development
    public static void Initialize()
    {
        //creating 5 variables with TikTok datatype (Objects not assigend)
        TikTok t1, t2, t3, t4, t5;
        //creating TikTok objects and assigning them to the variables
        t1 = new TikTok("Fluffly dancer", 1, "#dance", Audience.World);
        t2 = new TikTok("New trailer", 1, "#movie", Audience.World);
        t3 = new TikTok("Gillete ad ", 1, "#ad", Audience.Special);
        t4 = new TikTok("Important news", 1, "#news", Audience.World);
        t5 = new TikTok("Comedy Show", 4, "#comedy", Audience.World);
        //creating a list of TikToks with the previous objects
        TIKTOKS = new List<TikTok>() { t1, t2, t3, t4, t5 };

    }
    //Methods to display the list of tiktoks with different criteria
    public static void Show()
    {
        foreach (var list in TIKTOKS)
        {
            Console.WriteLine(list.ToString());
        }
    }
    public static void Show(string tag)
    {
        foreach (var list in TIKTOKS)
        {
            if (list.HashTag == tag)
            {
                Console.WriteLine(list.ToString());
            }
        }
    }
    public static void Show(int length)
    {
        foreach (var list in TIKTOKS)
        {
            if (list.Length == length)
            {
                Console.WriteLine(list.ToString());
            }
        }
    }
    public static void Show(Audience audience)
    {
        foreach (var list in TIKTOKS)
        {
            if (list.Audience == audience)
            {
                Console.WriteLine(list.ToString());
            }
        }
    }
}

