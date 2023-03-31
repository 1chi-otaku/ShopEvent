using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            IphoneSubscriber iphone_subscriber = new IphoneSubscriber();   
            shop.Attach(iphone_subscriber);
            AndroidSubscriber android_subscriber = new AndroidSubscriber();
            shop.Attach(android_subscriber);

            shop.PublishNewIPhone();
        }
    }
}
