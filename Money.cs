using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourLesson
{
    class Money
    {
       private int _denominationOfBanknote;
       private int _amountOfBanknotes;

        #region Constructors
        public Money()
        {
            _denominationOfBanknote = 0;
            _amountOfBanknotes = 0;
        }
        public Money(int denominationOfBanknote,int amountOfBanknotes)
        {
            _denominationOfBanknote = denominationOfBanknote;
            _amountOfBanknotes = amountOfBanknotes;
        }
        #endregion

        #region Getters and Setters
        public int GetDenominationOfBanknote()
        {
            return _denominationOfBanknote;
        }
        public void SetDenominationOfBanknote(int denominationOfBanknote)
        {
            _denominationOfBanknote = denominationOfBanknote;
        }

        public int GetAmountOfBanknotes()
        {
            return _amountOfBanknotes;
        }
        public void SetAmountOfBanknotes(int amountOfBanknotes)
        {
            _amountOfBanknotes = amountOfBanknotes;
        }
        #endregion

        public int TotalMoney()
        {
            return _denominationOfBanknote * _amountOfBanknotes;
        }

        public bool IsEnoughMoney(int cost)
        {
            return TotalMoney() >= cost ? true : false; 
        }

        public int quantityOfGoods(int costOfOneGood)
        {
            return TotalMoney() / costOfOneGood;
        }

        public void showDenominationAndAmountOfBanknotes()
        {
            Console.WriteLine($"{GetAmountOfBanknotes()} notes with par {GetDenominationOfBanknote()}");
        }
    }
}
