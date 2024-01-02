namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : 
        base(numero, modelo, imei, memoria)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            string aspas = "\"";
            Console.WriteLine($"Instalando o aplicativo: {aspas}{nomeApp}{aspas} no Iphone!");
        }
    }
}