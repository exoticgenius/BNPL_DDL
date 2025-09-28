
class _2_LoanRequest
{
    public string RequestorName { get; set; }
    public string RequestorFamily { get; set; }
    public string RequestorNationalCode { get; set; }
    public string RequestorPhoneNumber { get; set; }

    public string ServiceName { get; set; }
    public _2_ServiceType ServiceType { get; set; }
    public _2_LoanRequestStage Stage { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public _2_BajetInquiry BajetInquiry { get; set; }
    public _2_ShahkarInquiry ShahkarInquiry { get; set; }
    public List<_2_LoanRequestFile> Files { get; set; }
    public List<_2_PaymentLink> PaymentLinks { get; set; }

    public decimal TotalAmount { get; set; }
    public decimal BaseAmount { get; set; }
    public decimal ServiceFee { get; set; }
    public decimal SettlementAmount { get; set; }
    public decimal SubscriptionAmount { get; set; }
}

class _2_File
{
    public string FileName { get; set; }
    public string Extension { get; set; }
    public long Length { get; set; }
}

class _2_LoanRequestFile
{
    public _2_LoanRequest LoanRequest { get; set; }
    public _2_File File { get; set; }
}

class _2_BajetInquiry
{
    public string NationalCode { get; set; }
    public decimal Amount { get; set; }

    public bool Succeeded { get; set; }
}

class _2_ShahkarInquiry
{
    public string NationalCode { get; set; }
    public string PhoneNumber { get; set; }

    public bool Succeeded { get; set; }
}

class _2_PaymentLink
{
    public _2_LoanRequest LoanRequest { get; set; }
    public Guid LinkToken { get; set; }
    public DateTime CreatedAt { get; set; }
}

class _2_Payment
{
    public _2_LoanRequest LoanRequest { get; set; }
    public decimal Amount { get; set; }
}

class _2_SettlementRequest
{
    public _2_LoanRequest LoanRequest { get; set; }
    public List<_2_SettlementRequest> Files { get; set; }
    public List<_2_SettlementRequestLog> Logs { get; set; }
    public DateTime CreatedAt { get; set; }
    public _2_SettlementStage Stage { get; set; }
}

class _2_SettlementRequestLog
{
    public _2_SettlementRequest SettlementRequest { get; set; }
    public string Comment { get; set; }
    public bool Approved { get; set; }
}

class _2_SettlementRequestFile
{
    public _2_SettlementRequest SettlementRequest { get; set; }
    public _2_File File { get; set; }
}

enum _2_LoanRequestStage
{

}

enum _2_ServiceType
{
    Flight,
    Hotel,
    Tour,
    Bus,
}


enum _2_SettlementStage
{
    Pending,
    Approved,
    Rejected,
}