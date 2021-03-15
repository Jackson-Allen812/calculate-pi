using System;

namespace CalculatePi {
    class Program {
        static void Main(string[] args) {
            
            decimal final_leibniz;
            decimal final_nilakantha;

            Console.Write("How many iterations to do: ");
            int iterations = Convert.ToInt32(Console.ReadLine());

            // Leibniz Series
            // pi/4 = 1/1 - 1/3 + 1/5 - 1/7...

            decimal leibniz_pi = 1m;

              for(int i = 0; i <= iterations; i++) {       
            
                int denominator = i * 2 + 3;

                if(i % 2 == 0) {
                    leibniz_pi -= 1m/denominator;
                } else {
                    leibniz_pi += 1m/denominator;
                }
                if(i % 500 == 0) {Console.WriteLine("Leibniz Iteration " + i + ": " + leibniz_pi * 4); }
            }

            final_leibniz = leibniz_pi * 4;

            // Nilakantha's Series
            // pi = 3 + 4/2*3*4 - 4/4*5*6 + 4/6*7*8...

            decimal nilakantha_pi = 3m;
            bool addition_iteration = true;

            for(long i = 2; i <= iterations*2; i+=2) { 

                if(addition_iteration) {         
                    nilakantha_pi += 4m/(i*(i+1)*(i+2));
                } else {          
                    nilakantha_pi -= 4m/(i*(i+1)*(i+2));
                }

                addition_iteration = !addition_iteration;
                
                if(i % 500 == 0) { 
                    Console.WriteLine("Nilakantha Iteration " + i + ": " + nilakantha_pi); 
                }
            }

            final_nilakantha = nilakantha_pi;

            Console.WriteLine("Pi correct out to 20 decimals:              3.14159265358979323846");
            Console.WriteLine("Leibniz Series after " + iterations + " iterations:    " + final_leibniz);
            Console.WriteLine("Nilakantha Series after " + iterations + " iterations: " + final_nilakantha);

        }

    }
}
