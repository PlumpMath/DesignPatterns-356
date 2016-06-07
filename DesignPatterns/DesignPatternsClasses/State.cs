using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatternsClasses
{
    /// <summary>
    /// Name: State;
    /// Other name: FSM;
    /// Classification: behavioral,to objects;
    /// Frequency of use: 3;
    /// </summary>
    abstract class State
    {
        public abstract void Handle(ContextWithState context);
    }
    class ConcreteStateA : State
    {
        public override void Handle(ContextWithState context)
        {
            Console.WriteLine("State A, go to State B");
            context.State = new ConcreteStateB();
        }
    }
    class ConcreteStateB : State
    {
        public override void Handle(ContextWithState context)
        {
            Console.WriteLine("State B, go to State A");
            context.State = new ConcreteStateA();
        }
    }

    class ContextWithState
    {
        public State State { get; set; }

        public ContextWithState(State state)
        {
            this.State = state;
        }
        public void Request()
        {
            this.State.Handle(this);
        }
    }
}
