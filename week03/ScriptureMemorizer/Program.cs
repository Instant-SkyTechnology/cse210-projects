using System;

class Program
{
    static void Main(string[] args)
    {
        // === SCRIPTURE LIBRARY ===

        List<(Reference, string)> scriptureLibrary = new List<(Reference, string)>
        {
            (new Reference("John", 3, 16),
             "For God so loved the world, that he gave his only begotten Son, " +
             "that whosoever believeth in him should not perish, but have everlasting life."),

            (new Reference("Proverbs", 3, 5, 6),
             "Trust in the Lord with all thine heart; and lean not unto thine own understanding. " +
             "In all thy ways acknowledge him, and he shall direct thy paths."),

             (new Reference("Psalm", 23, 1),
             "The Lord is my shepherd; I shall not want."),

            (new Reference("2 Nephi", 2, 25),
             "Adam fell that men might be; and men are, that they might have joy."),

            (new Reference("Mosiah", 2, 17),
             "When ye are in the service of your fellow beings ye are only in the service of your God."),

            (new Reference("Ether", 12, 27),
            "My grace is sufficient for all men that humble themselves before me."),

            (new Reference("Alma", 37, 6),
            "By small and simple things are great things brought to pass; and small means in many instances doth confound the wise."),

            (new Reference("Matthew", 5, 16),
            "Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven."),

            (new Reference("Philippians", 4, 13),
            "I can do all things through Christ which strengtheneth me."),

            (new Reference("1 Nephi", 3, 7),
            "I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),

            (new Reference("James", 1, 5),
            "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him."),

            (new Reference("Ether", 12, 6),
            "Faith is things which are hoped for and not seen; wherefore, dispute not because ye see not, for ye receive no witness until after the trial of your faith.")
        };

        Random rand = new Random();
        var (reference, text) = scriptureLibrary[rand.Next(scriptureLibrary.Count)];

        Scripture scripture = new Scripture(reference, text);

        // === Main program loop ===
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press ENTER to continue or type 'quit' to exit: ");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input.ToLower() == "quit" || input.ToLower() == "q")
            {
                Console.WriteLine("==================================================");
                string message = "Thank you. Goodbye!";
                Console.WriteLine(message.PadLeft((50 + message.Length) / 2).PadRight(50));
                Console.WriteLine("==================================================");
                Console.WriteLine();
                break;
            }

            scripture.HideRandomWords(3);  // hides 3 new random words each round

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are now hidden! Program ending...");
                Console.WriteLine("==================================================");
                string message = "Thank you. Goodbye!";
                Console.WriteLine(message.PadLeft((50 + message.Length) / 2).PadRight(50));
                Console.WriteLine("==================================================");
                Console.WriteLine();
                break;
            }
        }
    }
}