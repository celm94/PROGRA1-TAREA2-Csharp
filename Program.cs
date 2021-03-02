using System;

namespace Tarea_2_C__operaciones
{
    class Program
    {
        static float n1, n2, respuesta;

        static void OPCIONES(){
            Console.WriteLine("Ingrese un número: ");
                    n1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese un número: ");
                    n2 = float.Parse(Console.ReadLine());

        }

        static void OPS()
        {
            Console.WriteLine(" 1- VOLVER A REALIZAR LA MISMA OPERACIÓN");
            Console.WriteLine(" 2- REGRESAR AL MENÚ PRINCIPAL");
            Console.WriteLine(" 3 en adelante- SALIR");
            string input= Console.ReadLine();
                switch (input){
                    case "1":
                        SUMA();
                        break;
                    case "2":
                        menuprincipal();
                        break;
                    case "3":
                        Console.WriteLine("HASTA LUEGO");
                        break;
                    default:
                        Console.WriteLine("HASTA LUEGO");
                        break;
                }
        }
        
       static void cero()
       {
           if (n1 == 0)
           {
               Console.WriteLine("El número 0 no es divisible");
               OPS();
           }
           if (n2 == 0)
           {
               Console.Write("ERROR, no se puede dividir entre 0 ");
               Console.WriteLine("");

               OPS();
           }
           else
           {
            respuesta = n1 / n2;
            
            Console.WriteLine("El resultado de " +n1+ " dividido " +n2+ " es: " + respuesta);
           }
           
           
       }
        static void SUMA()
        {
            Console.WriteLine("1-----S U M A-----");
            OPCIONES();
            respuesta = n1 + n2;
            Console.WriteLine("El resultado de "+n1+" + "+n2+"  es: " + respuesta);
            OPS();

        }

        static void RESTA()
        {
            Console.WriteLine("2-----R E S T A-----");
            OPCIONES();
            respuesta = n1 - n2;
            Console.WriteLine("El resultado de "+n1+" - "+n2+" es: " + respuesta);
            OPS();
        }

        static void MULTIPLICACION()
        {
            Console.WriteLine("3----M U L T I P L I C A C I Ó N----");
            OPCIONES();
            respuesta = n1 * n2;
            Console.WriteLine("El resultado es: " + respuesta);
            OPS();
        }

        static void DIVISION()
        {
            Console.WriteLine("4----D I V I S I Ó N----");
            OPCIONES();
            cero();
            
            OPS();
        }

        static void MODULO()
        {
            Console.WriteLine("5----M Ó D U L O----");
            OPCIONES();
            cero();
            
            respuesta = n1 % n2;
            Console.WriteLine("El módulo de " +n1+ " dividido entre " +n2+ " es: " + respuesta);
            OPS();
        }
        
        static void menuprincipal()
        {
            Console.WriteLine("Seleccione la operación que desea realizar");
            Console.WriteLine("1- SUMA");
            Console.WriteLine("2- RESTA");
            Console.WriteLine("3- MULTIPLICACIÓN");
            Console.WriteLine("4- DIVISIÓN");
            Console.WriteLine("5- MÓDULO");

            string input= Console.ReadLine();

            switch (input)
            {
                case "1":
                    SUMA();
                    break;

                case "2":
                    RESTA();
                    break;
                case "3":
                    MULTIPLICACION();
                    break;
                case "4":
                    DIVISION();
                    break;
                case "5":
                    MODULO();
                    break;
                    
                default:
                    break;  


            }
        }
    
        static void Main(string[] args)
        {
            
            Console.WriteLine("------B I E N V E N I D O-------");
            menuprincipal();
            

            

         
        }
    }
}
