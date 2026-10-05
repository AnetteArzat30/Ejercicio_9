Console.WriteLine("SISTEMA DE MONITOREO DE MOTORES");
Console.WriteLine();

// Crear un objeto de la clase Motor
Motor motor1 = new Motor();

// Capturar la información del objeto
Console.Write("Ingrese el identificador del motor: ");
motor1.Identificador = Console.ReadLine() ?? "Sin ID";

Console.Write("Ingrese la temperatura (°C): ");
motor1.Temperatura = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la corriente (A): ");
motor1.Corriente = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la velocidad (RPM): ");
motor1.Velocidad = Convert.ToDouble(Console.ReadLine());

// Mostrar resultados
Console.WriteLine();
Console.WriteLine($"Motor ID: {motor1.Identificador}");
Console.WriteLine($"Temperatura: {motor1.Temperatura} °C");
Console.WriteLine($"Corriente: {motor1.Corriente} A");
Console.WriteLine($"Velocidad: {motor1.Velocidad} RPM");
Console.WriteLine($"Alerta Temperatura: {motor1.VerificarTemperatura()}");
Console.WriteLine($"Estado del motor: {motor1.ObtenerEstado()}");


// Definición de la clase
class Motor
{
    // Propiedades
    public string Identificador { get; set; } = "";
    public double Temperatura { get; set; }
    public double Corriente { get; set; }
    public double Velocidad { get; set; }

    // Método para determinar si la temperatura es mayor a 70 °C
    public string VerificarTemperatura()
    {
        if (Temperatura > 70)
        {
            return "ALTA (Mayor a 70 °C)";
        }
        else
        {
            return "NORMAL (Menor o igual a 70 °C)";
        }
    }

    // Método para determinar si está detenido o en marcha
    public string ObtenerEstado()
    {
        if (Velocidad == 0)
        {
            return "DETENIDO";
        }
        else
        {
            return "EN MARCHA";
        }
    }
}