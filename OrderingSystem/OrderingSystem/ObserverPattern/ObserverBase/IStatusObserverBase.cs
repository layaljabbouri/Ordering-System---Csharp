using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystem.BuilderPattern.Product;

namespace OrderingSystem.ObserverPattern.ObserverBase
{
    public interface IStatusObserverBase
    {
        void Notify(int ordernum, String orderStatus);
    }
}
