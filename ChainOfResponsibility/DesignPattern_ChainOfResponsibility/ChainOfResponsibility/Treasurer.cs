using DesignPattern_ChainOfResponsibility.DAL;
using DesignPattern_ChainOfResponsibility.Models;

namespace DesignPattern_ChainOfResponsibility.ChainOfResponsibility
{
  public class Treasurer : Employee
  {
    public override void ProcessRequest(CustomerProcessViewModel request)
    {
      Context context = new Context();
      if (request.Amount <= 100000)
      {
        CustomerProcess customerProcess = new CustomerProcess();
        customerProcess.Amount = request.Amount.ToString();
        customerProcess.Name = request.Name;
        customerProcess.EmployeeName = "Veznedar - Ayşe Çınar";
        customerProcess.Description = "Para Çekme İşlemi Onaylandı,Müşteriye Talep ettiği Tutar Ödendi";
        context.customerProcesses.Add(customerProcess);
        context.SaveChanges();
      }
      else if(NextApprover != null)
      {
        CustomerProcess customerProcess = new CustomerProcess();
        customerProcess.Amount = request.Amount.ToString();
        customerProcess.Name = request.Name;
        customerProcess.EmployeeName = "Veznedar - Ayşe Çınar";
        customerProcess.Description = "Para Çekme Tutarı Veznedarın Günlük Ödeyebileceği limiti aştığı için İşlem şube müdür yardımcısına yönlendirildi";

        context.customerProcesses.Add(customerProcess);
        context.SaveChanges();
        NextApprover.ProcessRequest(request);
      }
    }
  }
}
