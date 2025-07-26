using System;
namespace TransactionMonitoring.Application.DTO
{
	public class RuleConditionDto
	{
        public string Field { get; set; }        
        public string Operator { get; set; } 
        public string Value { get; set; }
    }
}

