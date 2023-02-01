using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystem.ObserverPattern.ObserverBase;

namespace OrderingSystem.ObserverPattern.SubjectBase
{
    public abstract class OrderStatusPublisherBase
    {
        readonly protected List<IStatusObserverBase> _observers = new List<IStatusObserverBase>();

        public void register(IStatusObserverBase observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void unregister(IStatusObserverBase observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }

        public abstract void Notify();


    }
}
