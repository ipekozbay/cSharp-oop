using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditManager requirementCreditManager = new RequirementCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();   
            ICreditManager housingCreditManager = new HousingCreditManager();

            ILoggerService databaseLogerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService(); 

            AppealManager appealManager = new AppealManager();
            appealManager.ToApply(requirementCreditManager ,databaseLogerService);

            List<ICreditManager> credits = new List<ICreditManager>() {requirementCreditManager };
            //appealManager.CredictPreInformation(credits);


        }
    }
}