using System;

public class Program
{
    static void Main(string[] args)
    {

        
            int option;
            option = ShowMenu();
            switch (option)
            {
                case 1:
                    {
                        Tienda();
                    }
                    break;
                case 2:
                    {

                    }
                    break;
                case 3:
                    {

                    }
                    break;

                case 4:
                    {

                    }
                    break;

                case 5:
                    {
                        Exit();
                    }
                    break;



            } 
        



    }

    static int ShowMenu()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("--------------------------");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("     PRINCIPAL MENU");
                Console.ResetColor();
                Console.WriteLine("--------------------------\n");
                Console.WriteLine("1. Tienda (PrimerEjercicio)");
                Console.WriteLine("2. Productos ");
                Console.WriteLine("3. Vender Productos");
                Console.WriteLine("4. Actualizar precio");
                Console.WriteLine("5. Mostar Resumen");
                Console.WriteLine("6. Salir del Programa");
                Console.WriteLine("Choose option: ");
                return int.Parse(Console.ReadLine());
                
            }
            catch (Exception MessageError)
            {
                Console.WriteLine("Error found: " + MessageError);

            }


        }


    }
    static void Exit()
    {
        Console.WriteLine("Gracias por usar el programa... \n");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("ENTER para salir");
        Console.ResetColor();
    }

    public static void Tienda()
    {
        string[] productos = new string[100];
        int[] precios = new int[100];
        int[] codigos = new int[100];
        int[] cantidades = new int[100];
        int indice = 0;
        Console.Write("Escriba su nombre: ");
        string NombreUsuario = Console.ReadLine();
        Console.WriteLine("Escriba su apellido: ");
        do
        {
            try
            {
                
                string ApellidoUsuario = Console.ReadLine();
                
                int optionTienda = MenuTienda(NombreUsuario, ApellidoUsuario);
                switch (optionTienda)
                {
                    case 1:
                        {
                            AgregarProductoTienda(productos, precios, codigos, cantidades, ref indice);
                        }
                        break;
                    case 2:
                        {
                            SumarProductosTienda(productos, precios, codigos, cantidades, indice);
                        }
                        break;
                    case 3:
                        {
                            SalidaTienda();
                            return;
                        }

                }

            }


            catch (FormatException ErrorMessage1)

            {
                Console.WriteLine("Error found: " + ErrorMessage1);

            }
            Console.ReadKey();

        } while (true);



        
    }

    static int MenuTienda(string NombreUsuario, string ApellidoUsuario)
    {
        Console.Clear();
        Console.WriteLine("---------------------------------------");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("         DEPOSITO XELAJU");
        Console.ResetColor();
        Console.WriteLine("---------------------------------------\n");
        Console.WriteLine("Bienvenido al Deposito Xelajú: " + NombreUsuario + " " + ApellidoUsuario);
        Console.WriteLine("1. Ingresar productos ");
        Console.WriteLine("2. Comprar");
        Console.WriteLine("3. Salir del programa");
        Console.Write("Elige una opción: ");
        return int.Parse(Console.ReadLine());
    }

    static void SalidaTienda()
    {
        Console.WriteLine("---------------------------------------");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Gracias por utilizar nuestro programa");
        Console.ResetColor();
        Console.WriteLine("---------------------------------------");

    }

    public static void AgregarProductoTienda(string[] productos, int[] precios, int[] codigos, int[] cantidades, ref int indice)
    {
            try
            {

                Console.Clear();
                Console.WriteLine("---------------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("         MENU PRODUCTOS");
                Console.ResetColor();
                Console.WriteLine("---------------------------------------\n");
                Console.Write("Ingrese nombre del producto: ");
                productos[indice] = Console.ReadLine();
                Console.Write("Ingrese precio del producto: ");
                precios[indice] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese la cantidad de este producto: ");
                cantidades[indice] = Convert.ToInt32(Console.ReadLine());
                codigos[indice] = indice + 1;

                Console.WriteLine($"Producto agregado: {productos[indice]}, Precio: Q.{precios[indice]}, Cantidad: {cantidades[indice]}, Código: {codigos[indice]}");

                indice++;

            }
            catch (FormatException ErrorMessage2)
            {

                Console.WriteLine("Error Found: " + ErrorMessage2);

            }
        
    }

    public static void SumarProductosTienda(string[] productos, int[] precios, int[] codigos, int[] cantidades, int indice)
    {
        double Total1 = 0;
        double Descuento = 0.05; 
        double Total2 = 0;

        for (int i = 0; i < indice; i++)
        {
            Total1 += precios[i] * cantidades[i];
        }

        Total2 = Total1 * (1 - Descuento);

        Console.WriteLine($"Total de productos: Q.{Total1}");
        Console.WriteLine($"Descuento aplicado: 5%");
        Console.WriteLine($"Total con descuento: Q.{Total2}");
    }
}
