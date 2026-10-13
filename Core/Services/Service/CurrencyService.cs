using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.System;
using Domain.Requests;
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
        private readonly IAuditLogService AuditLogService;
        public CurrencyService(IUnitOfWork unitOfWork, IAuditLogService auditLogService)
        {
            this.UnitOfWork = unitOfWork;
            this.AuditLogService = auditLogService;
        }

        public async Task<IEnumerable<CurrencyDto>> GetAsync(BasicSearchRequest model)
        {
            model.Search = model?.Search?.Trim();
            var result = await UnitOfWork.Currency.GetAsync(model);
            return result;
        }

        public async Task<Currency> AddAsync(CurrencyViewModel model)
        {
            var currency = new Currency
            {
                Name = model.Name,
                Code = model.Code,
                Symbol = model.Symbol,
                DecimalPlaces = model.DecimalPlaces
            };

            UnitOfWork.Currency.Add(currency);
            await UnitOfWork.SaveChangesAsync();

            return currency;
        }
        public async Task<Currency> EditAsync(CurrencyViewModel model)
        {
            var currency = await UnitOfWork.Currency.GetByIdAsync(model.Id);

            if (currency == null)
                throw new KeyNotFoundException();

            currency.Name = model.Name;
            currency.Code = model.Code;
            currency.Symbol = model.Symbol;
            currency.DecimalPlaces = model.DecimalPlaces;

            UnitOfWork.Currency.Update(currency);
            await AuditLogService.Logger();
            await UnitOfWork.SaveChangesAsync();

            return currency;
        }

        public async Task DeleteAsync(int id)
        {
            var currency = await UnitOfWork.Currency.GetByIdAsync(id);

            if (currency == null)
                throw new KeyNotFoundException();

            UnitOfWork.Currency.Remove(currency);
            await AuditLogService.Logger();
            await UnitOfWork.SaveChangesAsync();
        }

        
    }
}
