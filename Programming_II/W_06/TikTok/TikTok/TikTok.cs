using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//enum with 3 constants
enum Audience
{
    World,
    Group,
    Special
}

//TikTok class
class TikTok
{
    //Field belongs to TikTok class
    private static int _ID;

    //Attributes
    public string Originator { get; }
    public int Length { get; }
    public string HashTag { get; }
    public Audience Audience { get; }
    public string Id { get; }

    //Constructor
    public TikTok(string originator, int length, string hashTag, Audience audience)
    {
        Originator = originator;
        Length = length;
        HashTag = hashTag;
        Audience = audience;
        Id = Convert.ToString(_ID);
        //incrementing TikTok _ID field with each object that is created
        _ID++;

    }
    //ask about this constructor if is private or public???
    //Constructor overloaded
    private TikTok(string id, string originator, string length, string hashTag, string audience)
    {
        //capitalize the first letter of the audience parameter to match the enum consts and assigns it to a variable
        string audienceLower = char.ToUpper(audience[0]) + audience.Substring(1);

        Id = id;
        Originator = originator;
        Length = Convert.ToInt32(length);
        HashTag = hashTag;
        Audience = (Audience)Enum.Parse(typeof(Audience), audienceLower);
    }

    //ToString overrided method to customize when a TikTok object is displayed
    public override string ToString()
    {
        return $"TikTok" +
            $"\nid: {Id}" +
            $"\nOriginator: {Originator}" +
            $"\nLength: {Convert.ToString(Length)}" +
            $"\nHashTag: {HashTag}" +
            $"\nAudience: {Audience}\n";
    }
    //TikTok class method to create and return a TikTok object when reading tiktoks.txt file
    public static TikTok Parse(string line)
    {
        string id, originator, length, hashTag, audience;
        //spliting line parameter with tab separator and add each string to str array variable
        string[] str = line.Split('\t');
        //assigning to local variables with each string contained in str array with its respective index
        id = str[0];
        originator = str[1];
        length = str[2];
        audience = str[3];
        hashTag = str[4];
        //creating the TikTok object with the previous local variables 
        TikTok tikTokObj = new TikTok(id, originator, length, hashTag, audience);
        //returning the TokTok object
        return tikTokObj;
    }

}
