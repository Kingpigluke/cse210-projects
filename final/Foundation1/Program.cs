using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();

        Video video1 = new Video();
        video1._title = "My Pet Pig Died";
        video1._length = "110";
        video1._author = "Howdy123";
        Comment video1Comment1 = new Comment();
        video1Comment1._name = "BobRossLover420";
        video1Comment1._commentText = "How tragic!";
        Comment video1Comment2 = new Comment();
        video1Comment2._name = "Charles Dickens";
        video1Comment2._commentText = "Sorry for your loss.";
        Comment video1Comment3 = new Comment();
        video1Comment3._name = "Sebastian Smith";
        video1Comment3._commentText = "Now he is bacon, yum! >:)";

        Video video2 = new Video();
        video2._title = "Goku vs. Vegeta";
        video2._length = "500";
        video2._author = "DragonballZLover";
        Comment video2Comment1 = new Comment();
        video2Comment1._name = "AuraFarmingGohan";
        video2Comment1._commentText = "Wow, this fight never ceases to amaze me.";
        Comment video2Comment2 = new Comment();
        video2Comment2._name = "Mary Beth";
        video2Comment2._commentText = "These new fangled cartoons are too violent for my kids! Reported.";
        Comment video2Comment3 = new Comment();
        video2Comment3._name = "Toriyama";
        video2Comment3._commentText = "I remember this part, it was really fun to make it!";

        Video video3 = new Video();
        video3._title = "Never Lose";
        video3._length = "195";
        video3._author = "Andy Johnson";
        Comment video3Comment1 = new Comment();
        video3Comment1._name = "Rebecca Williams";
        video3Comment1._commentText = "Thank you so much for this song! It's amazing!";
        Comment video3Comment2 = new Comment();
        video3Comment2._name = "Demarco Sanders";
        video3Comment2._commentText = "Yo this is fire, keep it up dude!";
        Comment video3Comment3 = new Comment();
        video3Comment3._name = "SongCritic1995";
        video3Comment3._commentText = "This is actually a pretty good song, I rate it 8/10.";
        Comment video3Comment4 = new Comment();
        video3Comment4._name = "Lucky Cyan";
        video3Comment4._commentText = "Love this song!";

        video1._commentList.Add(video1Comment1);
        video1._commentList.Add(video1Comment2);
        video1._commentList.Add(video1Comment3);

        video2._commentList.Add(video2Comment1);
        video2._commentList.Add(video2Comment2);
        video2._commentList.Add(video2Comment3);

        video3._commentList.Add(video3Comment1);
        video3._commentList.Add(video3Comment2);
        video3._commentList.Add(video3Comment3);
        video3._commentList.Add(video3Comment4);

        videosList.Add(video1);
        videosList.Add(video2);
        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayVideoDetails();
            Console.WriteLine();
        }

    }
}