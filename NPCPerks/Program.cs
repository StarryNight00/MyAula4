using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis
            int NumNpc;
            string input, input2;

            //declarar Array (referência à enumeração)
            CarateristicasNPC[] caract;

            //Pedir input para gerar array
            Console.WriteLine("Quantos NPCs deseja gerar?");
            input = Console.ReadLine();
            NumNpc = Convert.ToInt32(input);
         
            //criar Array
            caract = new CarateristicasNPC[NumNpc];

            //Para cada NPC, pedir caracteristicas
            for (int i = 0; i < NumNpc; i++)
            {
                //Perguntar se é stealth
                Console.WriteLine($"\n\nDeseja que NPC {i+1} tenha o atributo stealth? y/n");
                input2 = Console.ReadLine();
                //Adicionar stealth à lista
                if (input2 == "y")
                {
                    caract[i] |= CarateristicasNPC.Stealth;
                }

                //Perguntar se é combat
                Console.WriteLine($"\nDeseja que NPC {i+1} tenha o atributo combat? y/n");
                input2 = Console.ReadLine();
                //Adicionar combat à lista
                if (input2 == "y")
                {
                    caract[i] |= CarateristicasNPC.Combat;
                }

                //Perguntar se é lockpick
                Console.WriteLine($"\nDeseja que NPC {i+1} tenha o atributo lockpick? y/n");
                input2 = Console.ReadLine();
                //Adicionar lockpick à lista
                if (input2 == "y")
                {
                    caract[i] |= CarateristicasNPC.Lockpick;
                }

                //Perguntar se é luck
                Console.WriteLine($"\nDeseja que NPC {i+1} tenha o atributo luck? y/n");
                input2 = Console.ReadLine();
                //Adicionar luck à lista
                if (input2 == "y")
                {
                    caract[i] |= CarateristicasNPC.Luck;
                }
            }
            
            //Mostrar Características
            for (int i = 0; i < NumNpc; i++)
            {
                //Mostrar Carateristicas
                Console.WriteLine($"\nO NPC {i+1} tem as seguintes caraterísticas: ");
                Console.Write(caract[i]);

                if ((caract[i] & CarateristicasNPC.Combat) == CarateristicasNPC.Combat && (caract[i] & CarateristicasNPC.Luck) == CarateristicasNPC.Luck)
                {
                    Console.WriteLine("You shall win all FIGHTS!!!");
                }
            }
        }
    }
}
