using System;
using System.Collections.Generic;

namespace Pracktika5_6
{
    class Program
    {
       static  List<Product> lst;
        static void Main(string[] args)
        {
            lst = new List<Product>() { new Product(1,"Мишка", "", "", 1, true, 2),
            new Product(2,"Кукла", "", "", 3, true, 4),
            new Product(3,"Машинка", "", "", 5, true, 6),
            new Product(4,"Мячик", "", "", 3, true, 8) };

            while (true)
            {
                int a = Menu();
                if (a == 1)
                {
                    GetList(lst);
                }
                else if (a == 2)
                {
                    Filter();
                }
                else if (a == 3)
                {
                    GetList(lst);
                    int aa = int.Parse(Console.ReadLine());
                    Buy(aa);
                }
                else if (a == 4)
                {
                    Find();
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
      
        static int Menu()
        {
            
            Console.WriteLine("1) Список");
            Console.WriteLine("2) Фильтрация");
            Console.WriteLine("3) Покупка");
            Console.WriteLine("4) Поиск");
            var a = Console.ReadLine();
            return int.Parse(a);
        }

        static void GetList(List<Product> lst)
        {
            foreach (var item in lst)
            {
                Console.WriteLine($"{item}") ;
            }
        }

        static void Filter()
        {
            Console.WriteLine("1) Производитель");
            Console.WriteLine("2) Отсортировать по цене");
            int f = Convert.ToInt32(Console.ReadLine());
            if (f==1)
            {
                var a = Console.ReadLine();
                GetList(lst.FindAll((x) => x.Manufacturer == a));
            }
            else if(f==2)
            {
                Console.WriteLine("От меньшей");
                Console.WriteLine("От большей");
                int pr = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void Find()
        {
            Console.WriteLine("Введите название игрушки");
            string name = Console.ReadLine();
            GetList( lst.FindAll((x) => x.Name == name));
        }

        static void Buy(int a)
        {
            Product product = lst.Find(x => x.Id == a);
            Console.WriteLine("Введите количество товара");
            int count = Convert.ToInt32(Console.ReadLine());
            if(product.InStock <  count)
                Console.WriteLine("Не получается купить");
            else
            {

                Console.WriteLine("Вид оплаты: 1)Наличными 2)Банковская карта 3)Google Pay 4)Apple Pay");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Способо получение: 1)Самовывоз 2)Доставка 3)Срочная доставка");
                int d = Convert.ToInt32(Console.ReadLine());
                if (d == 2 || d == 3)
                {
                    Console.WriteLine("Введите адресс");
                    string adrs = Console.ReadLine();
                }

                Console.WriteLine("Введиет ФИО");
                string fio = Console.ReadLine();

                Console.WriteLine("Телефон");
                int phone = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Вы купили товар!");
            }
        }
    }
}
