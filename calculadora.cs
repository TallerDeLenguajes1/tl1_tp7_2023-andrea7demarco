namespace EspacioCalculadora;

public class Calculadora{ //lo q está entre llaves está relacionado a la clase calculadora //
// la clase no escribe en pantalla xq tengo q poder pasarla a otro lenguaje sin problemas , por ej el writeline prop de c#
    private double valor; //atributo privado 

    public Calculadora() //constructor 
    {
        valor=0;
    }

    public double Resultado { get => valor;} //prop


    public void Suma(double sumando)   //metodo
    {
        valor+=sumando;
    }

    public void Resta(double sustraendo)
    {
        valor-=sustraendo;
    }



}