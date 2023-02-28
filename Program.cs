namespace POO;
class Program
{
    static void Main(string[] args)
    {
        Persona persona = new Persona();
        persona.Saludar();

        Estudiante estudiante = new Estudiante();
        estudiante.SetEdad(19);
        estudiante.MostrarEdad();
        estudiante.Estudiar();

        Profesor profe = new Profesor();
        profe.SetEdad(100);
        profe.Saludar();
        profe.Explicar();
    }
}