using DesignPattern_ChainOfResponsibility.DAL;
using DesignPattern_ChainOfResponsibility.Models;

namespace DesignPattern_ChainOfResponsibility.ChainOfResponsibility
{
  public class AreaDirector : Employee
  {
    public override void ProcessRequest(CustomerProcessViewModel request)
    {
      Context context = new Context();
      if (request.Amount <= 400000)
      {
        CustomerProcess customerProcess = new CustomerProcess();
        customerProcess.Amount = request.Amount.ToString();
        customerProcess.Name = request.Name;
        customerProcess.EmployeeName = "Bölge Direktörü  - Bilge Sarı";
        customerProcess.Description = "Para Çekme İşlemi Onaylandı,Müşteriye Talep ettiği Tutar Ödendi";
        context.customerProcesses.Add(customerProcess);
        context.SaveChanges();
      }
      else
      {
        CustomerProcess customerProcess = new CustomerProcess();
        customerProcess.Amount = request.Amount.ToString();
        customerProcess.Name = request.Name;
        customerProcess.EmployeeName = "Bölge Direktörü  - Bilge Sarı";
        customerProcess.Description = "Para Çekme Tutarı Bölge Direktörünün  Günlük Ödeyebileceği limiti aştığı için İşlem gerçekleştirilemedi. Müşterinin günlük çekebileceği tutar 400.000₺ olup daha fazlası için birden fazla gün şubeye gelmesi gerekmektedir.";

        context.customerProcesses.Add(customerProcess);
        context.SaveChanges(); 
      }
    }
  }
}

