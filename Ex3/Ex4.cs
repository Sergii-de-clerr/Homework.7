using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Ex4
    {
        // Порушено принцип ISP.
        // Треба створити декілька
        // користувацьких інтерфейсів.
        interface IItem
        {
            void ApplyDiscount(String discount);
            void ApplyPromocode(String promocode);
            void SetColor(byte color);
            void SetSize(byte size);
            void SetPrice(double price);
        }
        interface Book : IItem
        {
            new void ApplyDiscount(String discount);
            new void ApplyPromocode(String promocode);
            new void SetPrice(double price);
        }
        interface Game_Console : IItem
        {
            new void ApplyDiscount(String discount);]
            new void SetColor(byte color);
            new void SetPrice(double price);
        }
        interface Monitor : IItem
        {
            new void ApplyDiscount(String discount);
            new void ApplyPromocode(String promocode);
            new void SetSize(byte size);
            new void SetPrice(double price);
        }
    }
}
