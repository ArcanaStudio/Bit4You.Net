namespace Net.Arcanastudio.Bit4You.Model.Request.Generic
{
    public abstract class SimulableRequestBase
    {
        public bool IsSimulation { get; }

        protected SimulableRequestBase(bool isSimulation = false)
        {
            IsSimulation = isSimulation;
        }
    }
}
