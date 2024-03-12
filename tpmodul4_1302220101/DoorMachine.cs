using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302220101
{
    public class DoorMachine
    {
        enum State {Terkunci, Terbuka};
        State state;

        public DoorMachine()
        {
            this.state = State.Terkunci;
        }

        public void changeState(String trigger)
        {
            switch (state)
            {
                case State.Terkunci:
                    if (trigger == "BukaPintu")
                    {
                        this.state = State.Terbuka;
                        Console.WriteLine("Pintu tidak terkunci");
                    } else if (trigger == "KunciPintu")
                    {
                        this.state = State.Terkunci;
                        Console.WriteLine("Pintu terkunci");
                    } else
                    {
                        this.state = State.Terkunci;
                        Console.WriteLine("Pintu terkunci");
                    }
                    break;

                case State.Terbuka:
                    if (trigger == "KunciPintu")
                    {
                        this.state = State.Terkunci;
                        Console.WriteLine("Pintu terkunci");
                    } else if (trigger == "BukaPintu")
                    {
                        this.state = State.Terbuka;
                        Console.WriteLine("Pintu tidak terkunci");
                    } else
                    {
                        this.state = State.Terbuka;
                        Console.WriteLine("Pintu tidak terkunci");
                    }
                    break ;
            }
        }
    }
}
