namespace Clase_06_Métodos_y_funciones_en_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            bool contuniar = true;

            while (contuniar)
            {
                Console.WriteLine("Menu#");
                Console.WriteLine("opcion 1 Area Triangulo");
                Console.WriteLine("opcion 2 Area Cuadrado");
                Console.WriteLine("opcion 3 Area Rectangulo");
                Console.WriteLine("opcion 4 salir");
                Console.WriteLine("Ingrese una opcion");

                bool esValido = int.TryParse(Console.ReadLine(), out opcion);

                if (!esValido)
                {

                    Console.WriteLine("Porfavor ingrese una numero valido.");
                    continue;

                }


                if (opcion == 1 || opcion == 2 || opcion == 3)
                {

                 
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese su  Base");
                            decimal Base = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("Ingrese su Altura");
                            decimal altura = Convert.ToDecimal(Console.ReadLine());
                            AreaTriangulo(Base, altura);
                            break;
                        case 2:
                            Console.WriteLine("Ingrese su  primer lado");
                            decimal lado1 = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("Ingrese su segundo lado");
                            decimal lado2 = Convert.ToDecimal(Console.ReadLine());

                            AreaCuadrado(lado1, lado2);

                            break;
                        case 3:
                            Console.WriteLine("Ingrese su  Base");
                            decimal Base1 = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("Ingrese su Altura");
                            decimal altura1 = Convert.ToDecimal(Console.ReadLine());

                            AreaRectangulo(Base1, altura1);


                            break;
                    }


                }
                else if (opcion == 4)
                {
                    contuniar = false;
                    Console.WriteLine("Programa finaliza ");
                }
                else
                {

                    Console.WriteLine("Opcion invalida");
                }

                Console.WriteLine("Continuar");
            }




        }

        static void AreaTriangulo(decimal Base, decimal Altura)
        {
            decimal AreaTriangulo = (Base * Altura) / 2;
            Console.WriteLine($"El areal del triangulo es: {AreaTriangulo}cm \r\n2");
        }

        static void AreaCuadrado(decimal lado,decimal lado2)
        {
            decimal AreaCudrado = (lado * lado2);
            Console.WriteLine($"El area del cuadrado es:{AreaCudrado}\r\n2");
        }

        static void AreaRectangulo(decimal Base, decimal Altura)
        {
            decimal AreaRectangulo = (Base * Altura);
            Console.WriteLine($"El areal del rectangulo:${AreaRectangulo}cm \r\n2 ");
        }

    }
}
