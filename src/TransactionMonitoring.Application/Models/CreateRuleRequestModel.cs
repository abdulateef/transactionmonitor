
using System;
using TransactionMonitoring.Application.DTO;

namespace TransactionMonitoring.Application.Models
{
	public class CreateRuleRequestModel
	{
        public string Description { get; set; }
        public string Name { get; set; }
        public Guid? CustomerId { get; set; } 
        public Guid? ProductId { get; set; }
        public string LogicalOperator { get; set; } = "AND"; 
        public List<RuleConditionDto> Conditions { get; set; } = new();
    }
}

