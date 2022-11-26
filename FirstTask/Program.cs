namespace FirstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            input(arr);
            sort(arr);
            PrintMinMax(arr);
            PrintOdd(arr);
            sum(arr);
        }

        static void input(int[] arr)
        {
            Console.WriteLine("shemoitanet 10 mteli ricxvi:");
            for (int i = 0; i < 10; i++)
            {
                arr[i] =Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("ricxvebi shemotanilia.");
        }
        static void sort(int[] arr) 
        {
            int min = 0;
            for(int i=0;i<arr.Length-1;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if (arr[j] < arr[i] )
                    {
                        min = arr[i];
                        arr[i] = arr[j];
                        arr[j] = min;
                    }
                }
            }
        }
        static void PrintMinMax(int[] arr)
        {
            Console.Write("masivis udidesi da umciresi wevrebis sxvaobaa:");
            Console.WriteLine(arr[arr.Length - 1] - arr[0]);
        }
        static void PrintOdd(int[] arr)
        {
            Console.Write("masivshi kenti da 6-is jeradi elementebia:");
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==1 || arr[i] % 6 == 0)
                {
                    Console.Write(arr[i]);
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
        static void sum(int[] arr)
        {
            Console.Write("masivis elementebis jami:");
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if(i<arr.Length- 1)
                {
                    Console.Write('+');
                }
                else
                {
                    Console.Write('=');
                }
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }
    }
}