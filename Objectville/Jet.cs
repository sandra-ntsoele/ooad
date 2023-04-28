namespace Objectville
{
    class Jet:Airplane
    {
        public int MULTIPLIER = 2;

        public Jet():base() {}

        public new void SetSpeed(int Speed)
        {
            base.SetSpeed(Speed * MULTIPLIER);
        }

        public void Accelerate() 
        {
            base.SetSpeed(GetSpeed() * 2);
        }
    }
}