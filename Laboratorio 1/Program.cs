﻿using System.Diagnostics.CodeAnalysis;

public class program
{
    public string producto;
    public double precio;
    public int codigo;
    static void main(string[] args)
    {
        ShowMenu();
        int option;
        option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                {

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

    static void ShowMenu()
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
    public int Tienda(string producto, int precio, int codigo)
    {
        while (true)
        {
            try
            {
                MenuTienda();
                int optionTienda;
                optionTienda = Convert.ToInt32(Console.ReadLine());
                switch (optionTienda)
                {
                    case 1:
                        {
                            AgregarProducto(producto, precio, codigo);
                        } break;
                    case 2:
                        {

                        } break;
                    case 3:
                        {
                            SalidaTienda();
                        } break;

                }

            }


            catch (FormatException ErrorMessage1)

            {
                Console.WriteLine("Error found: " + ErrorMessage1);

            }
            Console.ReadKey();


            return codigo + precio;

        }
    }
    static void MenuTienda()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------------");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("         DEPOSITO XELAJU");
        Console.ResetColor();
        Console.WriteLine("---------------------------------------\n");
        Console.WriteLine("Escriba su nombre: ");
        string NombreUsuario = Console.ReadLine();
        Console.WriteLine("Escriba su apellido: ");
        string ApellidoUsuario = Console.ReadLine();
        Console.WriteLine("Bienvenido al Deposito Xelajú: " + NombreUsuario + " " + ApellidoUsuario);
        Console.WriteLine("1. Ingresar productos ");
        Console.WriteLine("2. Comprar");
        Console.WriteLine("3. Salir del programa");
        Console.Write("Elige una opción: ");
    }
    static void SalidaTienda()
    {
        Console.WriteLine("---------------------------------------");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Gracias por utilizar nuestro programa");
        Console.ResetColor();
        Console.WriteLine("---------------------------------------");

    }
    public int AgregarProducto(string producto, int precio, int código)
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
            producto = Console.ReadLine();
            Console.WriteLine("Ingrese precio del producto");
            precio = Convert.ToInt32(Console.ReadLine());

        }
        catch (FormatException ErrorMessage2)
        {

            Console.WriteLine("Error Found: "+ ErrorMessage2);

        }
        return precio;
    }
}