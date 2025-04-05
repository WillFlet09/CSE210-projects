using System.Net;

class Comment
{
    private string _commenter;
    private string _text;

    List<string> _Commenters = new List<string>(){
      "Beandealer", "incenorator51", "DA_TACO_DUDE","Dalmnation", "JakeSnake","EnormousEmployer","gustavo1985","Linda_Showerhammer","the_fabler","Bioniclefan527"  
    };
    List<string> _Comments = new List<string>(){
      "Good video!", "Boo! You stink", "A fine piece of intellectual artistry, this should be put in a museum", "I liked this", "Food is pretty good", "NEW VIDEO!",
      "Has anyone seen my car keys?", "HYPE HYPE HYPE", "10/10 video", "can't believe it's been 6 years",   
    };

    public Comment(string author, string comment)
    {
        _commenter = author;
        _text = comment;
    }

    public string GetAuthor()
    {
        Random rand = new Random();
        int number = rand.Next(0,_Commenters.Count());
        string author = _Commenters[number];
        return author;
    }
    public string GetComment()
    {
        Random rand = new Random();
        int number = rand.Next(0,_Comments.Count());
        string text = _Comments[number];
        return text;
    }

    public string ToString()
    {
        return $"{_commenter}: '{_text}'";
    }
}