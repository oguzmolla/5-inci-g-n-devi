using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * burada ilk önce her kredinin ayrı ayrı hesapla methodunu çağırdık
             * sonra basvuru yap diye bir manager açtık onun içine ortak olan interface ten
             * türeyen nesne isteyerek hepsi kendi hesaplamarına gitmeyi sağladık
             * bu dependency injection dır
             */
            //ICreditManager mortgageCredit = new MortgageCreditManager();
            //mortgageCredit.Calculate();

            //ICreditManager vehicleCredit = new VehicleCreditManager();
            //vehicleCredit.Calculate();

            //ICreditManager personelCredit = new PersonelCreditManager();
            //personelCredit.Calculate();

            ICreditManager mortgageCredit = new MortgageCreditManager();

            ICreditManager vehicleCredit = new VehicleCreditManager();

            ICreditManager personelCredit = new PersonelCreditManager();

            ApplyManager applyManager = new ApplyManager();
            //applyManager.Apply(personelCredit);

            /*
             * Burada ise listeden gelenlerin kredierini hesaplattık
             */
            List<ICreditManager> credits = new List<ICreditManager>()
            {
                personelCredit,
                vehicleCredit,
                mortgageCredit
            };

            applyManager.DoCreditInformation(credits);

            //Log kısmı
            ILoggerService dbloggerService = new DbLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();

            List<ILoggerService> loggerServices = new List<ILoggerService>()
            {
                dbloggerService,
                fileloggerService
            };

            //applyManager.Apply(personelCredit, loggerServices);

        }
    }
}
