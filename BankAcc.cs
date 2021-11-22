using System;


namespace OOP_Homework_2
{
    public class BankAcc
    {
        private ulong _numberAcc;
        private int _balance = 0;
        private static int _type = 5;

        public ulong NumberAcc
        {
            get { return _numberAcc; }
            set { _numberAcc = value; }
        }
        public int Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public int Type
        {
            get { return _type; }
            set
            {
                if (value < 1 && value > 11)
                { _type = 5; }
                else
                { _type = value; }
            }
        }


        public BankAcc()
        {
            NumberAcc = _numberAcc;
            Balance = _balance;
            Type = _type;
        }


        public int ChooseType()
        {
            Console.WriteLine("Типы счетов: ");
            for (int i = (int)TypeAcc.Бюджетный; i <= (int)TypeAcc.Чековый; i++)
            {
                Console.WriteLine($"-{i}) {(TypeAcc)i}");
            }
            Console.Write("Какой тип счёта хотите выбрать? Введите число: ");
            bool a = int.TryParse(Console.ReadLine(), out int b);
            if (b > 1 && b < 11)
            {
                _type = b;
            }
            else
            {
                _type = 5;
            }
            return _type;
        }
        public ulong SetNumberAcc(string file)
        {
            Console.WriteLine($"Выберите один из свободных номеров счёта(нужно указать его порядковый номер): ");
            Files.DisplayFile(@"NumberAcc.txt");
            string choose = Console.ReadLine();
            _numberAcc = ulong.Parse(Files.SearchInFile(@"NumberAcc.txt", choose));

            return _numberAcc;
        }
        public int PutInBalance()
        {
            Console.WriteLine($"Какой изначальный депозит положить на счёт?(нужно указать только сумму)");
            bool putbool = int.TryParse(Console.ReadLine(), out _balance);
            return _balance;
        }
        public void Display()
        {
            Console.WriteLine($"Номер счёта: {_numberAcc:#### #### #### ####}\nТип счёта: {(TypeAcc)_type}\nБаланс: {_balance} Долларов Гикбрейнс");
        }
        public void DisplayType()
        {
            Console.WriteLine($"Тип счёта: {(TypeAcc)_type}");
        }
        public void DisplayNumbAcc()
        {
            Console.WriteLine($"Номер счёта: {_numberAcc:#### #### #### ####}");
        }
        public void DisplayBalance()
        {
            Console.WriteLine($"Баланс: {_balance} Долларов Гикбрейнс");
        }

        public enum TypeAcc
        {
            Бюджетный = 1,
            Валютный,
            Накопительный,
            Обезличенный,
            Общий,
            Сберегательный,
            Текущий,
            Транзитный,
            Фондовый,
            Частный,
            Чековый,
        }
    }
}
