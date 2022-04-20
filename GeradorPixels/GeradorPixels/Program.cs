using System;
using System.Drawing;

namespace GeradorPixels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------CRIE IMAGENS RANDOMICAS-----------");
            Console.WriteLine("Altura : ");
            var ox = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Largura : ");
            var oy = Convert.ToInt32(Console.ReadLine());

            var inicio = DateTime.Now;
            Random rand = new Random();

            Bitmap btm = new Bitmap(ox, oy); 

            for (int y = 0; y < oy; y = y + rand.Next(1, 4)) 
            {
                for (int x = 0; x < ox; x = x + rand.Next(1, 4)) 
                {

                    int a = rand.Next(200, 256);   // alpha
                    int r = rand.Next(0, 256);  // red  
                    int g = rand.Next(0, 256);  // gren  
                    int b = rand.Next(0, 256);  // blue 


                    btm.SetPixel(x, y, Color.FromArgb(a, r, g, b)); 
                    Console.WriteLine($"    {x},        {y}     ");
                }
            }
            var arquivo = $"C:\\Users\\pedro\\Documents\\Imagens\\File_{DateTime.Now.Millisecond}.png"; 
            btm.Save(arquivo); 
            var end = DateTime.Now;
            var resultado = end - inicio;
            Console.WriteLine($"Horario Inicio: {inicio}\nHoraio fim: {end}\nTotal Segundos: {resultado.Seconds} segundos\n arquivo: {arquivo}"); 



        }
    }
}
