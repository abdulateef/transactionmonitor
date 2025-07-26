using System;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Application.Models;

namespace TransactionMonitoring.Application.Interface.Services
{
	public interface IRuleEngineService
	{
        Task<RuleDto> CreateAsync(CreateRuleRequestModel request);
    }
}

