namespace DiwaliCelebration.DIP
{
    public class FestivalController
    {
        private readonly ILightSource _lightSource;

        public FestivalController(ILightSource lightSource)
        {
            _lightSource = lightSource;
        }

        public void BeginCelebration()
        {
            _lightSource.LightUp();
        }
    }
}
