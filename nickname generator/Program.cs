namespace nickname_generator;

public static class Program 
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите количество слогов:");
            var input = Convert.ToInt32(Console.ReadLine());
            int syllables = input;
            int suffixAmount = syllables - 1;
            Console.WriteLine(RandomElements(suffixAmount, Elf.ElfNames(1), Elf.ElfNames(2)));
        }

        string RandomElements(int suffix, string[] array, string[] array2)
        {   
            string startNickname = array[new Random().Next(0, array.Length)];
            string endNickname = "";
            //string endNickname2=array2[new Random().Next(0, array2.Length)];
            string finalNickname = "";

            if (suffix == 0)
                return startNickname;
                
               
            for (int i = 0; i < suffix; i++)
            {   
                endNickname += array2[new Random().Next(0, array2.Length)];
                finalNickname = startNickname + endNickname;
                /*if ((i = suffix - 1) != 0 && suffix>=2)
                finalNickname = startNickname + endNickname +"\'"+endNickname2;
            else
                finalNickname = startNickname + endNickname;*/
            }
            return finalNickname;
        }
    }
}