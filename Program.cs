using System;
using System.Diagnostics;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount = 0;

    public SayaTubeVideo(string title)
    {
        Debug.Assert(title.Length <= 100 && title != null,
            "Judul video memiliki panjang maksimal 100 karakter dan tidak berupa null");
        Random random = new Random();
        id = random.Next(1, 99999); // generate 5-digit random number
        this.title = title;
    }

    public void IncreasePlayCount(int playCount)
    {
        Debug.Assert(playCount < 10000000, 
            "Input penambahan play count maksimal 10.000.000 per panggilan method-nya.");

        try
        {
            checked
            {
                this.playCount += playCount;
            }
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e.Message);  
        }
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
        for (int i = 0; i < 5; i++) {
            video.IncreasePlayCount(11000000);
        }
        video.PrintVideoDetails();
    }
}