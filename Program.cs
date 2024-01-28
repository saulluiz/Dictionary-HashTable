using System.Collections;
using System.Collections.Generic;

/* Dictionary <int,string> listNames=new Dictionary<int, string>(); */

public class Collections
{
    static int mapFunction(string value)
    {
        int index = 0;
        for (int i = 0; i < value.Length; i++)
        {
            index += value[i];
        }

        return index % 100;
    }
    public static void Main(string[] args)
    {
        Dictionary<int, string> listNames = new Dictionary<int, string>();
        bool end = false;
        string value = "";


        while (!end)
        {
            Console.WriteLine("Digite o nome que será Inserido:");
            value = Console.ReadLine();
            if (value == "exit") end = true;
            else
            {

                int tryIndex = mapFunction(value);


                while (listNames.ContainsKey(tryIndex))
                {
                    tryIndex++;
                }


                listNames.Add(tryIndex, value);



            }


        }
        end = false;
        while (!end)
        {
            Console.WriteLine("Digite o nome que será buscado:");
            string searchValue = Console.ReadLine();
            int index = 0;
            if (searchValue != "exit")
            {
                index = mapFunction(searchValue);
                if (listNames.ContainsKey(index))
                {
                    if (listNames.ContainsValue(searchValue))
                    {

                        while (listNames[index] != searchValue)
                        {
                            index++;
                        }
                        Console.WriteLine($"Nome encontrado no dicionário, seu indice é '{index}'");

                    }


                }
                else Console.WriteLine("Nome não encontrado!");


            }
            else end = !end;

        }
    }
}
