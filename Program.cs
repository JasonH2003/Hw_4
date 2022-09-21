namespace HW_4;
class Program
{
    static void Main(string[] args)
    {
        //Q 1
       int BigNum = LargeNum(3,5);
       Console.WriteLine($"The largest number is :{BigNum}");

        //Q2
       PrintTra(5,"left");
        PrintTra(5,"right");


        
    }
     public static int LargeNum(int a, int b){
            if(a>b){
                return a;
            }
            else{
                return b;
            }

        }

        public static void PrintTra(int N, string shape){
            Console.WriteLine($"N is {N}; shape is {shape}");
            if(shape == "left"){
                for(int row = 0; row<N; row++){
                    for(int col = 0; col<N; col++)
                    {
                    if(row>=col)
                    Console.Write('*');
                    }
                    Console.WriteLine("");
                }

            }
            if(shape == "right"){
                int val = N;
                for (int row = 1; row <=val; row++)  
                {  
                for (int col = 1; col <= val-row; col++)  
                {  
               Console.Write(" ");  
                }  
                for (int x = 1; x <= row; x++)  
                {  
               Console.Write("*");  
                }  
                Console.WriteLine("");  
                }  
             Console.ReadLine();  

                

            }
        }

}
