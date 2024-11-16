namespace DiwaliCelebration.DIP
{
    public class ElectricLamp : ILightSource
    {
        public void LightUp()
        {
            Console.WriteLine("Lamp is glowing!");
        }
    }
}
