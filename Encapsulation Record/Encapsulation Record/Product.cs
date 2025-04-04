﻿namespace Encapsulation_Record
{
    class Product
    {
        private string _id;
        private string _brandName;
        private string _model;
        private decimal _price;
        private decimal _cost;
        private decimal _income;
        private int _count;


        public string Id
        {
            get
            {
                return _id;
            }
        }

        public string BrandName
        {
            get
            {
                return _brandName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("brend adi bos ola bilmez!");
                    return;
                }
                else if (value.Length >= 2)
                {
                    value = value.Trim();
                    _brandName = char.ToUpper(value[0]) + value.Substring(1).ToLower();
                }
                else
                {
                    Console.WriteLine("format yanlishdir!");
                    return;
                }
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("model adi bos ola bilmez!");
                    return;
                }
                else
                {
                    value = value.Trim();
                    string[] words = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < words.Length; i++)
                    {
                        if (words[i].Length > 0)
                        {
                            words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                        }
                    }

                    _model = string.Join(" ", words);
                }
                _id = _brandName.Substring(0, 2) + _model.Substring(0, 2);
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("qiymet duzgun teyin olunmayib! minimum 1 azn daxil olunmalidir.");
                    _price = 1;
                }
                else if (value >= 5000)
                {
                    Console.WriteLine("qiymet duzgun teyin olunmayib! maximum 5000 azn daxil oluna biler.");
                    _price = 5000;
                }
                else
                {
                    _price = value;
                }
            }

        }

        public decimal Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("ugursuz cehd.");
                    _cost = 1;
                }
                else if (value > Price)
                {
                    Console.WriteLine("xerc mehsulun qiymetinden cox olmamalidir!");
                    _cost = Price;
                }
                else
                {
                    _cost = value;
                }
            }
        }

        public decimal Income
        {
            get
            {
                return _income;
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("count menfi ola bilmez.");
                    _count = 0;
                }
                else
                {
                    _count = value;
                }
            }
        }



        public Product(string brandName, string model, decimal price, decimal cost, int count)
        {
            BrandName = brandName;
            Model = model;
            Price = price;
            Cost = cost;
            Count = count;

            _id = _brandName.Substring(0, 2) + _model.Substring(0, 2);
            _income = 0;
        }



        public void GetInfo()
        {
            Console.WriteLine($"ID: {Id} ; Brand: {BrandName} ; Model: {Model} ; Price: {Price} AZN ; Cost: {Cost} AZN ; Count: {Count}");
            Console.WriteLine($"Income : {Income} AZN");
        }



        public void Sale(int numberoftheproducts)
        {
            if (numberoftheproducts <= 0)
            {
                Console.WriteLine("minimum 1 mehsul olmalidir!");
                return;
            }
            else if (numberoftheproducts > Count)
            {
                Console.WriteLine("kifayet qeder mehsul yoxdur.");
                return;
            }

            decimal totalIncome = (Price - Cost) * numberoftheproducts;
            _income += totalIncome;
            _count -= numberoftheproducts;
            Console.WriteLine($"{numberoftheproducts} mehsul satıldı");
            Console.WriteLine($"Total gelirimiz: {_income} AZN");
        }
    }
}

