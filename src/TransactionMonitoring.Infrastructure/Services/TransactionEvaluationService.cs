using System;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Application.Interface;
using TransactionMonitoring.Application.Interface.Services;
using TransactionMonitoring.Domain.Enums;
using TransactionMonitoring.Domain.Helper;

namespace TransactionMonitoring.Infrastructure.Services
{
	public class TransactionEvaluationService : ITransactionEvaluationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAlertService _alertService;
        public TransactionEvaluationService(IUnitOfWork unitOfWork, IAlertService alertService)
		{
            _unitOfWork = unitOfWork;
            _alertService = alertService;
		}

        public Task EvaluateTransactionBatchAsync(IEnumerable<TransactionDTO> transactions)
        {
            throw new NotImplementedException();
        }

        public async Task<AlertFlag> EvaluateTransactionRealTimeAsync(TransactionDTO tx)
        {
            var rules = await _unitOfWork.Rules.GetByProductIdAsync(tx.ProductId, tx.CustomerId);
            if (!rules.Any())
            {
                return AlertFlag.NoRules;
            }
            foreach (var rule in rules)
            {
                var context = new Dictionary<string, object>
                {
                    ["Amount"] = tx.Amount,
                    ["Country"] = tx.Country,
                    ["IsPEP"] = tx.IsPEP,
                    ["IsSanctioned"] = tx.IsSanctioned
                };

                if (EvaluatorHelper.NCalcEvaluator(rule.Expression, context))
                {
                    _alertService.RaiseAlert(rule, tx);
                }
            }
        }
    }
}

