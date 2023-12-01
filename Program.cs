//Projeto GicellyGomes ***GeneticaMediliana***
 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Genética Mendeliana ---");
        Console.Write("Alelos do indivíduo 1 (AA, Aa ou aa): ");
        string alelosIndividuo1 = Console.ReadLine()!.ToUpper();
 
        Console.Write("Alelos do indivíduo 2 (AA, Aa ou aa): ");
        string alelosIndividuo2 = Console.ReadLine()!.ToUpper();
 
        Console.Write("Tipo de dominância (C/I): ");
        char tipoDominancia = Console.ReadLine()!.ToUpper()[0];
 
        CalculaProbabilidades(alelosIndividuo1, alelosIndividuo2, tipoDominancia);
 
        Console.ReadKey();
    }
 
    static void CalculaProbabilidades(string alelosIndividuo1, string alelosIndividuo2, char tipoDominancia)
    {
        double probabilidadeAA = 0, probabilidadeAa = 0, probabilidadeaa = 0;
 
        // Verifica os possíveis genótipos dos descendentes e calcula as probabilidades
        if (tipoDominancia == 'C')
        {
            if ((alelosIndividuo1 == "AA" || alelosIndividuo1 == "Aa") && (alelosIndividuo2 == "AA" || alelosIndividuo2 == "Aa"))
            {
                probabilidadeAA = 1;
                probabilidadeAa = 0;
                probabilidadeaa = 0;
            }
            else if ((alelosIndividuo1 == "aa") && (alelosIndividuo2 == "aa"))
            {
                probabilidadeAA = 0;
                probabilidadeAa = 0;
                probabilidadeaa = 1;
            }
            else
            {
                probabilidadeAA = 0;
                probabilidadeAa = 0.5;
                probabilidadeaa = 0.5;
            }
        }
        else if (tipoDominancia == 'I')
        {
            if ((alelosIndividuo1 == "AA") && (alelosIndividuo2 == "AA"))
            {
                probabilidadeAA = 1;
                probabilidadeAa = 0;
                probabilidadeaa = 0;
            }
            else if ((alelosIndividuo1 == "aa") && (alelosIndividuo2 == "aa"))
            {
                probabilidadeAA = 0;
                probabilidadeAa = 0;
                probabilidadeaa = 1;
            }
            else if ((alelosIndividuo1 == "Aa" && alelosIndividuo2 == "AA") || (alelosIndividuo1 == "AA" && alelosIndividuo2 == "Aa"))
            {
                probabilidadeAA = 0.25;
                probabilidadeAa = 0.5;
                probabilidadeaa = 0.25;
            }
            else
            {
                probabilidadeAA = 0;
                probabilidadeAa = 0.5;
                probabilidadeaa = 0.5;
            }
        }
 
        // Exibe as probabilidades e as características associadas a elas
        Console.WriteLine("--- Genética Mendeliana ---");
        Console.WriteLine($"AA: {(probabilidadeAA * 100):0}% - {(tipoDominancia == 'C' ? "vermelho" : "vermelho")}");
        Console.WriteLine($"Aa: {(probabilidadeAa * 100):0}% - {(tipoDominancia == 'C' ? "rosa" : "rosa")}");
        Console.WriteLine($"aa: {(probabilidadeaa * 100):0}% - {(tipoDominancia == 'C' ? "branco" : "branco")}");
    }
}