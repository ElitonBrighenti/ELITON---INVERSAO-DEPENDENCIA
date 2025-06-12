using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELITON___INVERSAO_DEPENDENCIA
{
    public class Lamp : IDevice
    {
        private State state;

        public Lamp(State initialState)
        {
            state = initialState;
        }

        public void Operate()
        {
            state = (state == State.On) ? State.Off : State.On;
            Console.WriteLine("Luz = " + (state == State.On ? "Ligada" : "Desligada"));
        }
    }
}
