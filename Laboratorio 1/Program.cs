using System.Diagnostics.CodeAnalysis;

public class program
{
    static void main(string[] args)
    {
        ShowMenu();
        int option;
        option = Convert.ToInt32(Console.ReadLine());
        switch (option) {
            case 1:
                {

                }break;
                case 2: {
                
                }break;
                case 3: { 

                }break;

                case 4: {
                
                }break;

                case 5:
                {
                }break;

        
        
        }



    }

    static void ShowMenu()    
    {
        while (true) {
            try
            {
                Console.WriteLine("--------------------------");
                Console.ForegroundColor= ConsoleColor.Blue;
                Console.WriteLine("     PRINCIPAL MENU");
                Console.ResetColor();
                Console.WriteLine("--------------------------\n");
                Console.WriteLine("1. Productos ");
                Console.WriteLine("2. Vender Productos");
                Console.WriteLine("3. Actualizar precio");
                Console.WriteLine("4. Mostar Resumen");
                Console.WriteLine("5. ");
                Console.WriteLine("6. ");
                Console.WriteLine("Choose option: ");





            }
            catch(Exception MessageError) 
            {
                Console.WriteLine("Error found: "+MessageError);

            }
            
        
        }


    }
}