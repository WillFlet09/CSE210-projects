class Video
{
    private string _title;
    private string _author;
    private int _length;
    List<Comment> list;

    public Video(string title, string author, int seconds)
    {
        _title = title;
        _author = author;
        _length = seconds;
        list = new List<Comment>();
    }

    public void GetComments()
    {
        Comment comment = new Comment("","");
        Random rand = new Random();
        int comments = rand.Next(3,6);
        for(int i = 0; i < comments; i++)
        {
           string commentor = comment.GetAuthor();
           string text = comment.GetComment();
           Comment comment1 = new Comment(commentor, text);
           list.Add(comment1);
        }
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"{_title} by: {_author}, length: {_length} seconds");
        Console.WriteLine("Comments:");
        foreach(Comment comment in list)
        {
            Console.WriteLine(comment.ToString());
        }
        Console.WriteLine(" ");
    }
}