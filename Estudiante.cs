namespace POO;

class Estudiante : Persona{
    public void Estudiar(){
        Console.WriteLine("Estoy estudiando");
    }
    public void MostrarEdad(){
        Console.WriteLine($"Mi edad es:{edad} años");
    }
}
