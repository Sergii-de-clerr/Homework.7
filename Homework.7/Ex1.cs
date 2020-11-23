using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework._7
{
    class Ex1
    {
        class Item
        {
        }
        class Order
        {
            private List<Item> itemList;
            internal List<Item> ItemList
            {
                get
                {
                    return itemList;
                }
                set
                {
                    itemList = value;
                }
            }
            public void CalculateTotalSum() {/*...*/}
            public void GetItems() {/*...*/}
            public void GetItemCount() {/*...*/}
            public void AddItem(Item item) {/*...*/}
            public void DeleteItem(Item item) {/*...*/}
            public void PrintOrder() {/*...*/}
            public void ShowOrder() {/*...*/}
            // Я вважаю що тут порушено перший принцип(SSP).
            // Оскільки в клас повинен бути пов'язаний
            // однією спільною метою, то методи Load(),
            // Save(), Update(), Delete() не мають ніякого
            // відношення до классу для представлення
            // замовлення в магазині.
            public void Load() {/*...*/}
            public void Save() {/*...*/}
            public void Update() {/*...*/}
            public void Delete() {/*...*/}
        }
    }
}
