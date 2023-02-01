using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystem.BuilderPattern.Product;

namespace OrderingSystem.ObserverPattern.ConcreteSubjects
{
    public class ConcretePublisher: SubjectBase.OrderStatusPublisherBase
    {
        private int ordernum;
        private string orderstatus;

        public void Order(int num, String status)
        {
            ordernum = num; orderstatus = status;
        }

        public override void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Notify(ordernum, orderstatus);
            }
        }

    }
}
