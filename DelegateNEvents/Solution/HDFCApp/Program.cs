using Banking;
using NotificationS;
using NotificationO;
using TaxO;
using TaxS;

// Account acc = new Account();

// acc.withdraw(5000);

// acc.deposit(10000);


// NotificationService not = new NotificationService();

// not.SendEmail("Hrishinikam1729@gmail.com", "You are king!!");


// NotificationOperation NotEmail = new NotificationOperation(NotificationService.SendEmail);
// NotificationOperation NotSMS = new NotificationOperation(NotificationService.SendSMS);
// NotificationOperation NotWappMess = new NotificationOperation(NotificationService.SendWhatsappMessage);

// NotificationOperation NotOp = null;
// NotOp += NotEmail;
// NotOp += NotSMS;
// NotOp += NotWappMess;

// IAsyncResult iresult = NotOp.BeginInvoke("Hrishinikam1729@gmail.com", "You are great!!", null, null);
// NotOp.EndInvoke(iresult);


// TaxOperation TaxO = new TaxOperation(TaxService.PaySalesTax);
// TaxO(5000.70f);



Account acc = new Account();
// Console.WriteLine(acc.balance);

acc.underBalance += NotificationService.SendEmail;
acc.underBalance += NotificationService.SendWhatsappMessage;
acc.underBalance += NotificationService.SendSMS;

acc.overBalance += TaxService.PayIncomeTax;
acc.overBalance += TaxService.PayServiceTax;

Console.WriteLine(acc.balance);

acc.deposit(60000);
acc.withdraw(55000);

acc.deposit(200000);


Console.WriteLine(acc.balance);



















