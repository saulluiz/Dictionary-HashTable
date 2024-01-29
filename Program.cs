using System.Collections;
using System.Collections.Generic;

/* Dictionary <int,string> listNames=new Dictionary<int, string>(); */

public class Collections
{

    static int mapFunction(string value)
    {
        //Gera um indice que definira a posicao dos elemetos(nomes) a partir de cada char da string

        //Isso é necessário para que as buscas sejam feitas de forma mais eficiente

        int index = 0;
        for (int i = 0; i < value.Length; i++)
        {
            index += value[i];
        }

        return index % 100;
        //delimita o tamanho de 100 para o dicionario [Aumenta a quantidade de colisoes]
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
            if (value == "exit") end = true;//Define uma especie interface que permite o teste da aplicacao.
            else
            {

                int tryIndex = mapFunction(value);


                while (listNames.ContainsKey(tryIndex))
                // Quando existir uma colisao na inserção, a aplicacao vai armazenar o valor na proxima posicao vazia
                // Esse tratamento de colisoes sera feito de forma mais eficiente, mas em outra aplicação, essa utilizara essa forma simples

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
                if (listNames.ContainsKey(index))//verifica a existencia do valor no dicionario
                {
                    if (listNames.ContainsValue(searchValue))
                    {

                        while (listNames[index] != searchValue)
                        {
            //No caso de tratarmos as colisoes, o mapeamento feito pela funcao "mapFunction" nao resultara na posicao real

             //do elemento, ele estara em posicoes seguintes. Esse loop,entao, permitira que busquemos nessas posicoes

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
