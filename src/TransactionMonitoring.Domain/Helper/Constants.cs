using System;
namespace TransactionMonitoring.Domain.Helper
{
	public static class Constants
	{
    }

    public static class FieldTypes
    {
        public const string Numeric = "Numeric";
        public const string Boolean = "Boolean";
        public const string String = "String";
        public const string DateTime = "DateTime";
        public const string Enum = "Enum";
    }

    public static class CustomerTiers
    {
        public const string Bronze = "Bronze";
        public const string Silver = "Silver";
        public const string Gold = "Gold";
        public const string Platinum = "Platinum";

        public static readonly string[] All = { Bronze, Silver, Gold, Platinum };
    }
    public static class CustomerSegments
    {
        public const string Retail = "Retail";
        public const string SME = "SME";
        public const string Corporate = "Corporate";
        public const string Fintech = "Fintech";
        public const string AgentBanking = "AgentBanking";

        public static readonly string[] All = { Retail, SME, Corporate, Fintech, AgentBanking };
    }

    public static class CustomerRiskLevels
    {
        public const string Low = "Low";
        public const string Medium = "Medium";
        public const string High = "High";

        public static readonly string[] All = { Low, Medium, High };
    }

    public static class ProductBusinessTypes
    {
        public const string PSSP = "PSSP";                   // Payment Service Solution Provider
        public const string MMO = "MMO";                     // Mobile Money Operator
        public const string CollectionAgency = "CollectionAgency";
        public const string Bank = "Bank";
        public const string Switch = "Switch";
        public const string SuperAgent = "SuperAgent";
        public const string MFB = "MFB";                     // Microfinance Bank
        public const string InternationalMoneyTransfer = "IMTO";

        public static readonly string[] All =
        {
        PSSP, MMO, CollectionAgency, Bank, Switch, SuperAgent, MFB, InternationalMoneyTransfer
    };


    }

}

