using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    public interface ISubject
    {
        void Register(IObserver observer);
        void Unregister(IObserver observer);

        void Notify();
    }
}
