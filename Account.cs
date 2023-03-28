using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17
{
    public class Account
    {
        // тип учетной записи
        public string Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        // поле для хранения метода расчёта
        private ICalculateInterest calculateMethod;

        // Метод для расчёта
        public void SetCalculateMethod(ICalculateInterest method)
        {
            this.calculateMethod = method;
        }

        // Расчёт для аккаунта
        public void CalculateInterest()
        {
            this.Interest = calculateMethod.CalculateInterest(this);
        }
    }
}
