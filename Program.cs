using EspacioCalculadora;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string? input,siNoStr;
bool parseoBool;
int siNo;
int numero,operacion;
Calculadora cal=new Calculadora();  //cal objeto q yo quiero crear  
 
do {
    Console.WriteLine("Ingrese la operacion:");
    Console.WriteLine("1-SUMAR");
    Console.WriteLine("2-RESTAR");
    Console.WriteLine("3-MULTIPLICAR");
    Console.WriteLine("4-DIVIDIR");
    Console.WriteLine("5-LIMPIAR");
    input =Console.ReadLine();
    parseoBool= int.TryParse(input, out operacion);
    Console.WriteLine("Ingrese el número:");
    input = Console.ReadLine();
    parseoBool = int.TryParse(input, out numero);
    
    switch(operacion){
        case 1:
             cal.Suma(numero);
             Console.WriteLine(cal.Resultado);
             break;
        case 2:
             cal.Resta(numero);
             Console.WriteLine(cal.Resultado);
             break;
        case 3:
             cal.Multiplicacion(numero);
             Console.WriteLine(cal.Resultado);
             break;

        case 4:
             cal.Dividir(numero);
             Console.WriteLine(cal.Resultado);
             break;
        
        case 5:
             cal.Limpiar();
             Console.WriteLine(cal.Resultado);
             break; 
        default:
             Console.WriteLine("El numero ingresado no corresponde a ninguna operación");
             break;
            
    }

    Console.WriteLine("Quiere seguir operando: SI[1] - NO[0]");
    siNoStr = Console.ReadLine();
    parseoBool = int.TryParse(siNoStr, out siNo);
    Console.Clear();

}while(siNo == 1);
