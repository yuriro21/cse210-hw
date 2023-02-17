using System;

class Program
{
    static void Main(string[] args)
    {   
        List<Video> videoList = new List<Video>();

        //https://www.youtube.com/watch?v=A90sfzcYI50&ab_channel=AdrianCede%C3%B1otenor
        Comment comment1Video1 = new Comment("EduCanversa", "Grande Maestro!");
        Comment comment2Video1 = new Comment("abrahamcedeno7119", "Brutalisimo!");
        Comment comment3Video1 = new Comment("ceciliamaya9752", "Bello. Éxito para ti Adrián. Has trabajado para lograr toda esta maravilla en tu voz. Dios te bendiga");
        List<string> video1Comments = new List<string>();
        video1Comments.Add(comment1Video1.ToString());
        video1Comments.Add(comment2Video1.ToString());
        video1Comments.Add(comment3Video1.ToString());

        //https://www.youtube.com/watch?v=_tNU6dpjIyM&list=RD_tNU6dpjIyM&start_radio=1&ab_channel=STARGAZE
        Comment comment1Video2 = new Comment("9Risky", "This song never gets old. No matter how much I listen, I never get bored.");
        Comment comment2Video2 = new Comment("TheRealGuywithoutaMustache", "So much has happened since this song's release, let's be grateful we're still around to remember the good ol days");
        Comment comment3Video2 = new Comment("jhetlog.9384", "Probably one of the best collaborations ever. Coldplays meaningful lyrics and Chainsmokers catchy beat, just a perfect combination of the two.");
        Comment comment4Video2 = new Comment("nabihanabiha436", "It's quite unbelievable how all the songs get old and I personally get bored of them, but this one right here has never failed to cheer me up!!!!");
        List<string> video2Comments = new List<string>();
        video2Comments.Add(comment1Video2.ToString());
        video2Comments.Add(comment2Video2.ToString());
        video2Comments.Add(comment3Video2.ToString());
        video2Comments.Add(comment4Video2.ToString());

        //https://www.youtube.com/watch?v=RFKePsgTNg0&ab_channel=GeneralConference
        Comment comment1Video3 = new Comment("zombiez4444", "This was one of the most profound talks I have ever heard.  The Spirit spoke directly to my heart the entire time.  I am so thankful for living prophets!");
        Comment comment2Video3 = new Comment("mongomaddy","this was my first time getting to hear the prophet live!!!! took lots of notes lol. God Bless the living prophet Russel M. Nelson, in Jesus name.");
        Comment comment3Video3 = new Comment("amypola5903","This was NOT a goodbye talk, it's an invitation! I'm in! Thank you!!");
        Comment comment4Video3 = new Comment("jenpowering","I have never felt a conference talk so strongly as I felt this one…I felt Jesus Christ was talking through His prophet , straight to me! We are going to be ok!!!!!!!!!!!!!!!!!");
        Comment comment5Video3 = new Comment("av8ionUSMC", "As someone who was inactive from church for the first 21 years of adulthood and engaged in everything the world is doing, making and keeping sacred covenants and being active in the church has made life much easier. Challenging times still happen but now I endure them with an eternal perspective and it’s made all the difference. Our dear Prophet is correct and I sustain him with all my heart till we meet again!");
        List<string> video3Comments = new List<string>();
        video3Comments.Add(comment1Video3.ToString());
        video3Comments.Add(comment2Video3.ToString());
        video3Comments.Add(comment3Video3.ToString());
        video3Comments.Add(comment4Video3.ToString());        
        video3Comments.Add(comment5Video3.ToString());

        Video video1 = new Video("Joropo con estrivillo", "Adrian Cedeno", 270, video1Comments);
        Video video2 = new Video("Something Just Like This", "The Chainsmokers & Coldplay", 396, video2Comments);
        Video video3 = new Video("Overcome the World and Find Rest", "Russell M. Nelson", 1123, video3Comments);

        videoList.Add(video1);
        videoList.Add(video2);
        videoList.Add(video3);

        int videoNum = 1;
        foreach (Video YouTubeVideo in videoList)
        {        
            Console.WriteLine($"Video {videoNum}: ");
            Console.WriteLine($"Autor: {YouTubeVideo.Author} \nTitle: {YouTubeVideo.Title} \nSeconds: {YouTubeVideo.Seconds} \nNumber of comments: {YouTubeVideo.Coments.Count()}");
            Console.WriteLine("");
            YouTubeVideo.GetAllComments();
            videoNum++;
        }     
    }
}