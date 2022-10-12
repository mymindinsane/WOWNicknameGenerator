namespace nickname_generator;

public static class Elf
{
    public static string[] ElfNames(int choice)
    {
        if (choice ==1)
        {
            string[] prefix = {
                "Аэль", "Аер", "Бес", "Кор", "Эйль", "Эйр", "Эль"
                
            };
            return prefix;
        }

        if (choice==2)
        {
            string[] suffix =
            {
                "ай","аель","аер","ах","айас","иан", "рад", "уал", "рет", "лар"
                
            };
            return suffix;
        }

        throw new InvalidOperationException();
    }
}