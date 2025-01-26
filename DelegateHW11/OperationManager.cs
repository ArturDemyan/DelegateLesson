using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHW11
{
    public enum Operation
    {
        Sum,
        Subtract,
        Multiply
    }
 
    public class OperationManager
    {
        private int _first;
        private int _second;
        private ExecutionManager executionManager;
         public OperationManager(int first, int second)
         {
            _first = first;
            _second = second;
            executionManager = new ExecutionManager(this);
            executionManager.PrepareExecution();

        }
        public int Sum()
        {
            return _first + _second;
        }
        public int Subtract()
        {
            return _first - _second;
        }
        public int Multiply()
        {
            return _first * _second;
        }
        public int Execute(Operation operation)
        {
            return executionManager.FuncExecute[operation]();
        }
 

    }
}
