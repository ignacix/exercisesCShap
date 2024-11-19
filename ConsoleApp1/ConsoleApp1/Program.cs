
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information



            //1.Presente el mensaje “Hola mundo” al usuario, espere la presión de una tecla y finalice.

            // Console.Title = "1";
            //Console.WriteLine("Hola Mundo");
            //Console.ReadKey();



            //2.Solicite el ingreso de un texto cualquiera y lo presente nuevamente al usuario.

            // Console.Title = "2";
            // Console.WriteLine("write your name, please");
            // String name = Console.ReadLine();
            // Console.WriteLine("Welcome  " + name);
            // Console.WriteLine("Pleas pess any key to exit");
            // Console.ReadKey();



            //3. Lea las teclas presionadas y finalice al presionar la tecla “X”.
            // Console.Title = "3";
            // Console.WriteLine("enter keys. The program finish with 'x'");
            // ConsoleKeyInfo key = Console.ReadKey(true);
            // while(key.KeyChar!='x'){
            //     Console.WriteLine(key.KeyChar);
            //     key = Console.ReadKey(true);
            // }



            //4. Permita el ingreso de frases, finalizando cuando el usuario ingresa “fin”.
            // Console.Title = "4";
            // Console.WriteLine("write a text. The program finish if you write 'end'");
            // string text = Console.ReadLine().ToLower().Trim();
            // while(text != "end"){
            //     Console.WriteLine(text);
            //     text = Console.ReadLine().ToLower().Trim();
            // }



            //5 Lea las teclas presionadas y finalice al presionar Ctrl+F (Ctrl y F al mismo tiempo).
            // Console.Title = "5";
            // ConsoleKeyInfo key = Console.ReadKey(true);
            // while(!(key.Key == ConsoleKey.F && (key.Modifiers & ConsoleModifiers.Control) != 0)   ){
            //     Console.WriteLine(key.KeyChar);
            //     key = Console.ReadKey(true);
            // }



            //6 Lea las teclas presionadas y finalice al presionar Shift+Ctrl+F.
            // (dentro de la consola de win, esa combinación está reservada para buscar.Por eso lo modifiqué para probarlo con la tecla h)

            // Console.Title = "6";
            // Console.BackgroundColor = ConsoleColor.DarkRed;
            // Console.ForegroundColor = ConsoleColor.DarkYellow;
            // Console.Title = "Hi sir";
            // ConsoleKeyInfo key = Console.ReadKey(true);

            //     while(!(key.Key == ConsoleKey.S && (key.Modifiers & ConsoleModifiers.Shift) != 0 && (key.Modifiers & ConsoleModifiers.Control) != 0 )){
            //         Console.WriteLine(key.KeyChar);
            //         key = Console.ReadKey(true);;
            //     }



            // 6.1 Create a tiny piano using the console.


            //Console.Title = "6.1 Piano";
            //Console.Write("press A, S, D, F or G.  Adn space if you want to exit.");
            //ConsoleKeyInfo key = Console.ReadKey(true);

            //while (key.Key != ConsoleKey.Spacebar)
            //{
            //    switch (key.Key)
            //    {
            //        case ConsoleKey.A:
            //            Console.Beep(523, 150);
            //            break;

            //        case ConsoleKey.S:
            //            Console.Beep(587, 150);
            //            break;


            //        case ConsoleKey.D:
            //            Console.Beep(659, 150);
            //            break;

            //        case ConsoleKey.F:
            //            Console.Beep(698, 150);
            //            break;

            //        case ConsoleKey.G:
            //            Console.Beep(784, 150);
            //            break;
            //    }
            //    key = Console.ReadKey(true);
            //}



            //7. Solicite al usuario el ingreso de su nombre y presente el mensaje “Hola [nombre]”.

            // Console.Title = "7";
            // Console.WriteLine("Enter your name");
            // string name = Console.ReadLine();
            // Console.WriteLine($"Hola {name}");
            // Console.ReadLine();




            //8. Solicite al usuario el ingreso de una frase y presente un mensaje indicando si alguna contiene la palabra “fin”.

            // using System.ComponentModel;
            // Console.Title = "8";
            // Console.ForegroundColor = ConsoleColor.DarkYellow;
            // Console.WriteLine("Ingese una frase");
            // string phrase = Console.ReadLine();
            // bool contain = phrase.Contains("fin");
            // if(contain)
            //     Console.WriteLine("Contiene la palabra fin");
            // else
            //     Console.WriteLine("No contiene la palabra fin");

            // Console.Read();



            //9. Solicite un ingreso al usuario y lo presente en mayúsculas.

            // Console.Title = "9";
            // Console.ForegroundColor = ConsoleColor.Gray;
            // Console.WriteLine("Ingrese un texto");
            // string text = Console.ReadLine();
            // Console.WriteLine(text.ToUpper());
            // Console.Read();



            //10. Solicite un ingreso al usuario y lo presente en minúsculas.

            // Console.Title = "10";
            // Console.ForegroundColor = ConsoleColor.Blue;
            // Console.WriteLine("ingrese una texto");
            // string text = Console.ReadLine();
            // Console.WriteLine(text.ToLower());
            // Console.Read();



            //11. Reemplace en una cadena ingresada por el 
            //usuario todas las vocales acentuadas por vocales sin acento y presente el resultado.

            // Console.WriteLine("Please enter a text");
            // string text = Console.ReadLine();
            // text = modifiedText(text);
            // Console.WriteLine(text); 
            // Console.Read();

            // static string modifiedText(string texto){
            //     char[] TildeVowels ={'á','é','í','ó','ú'};
            //     char[] vowels ={'a','e','i','o','u'};
            //     for (int i = 0; i < 5; i++)
            //     {
            //         texto = texto.Replace(TildeVowels[i], vowels[i]);
            //     }
            //     return texto;
            // }



            //12. Solicite el ingreso de dos frases y determine si son iguales.

            // Console.WriteLine("write the first phrase");
            // string ph1= Console.ReadLine();
            // Console.WriteLine("write the second phrase");
            // string ph2= Console.ReadLine();

            // bool result = areEquals(ph1,ph2);

            // if (result)
            //     Console.WriteLine("They are equals");
            // else
            //     Console.WriteLine("They are not equals");

            // Console.ReadKey();



            //13. Solicite el ingreso de dos frases y determine si tienen la misma longitud.

            // string ph1 = "";
            // string ph2 = ""; 

            // requestPhrases(ref ph1, ref ph2);
            // if (sameLenght(ph1, ph2))
            //     Console.WriteLine("They have the same lenght");
            // else
            //     Console.WriteLine("They don't have the same lenght");

            // Console.ReadKey();



            //14. Solicite el ingreso de dos frases y determine si son iguales, sin diferenciar mayúsculas de minúsculas.

            // string ph1 ="";
            // string ph2 ="";

            // requestPhrases(ref ph1, ref ph2);
            // if(sameLenghtSen(ph1,ph2,true))
            //     Console.WriteLine("Son iguales");
            // else
            //     Console.WriteLine("No son iguales");

            // Console.ReadKey();







            // //FUNCTIONS

            // static void requestPhrases(ref string ph1, ref string ph2){
            // Console.WriteLine("enter de first prhase");
            // ph1 = Console.ReadLine();
            // Console.WriteLine("enter de second prhase");
            // ph2 = Console.ReadLine();
            // }



            // static bool sameLenght(string ph1, string ph2){    
            //     if (ph1.Length==ph2.Length)
            //         return true;
            //     else
            //         return false;
            // }

            // static bool sameLenghtSen(string ph1, string ph2, bool caseSen){

            //     if (caseSen){
            //         if (ph1.ToLower().Equals(ph2.ToLower()))
            //             return true;
            //         else
            //             return false;
            //     }
            //     else{
            //         if (ph1.ToLower().Equals(ph2.ToLower()))
            //             return true;
            //         else
            //             return false;
            //     }

            // } 



            //15. Solicite un ingreso al usuario y determine si puede ser interpretado como un valor numérico.
            //Console.WriteLine("Please, enter a number. The program finish with 'exit'");
            //while (true)
            //{              
            //    string txt = Console.ReadLine();
            //    if (txt.ToLower()=="exit")                
            //        break;
                               
            //    if (double.TryParse(txt,out double val))
            //        Console.WriteLine($"The number is {val}");
            //    else
            //        Console.WriteLine($"Its not a number");               
            //}
            //    { }



            //16. Solicite un ingreso al usuario y determine si puede ser interpretado como un número entero.
            //(De aquí en más todos los ingresos del usuario deben ser verificados, finalizando el programa con un mensaje de error en caso de ser inválidos)

            //Console.WriteLine("Please, enter a number. The program finish with 'exit'");
            //while (true)
            //{
            //    string txt = Console.ReadLine();
            //    if (txt.ToLower() == "exit")
            //        break;

            //    if (int.TryParse(txt, out int val))
            //        Console.WriteLine($"The number is {val}");
            //    else
            //    {
            //        Console.WriteLine($"Its not a number");
            //        break;
            //    }                    
            //}
            //Console.ReadKey();

            //17. Solicite el ingreso de dos números al usuario y presente la suma, la resta, la multiplicación, la división, el resto, el primero elevado a la potencia del segundo.



            //18. Solicite el ingreso de un número al usuario y lo presente redondeado a dos decimales.

        }
    }
}
