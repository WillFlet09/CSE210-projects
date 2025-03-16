using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Luke", 5, 8, 10);

        string text = "\n\r8 When Simon Peter saw it, he fell down at Jesus’ knees, saying, Depart from me; for I am a sinful man, O Lord.\n\r9 For he was astonished, and all that were with him, at the draught of the fishes which they had taken: \n\r10 And so was also James, and John, the sons of Zebedee, which were partners with Simon. And Jesus said unto Simon, Fear not; \n\rfrom henceforth thou shalt catch men.";
        reference.ShowScriptureReference();
        Scripture scripture = new Scripture(reference, text);
        char keypress = new char();
        while(keypress != 113)
        {
            keypress = Console.ReadKey().KeyChar;
            Console.Clear();
            if(keypress == 13)
            {
                scripture.HideSomeWords();
                
            }
        }
    }
}