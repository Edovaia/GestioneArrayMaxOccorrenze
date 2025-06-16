using System;

namespace Esercizi29Bis
{

   
    class Program
    {
        static int[] insertArray(ref int[] array)
        {
            int i = 0;
            while (i < 10)
            {
                Console.Write("Inserisci il numero in posizione {0}: ", i+1);
                int nu = int.Parse(Console.ReadLine());
                array[i] = nu;
                i++;
            }
            return array;
        }
        static int valueMax(int[] array)
        {
            int maxValue = array[0];
            ;
            for (int i=0; i<array.Length;i++) {
                if (array[i]>maxValue) {
                    maxValue = array[i];
                }
            }
            return maxValue;
        }

        static int Valore()
        {
            Console.Write("Inserisci un valore intero: ");
            int x = int.Parse(Console.ReadLine());
            return x;
        }
        static int comparse(int[] array,int x)
        {
            int conta=0;
            for (int i=0; i<array.Length; i++) {
                if (x==array[i]) {
                    conta++;
                }
            }

            return conta;

        }
        public static void Main(string[] args)
        {

            int[] register = new int[10];
            insertArray(ref register);
            int maxValue=valueMax(register);
            int value = Valore();
            int valueReps = comparse(register,value);
            for (int i=0;i<register.Length; i++)
            {
                Console.WriteLine("Il valore in posizione {0} è {1}",i+1,register[i]);
            }
            Console.WriteLine("Il valore massimo presente nell'array è {0}", maxValue);

            if (valueReps == 0)
            {
                Console.WriteLine("Il valore {0} non è presente all'interno dell'array.", value);
            }
            else if (valueReps == 1)
            {
                Console.WriteLine("Il valore {0} è presente 1 volta all'interno dell'array.", value);
            }
            else
            {
                Console.WriteLine("Il valore {0} è presente {1} volta all'interno dell'array.", value, valueReps);
            }
                Console.ReadLine();
        }
    }

}
