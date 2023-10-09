using System;
using System.ComponentModel.DataAnnotations;

int [] liczby = {1, 3, 20, 4, 12};

for  (int i = 0; i < liczby.Length; i++)
{
    for (int bubble = 0; bubble < liczby.Length -1; bubble++)
    {
        if (liczby[bubble] > liczby[bubble + 1])
        {
            int temp = liczby[bubble];
            liczby[bubble] = liczby[bubble + 1];
            liczby[bubble + 1] = temp;
        }
    }
}

foreach (int item in liczby)
{
    Console.WriteLine(item + ", ");
}






















// using System;

// int[] tablica = {6, 3, 4, 2, 10, 45, 12};
// int temp = 0;

// for (int i = 0; i < tablica.Length; i++){
//     for (int bubble = 0; bubble < tablica.Length - 1; bubble++){
//         if (tablica[bubble] > tablica[bubble +1]){
//                 temp = tablica[bubble +1];
//                 tablica[bubble + 1] = tablica[bubble];
//                 tablica[bubble] = temp;
//         }
//     }
// }

// foreach(int item in tablica)
// {
//     Console.WriteLine(item + ", ");
// }