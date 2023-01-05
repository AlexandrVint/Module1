using System;
using Module1.Infrastructure.Commands.Base;

namespace Module1.Infrastructure.Commands
{
   internal class LambdaCommand : Command
   {
       private readonly Action<object> execute;
       private readonly Func<object, bool> canExecute;

       public LambdaCommand(Action<object> Execute, Func<object, bool> CanExecute = null)
       {
           execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
           canExecute = CanExecute;
       }

        public override bool CanExecute(object parameter)
        {
            return canExecute?.Invoke(parameter) ?? true;
        }

        public override void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
