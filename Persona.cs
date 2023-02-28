namespace POO;

class Persona
{
   public int edad; 
    public void Saludar(){
        Console.WriteLine("Hola!");
   }
   public void SetEdad(int edad){
        this.edad=edad;
   }
}
public class Profesor : Persona
{
    public void Explicar()
    {
        Console.WriteLine("Estoy explicando");
    }
}