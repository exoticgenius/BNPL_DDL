Console.ReadLine();
class LoanRequest
{
    public string RequestorName { get; set; }
    public string RequestorFamily { get; set; }
    public string RequestorNationalCode { get; set; }
    public string RequestorPhoneNumber { get; set; }

    public string ServiceName { get; set; }
    public ServiceType ServiceType { get; set; }
    public LoanRequestStage Stage { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public Invoice Invoice { get; set; }
    public BajetInquiry BajetInquiry { get; set; }
    public ShahkarInquiry ShahkarInquiry { get; set; }
    public List<LoanRequestFile> Files { get; set; }
    public List<PaymentLink> PaymentLinks { get; set; }
}

class Invoice
{
    public decimal TotalAmount { get; set; }
    public List<InvoiceItem> Items { get; set; }
    public LoanRequest LoanRequest { get; set; }
}

class InvoiceItem
{
    public Invoice Invoice { get; set; }
    public InvoiceItemType ItemType { get; set; }
    public decimal Amount { get; set; }
}

class File
{
    public string FileName { get; set; }
    public string Extension { get; set; }
    public long Length { get; set; }
}

class LoanRequestFile
{
    public LoanRequest LoanRequest { get; set; }
    public File File { get; set; }
}

class BajetInquiry
{
    public string NationalCode { get; set; }
    public decimal Amount { get; set; }

    public bool Succeeded { get; set; }
}

class ShahkarInquiry
{
    public string NationalCode { get; set; }
    public string PhoneNumber { get; set; }

    public bool Succeeded { get; set; }
}

class PaymentLink
{
    public LoanRequest LoanRequest { get; set; }
    public Guid LinkToken { get; set; }
    public DateTime CreatedAt { get; set; }
}

class IPG
{
    public IPGType IPGType { get; set; }
    public string Name { get; set; }
    public string PrivateSettings { get; set; }
}

class Payment
{
    public decimal TotalAmount { get; set; }
    public bool Effective { get; set; }
    public IPG IPG { get; set; }

    public Invoice Invoice { get; set; }
    public List<PaymentItem> PaymentItems { get; set; }
}

class PaymentItem
{
    public Payment Payment { get; set; }
    public InvoiceItem InvoiceItem { get; set; }
    public decimal Amount { get; set; }
    public bool Effective { get; set; }
}

class SettlementRequest
{
    public List<Invoice> Invoices { get; set; }
    public List<SettlementRequest> Files { get; set; }
    public List<SettlementRequestLog> Logs { get; set; }
    public DateTime CreatedAt { get; set; }
    public SettlementStage Stage { get; set; }
}

class SettlementRequestLog
{
    public SettlementRequest SettlementRequest { get; set; }
    public string Comment { get; set; }
    public bool Approved { get; set; }
}

class SettlementRequestFile
{
    public SettlementRequest SettlementRequest { get; set; }
    public File File { get; set; }
}

class BajetPaymentReference
{
    public InvoiceItem InvoiceItem { get; set; }
    public decimal Amount { get; set; }
    public DateTime CreatedAt { get; set; }
    public string ReferenceNumber { get; set; }
    public bool PaymentValidated { get; set; }
}

enum LoanRequestStage
{

}

enum InvoiceItemType
{
    BaseAmount,
    ServiceFee,
    SettlementAmount,
    SubscriptionAmount,
}
enum ServiceType
{
    Flight,
    Hotel,
    Tour,
    Bus,
}

enum IPGType
{
    Internal,
    Bajet,
    Sep,
    Tara,
}

enum SettlementStage
{
    Pending,
    Approved,
    Rejected,
}