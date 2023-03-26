using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount = 0;

    public SayaTubeVideo(string title)
    {
        Random random = new Random();
        id = random.Next(1, 99999); // generate 5-digit random number
        this.title = title;
    }

    public void IncreasePlayCount(int playCount)
    {
        this.playCount += playCount;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Video ID: {0}", id);
        Console.WriteLine("Judul: {0}", title);
        Console.WriteLine("Play count: {0}", playCount);
    }

}

class program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – [HERDI_PRAKTIKAN]");
        video.IncreasePlayCount(2);
        video.IncreasePlayCount(9999);
        video.PrintVideoDetails();
    }
}