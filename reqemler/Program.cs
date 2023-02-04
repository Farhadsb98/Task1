namespace reqemler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 2
            //Console.WriteLine("Reqem daxil ele ");
            //int reqem = int.Parse(Console.ReadLine());
            //int r;
            //int log = 0;
            
            //int hasil = 0;
            //int final = 0;
            


            //while (reqem != 0)
            //{
            //    r = reqem % 10;
            //    reqem /= 10;
            //    log++;
           
            //    hasil = log*r;
            //    final += hasil;

                

            //}
            //Console.WriteLine(final);
            #endregion


          
            Console.WriteLine("Reqem daxil ele ");
            int reqem = int.Parse(Console.ReadLine());
            int r;
            int log = 0;
            int kvadrat;
            int final = 0;

            



            while (reqem != 0)
            {
                r = reqem % 10;
                reqem /= 10;
             
                log++;
              

                kvadrat =  r*r;
                final += kvadrat;
               

                Console.WriteLine(final);





            }
            
        }
    }
}