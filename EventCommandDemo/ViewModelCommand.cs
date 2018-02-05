using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCommandDemo
{
   public class ViewModelCommand : System.Windows.Input.ICommand
    {
        private Action<Object> action;

        public Action<Object> ViewModelAction
        {
            get { return action; }
            set { action = value; }
        }

        public ViewModelCommand(Action<Object> act)
        {
            action = act;
        }

        public bool CanExecute(Object parameter)
        {
            return true;
        }

        public void Execute(Object parameter)
        {
            this.ViewModelAction(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { }
            remove { }
        }
    }
}
