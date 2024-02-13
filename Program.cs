using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# é altamente tipada. Tipos de dado:
            byte meuByte = 127; //representa 8bits unasigned integer
            sbyte meuSbyte = -23; //signed bytes, permite integers negativos

            uint idade = 20;  //inteiros short/int/long, e para NAO permitir numeros negativos ushort/uint/ulong u é 'unasigned'
            int idade0; //Correto inicia com zero
            double salario = 10.250;//float/double/decimal para numeros que exigem pontuação

            bool jaCadastrado = true; //booleano

            char charUnicode = '1'; //Utilizado para armazenar apenas um caracter no formato unicode. Usar aspas simples.
            string palavra = "Hello World"; //lista de caracteres, para string usar aspas duplas
    
            var idade2 = 40; //var substitui o nome de qualquer tipo, esse vai ser identificado automaticamente como int 
            
            var texto = "meu texto"; //var sempre será do tipo do primeiro valor atribuido

            

            Console.WriteLine(meuByte - meuSbyte - idade);
        }
    }
}
