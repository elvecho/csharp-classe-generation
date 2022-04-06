// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int MassimoNumeroPosti = 11;
int NumeroAlunni = 0;
string[] NomiAlunni = new string[MassimoNumeroPosti];
string[] CognomiAlunni = new string[MassimoNumeroPosti];
int[] etaAlunni = new int[MassimoNumeroPosti];

//funzioni
void aggiungiAlunno()
{
    if( NumeroAlunni < MassimoNumeroPosti)
    {
        
        NumeroAlunni++;
    }
    else
    {
        Console.WriteLine("mi spiace non ci sono più posti");
    }
}
void aggiungiNomiAlunno(string Nomi)
{
    if(NumeroAlunni < 10)
    {
        NomiAlunni[NumeroAlunni] = Nomi;
    }
}
void aggiungiCognomiAlunno(string Cognomi)
{
    if (NumeroAlunni < 10)
    {
        CognomiAlunni[NumeroAlunni] = Cognomi;
    }
}

void stampaarrayinteri(int[] array)
{


    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }

    Console.WriteLine("]");

}
//programma


for (int i = 0; i < 10; i++)
{
    Console.WriteLine("ciao vuoi unirti al corso? (si o no)");
    string SioNo = Console.ReadLine();
    if (SioNo == "si")
    {
        Console.WriteLine("benvenuto");
        Console.WriteLine("inserisci il tuo nome");
       string NomeAlunno = ( Console.ReadLine());
        Console.WriteLine("inserisci il tuo cognome");
       string CognomeAlunno = (Console.ReadLine());
        Console.WriteLine("iserisci la tua età");
        int etaAlunno = int.Parse(Console.ReadLine());

        aggiungiAlunno();
        aggiungiNomiAlunno(NomeAlunno);
        aggiungiCognomiAlunno(CognomeAlunno);
        etaAlunni[i] = etaAlunno;
    }
    else
    {
        if (SioNo == "no") ;
        Console.WriteLine("torna se cambi idea");
        break;
    }

} 

Console.WriteLine("numero alunni: " + NumeroAlunni);

for (int i = 0; i < NomiAlunni.Length ; i++)
{
   
    Console.Write("\t" + i + " "+ NomiAlunni[i] + " ");
    Console.WriteLine(CognomiAlunni[i] + " ");
    

}
Console.WriteLine("eta alunni: ");
stampaarrayinteri(etaAlunni);