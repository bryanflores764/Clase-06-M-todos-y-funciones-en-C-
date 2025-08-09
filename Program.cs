namespace Clase_06_Métodos_y_funciones_en_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ejercicio de calculador de areas
            //int opcion = 0;
            //bool contuniar = true;

            //while (contuniar)
            //{
            //    Console.WriteLine("Menu#");
            //    Console.WriteLine("opcion 1 Area Triangulo");
            //    Console.WriteLine("opcion 2 Area Cuadrado");
            //    Console.WriteLine("opcion 3 Area Rectangulo");
            //    Console.WriteLine("opcion 4 salir");
            //    Console.WriteLine("Ingrese una opcion");

            //    bool esValido = int.TryParse(Console.ReadLine(), out opcion);

            //    if (!esValido)
            //    {

            //        Console.WriteLine("Porfavor ingrese una numero valido.");
            //        continue;

            //    }


            //    if (opcion == 1 || opcion == 2 || opcion == 3)
            //    {


            //        switch (opcion)
            //        {
            //            case 1:
            //                Console.WriteLine("Ingrese su  Base");
            //                decimal Base = Convert.ToDecimal(Console.ReadLine());
            //                Console.WriteLine("Ingrese su Altura");
            //                decimal altura = Convert.ToDecimal(Console.ReadLine());
            //                AreaTriangulo(Base, altura);
            //                break;
            //            case 2:
            //                Console.WriteLine("Ingrese su  primer lado");
            //                decimal lado1 = Convert.ToDecimal(Console.ReadLine());
            //                Console.WriteLine("Ingrese su segundo lado");
            //                decimal lado2 = Convert.ToDecimal(Console.ReadLine());

            //                AreaCuadrado(lado1, lado2);

            //                break;
            //            case 3:
            //                Console.WriteLine("Ingrese su  Base");
            //                decimal Base1 = Convert.ToDecimal(Console.ReadLine());
            //                Console.WriteLine("Ingrese su Altura");
            //                decimal altura1 = Convert.ToDecimal(Console.ReadLine());

            //                AreaRectangulo(Base1, altura1);


            //                break;
            //        }


            //    }
            //    else if (opcion == 4)
            //    {
            //        contuniar = false;
            //        Console.WriteLine("Programa finaliza ");
            //    }
            //    else
            //    {

            //        Console.WriteLine("Opcion invalida");
            //    }

            //    Console.WriteLine("Continuar");
            //}


            //ejercicio modificado de calculadora de divicion suma resta multiplicacion
            //variables 
            //    int opcion;
            //    decimal r; //Almacena el valor devuelto de resta
            //    decimal num1Ar, num2Ar;
            //    bool salir = true;

            //    while (salir) {
            //        {
            //            Console.WriteLine("1. Sumar: ");
            //            Console.WriteLine("2. Restar: ");
            //            Console.WriteLine("3. Multiplicar: ");
            //            Console.WriteLine("4. Division");
            //            Console.WriteLine("5.Salir");
            //            //Pedimos una opcion

            //            Console.WriteLine("Elige una opcion: ");
            //            opcion = Convert.ToInt32(Console.ReadLine());

            //        }
            //        while ((opcion < 1) || (opcion > 5)) ;
            //        //hacer la operacion según la opción elegida

            //        switch (opcion)
            //        {
            //            case 1:
            //                Sumar();
            //                break;
            //            case 2:
            //                r = Restar(); //Asinamos el valor devuelto por "Return"
            //                              //Mostramos el resultado, con la informacion que contiene "r"
            //                Console.WriteLine("El resultado de la resta es:{0} ", r);
            //                break;
            //            case 3:
            //                Console.WriteLine("Introduce el primer numero: ");
            //                num1Ar = Convert.ToDecimal(Console.ReadLine());

            //                Console.WriteLine("Introduce el segundo numero: ");
            //                num2Ar = Convert.ToDecimal(Console.ReadLine());

            //                //Invocamos al metodo
            //                Multiplicar(num1Ar, num2Ar);
            //                break;

            //            case 4:
            //                Console.WriteLine("Introduce el primer numero: ");
            //                num1Ar = Convert.ToDecimal(Console.ReadLine());

            //                Console.WriteLine("Introduce el segundo numero: ");
            //                num2Ar = Convert.ToDecimal(Console.ReadLine());

            //                r = Dividir(num1Ar, num2Ar);
            //                Console.WriteLine("El resultado de la división es:{0} ", r);
            //                break;

            //                case 5:
            //                salir = false;
            //                Console.WriteLine("Programa finaliza ");
            //                break;
            //        }

            //    }

            //}// Cierre del main 

            ////[modificador] [tipo] [Nombre] [parametros]
            //static void Sumar()
            //{
            //    //Variables del metodo sumar ()
            //    decimal num1, num2, resultado;
            //    Console.WriteLine("Introduce el primer numero: ");
            //    num1 = Convert.ToDecimal(Console.ReadLine());

            //    Console.WriteLine("Introduce el segundo numero: ");
            //    num2 = Convert.ToDecimal(Console.ReadLine());

            //    resultado = num1 + num2;
            //    //Mostramos el resultado
            //    Console.WriteLine("{0} + {1} = {2}", num1, num2, resultado);
            //}
            //static decimal Restar()
            //{
            //    //Variables del metodo Restar ()
            //    decimal num1, num2, resultado;

            //    Console.WriteLine("Introduce el primer numero: ");
            //    num1 = Convert.ToDecimal(Console.ReadLine());

            //    Console.WriteLine("Introduce el segundo numero: ");
            //    num2 = Convert.ToDecimal(Console.ReadLine());

            //    //Operacion 
            //    resultado = num1 - num2;

            //    //Devolvemos un tipo al autor de llamado 
            //    return resultado;





            //}

            //metodos de calculadora
            //static void Multiplicar(decimal num1Pa, decimal num2Pa)
            //{
            //    //Declaracion de variables
            //    decimal resultado;

            //    //Multiplicacion con los valores que mandan los arguementos
            //    resultado = num1Pa * num2Pa;

            //    //Mostramos el resultado
            //    Console.WriteLine("{0} * {1} = {2}", num1Pa, num2Pa, resultado);
            //}

            ////[modificador] [tipo] [Nombre] [parametros]
            //static decimal Dividir(decimal num1Pa, decimal num2Pa)
            //{
            //    //Variable 
            //    decimal resultado;
            //    if (num2Pa != 0)
            //    {
            //        //Division con los valores que mandaron los argumentos
            //        resultado = num1Pa / num2Pa;
            //    }
            //    else
            //    {
            //        Console.WriteLine("No es prosible dividir entre cero");
            //        resultado = 0;
            //    }
            //    return resultado;
            //}


            //metodos de calculador de areas

            //static void AreaTriangulo(decimal Base, decimal Altura)
            //{
            //    decimal AreaTriangulo = (Base * Altura) / 2;
            //    Console.WriteLine($"El areal del triangulo es: {AreaTriangulo}cm \r\n2");
            //}

            //static void AreaCuadrado(decimal lado,decimal lado2)
            //{
            //    decimal AreaCudrado = (lado * lado2);
            //    Console.WriteLine($"El area del cuadrado es:{AreaCudrado}\r\n2");
            //}

            //static void AreaRectangulo(decimal Base, decimal Altura)
            //{
            //    decimal AreaRectangulo = (Base * Altura);
            //    Console.WriteLine($"El areal del rectangulo:${AreaRectangulo}cm \r\n2 ");
            //}

        }



    }
}
