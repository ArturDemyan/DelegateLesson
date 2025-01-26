namespace DelegateHW11
{


    class Program
    {
        static void Main(string[] args)
        {
            var opManager = new OperationManager(20, 10);
            var result = opManager.Execute(Operation.Sum);
            
        }
    }
}
