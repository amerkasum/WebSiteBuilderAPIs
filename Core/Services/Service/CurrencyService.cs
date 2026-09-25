using Core.Services.IService;
using Core.UnitOfWork;
using Domain.Entities.System;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class CurrencyService : ICurrencyService
    {
        private readonly IUnitOfWork UnitOfWork;
        public CurrencyService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        public Currency Add(CurrencyViewModel model)
        {
            var currency = new Currency
            {
                Name = model.Name,
                Code = model.Code,
                Symbol = model.Symbol,
                DecimalPlaces = model.DecimalPlaces
            };

            UnitOfWork.Currency.Add(currency);
            UnitOfWork.SaveChanges();

            return currency;
        }
        public Currency Edit(CurrencyViewModel model)
        {
            var currency = UnitOfWork.Currency.GetById(model.Id);

            if (currency == null)
                throw new KeyNotFoundException();

            currency.Name = model.Name;
            currency.Code = model.Code;
            currency.Symbol = model.Symbol;
            currency.DecimalPlaces = model.DecimalPlaces;

            UnitOfWork.Currency.Update(currency);
            UnitOfWork.SaveChanges();

            return currency;
        }

        public void Delete(int id)
        {
            var currency = UnitOfWork.Currency.GetById(id);

            if (currency == null)
                throw new KeyNotFoundException();

            UnitOfWork.Currency.Remove(currency);
            UnitOfWork.SaveChanges();
        }

        
    }
}
