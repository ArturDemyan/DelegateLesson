using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHW11
{
    public class ExecutionManager
    {
        private OperationManager _operationManager;
        public Dictionary<Operation, Func<int>> FuncExecute { get; set; }
        public ExecutionManager() { }
        public ExecutionManager(OperationManager operationManager)
        {
            _operationManager = operationManager;
            FuncExecute = new Dictionary<Operation, Func<int>>();
        }
 

        public void PopulateFunctions(Operation operation,Func<int> func)       //pass delegates and register
        {
            FuncExecute.Add(operation, func);
        }

 

        public void PrepareExecution()
        {
            PopulateFunctions(Operation.Sum, () => _operationManager.Sum());
            PopulateFunctions(Operation.Multiply, () => _operationManager.Multiply());
            PopulateFunctions(Operation.Multiply, () => _operationManager.Subtract());
        }

    }
}
