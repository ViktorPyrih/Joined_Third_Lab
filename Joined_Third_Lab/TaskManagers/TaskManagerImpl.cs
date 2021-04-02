using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joined_Third_Lab
{
    public class TaskManagerImpl : TaskManager
    {
        private Services.ViktorService service = new Services.ViktorService();
        public void doTask1_1()
        {
            service.processTask1();
        }

        public void doTask1_2()
        {
            service.processTask2();
        }

        private Services.NickService service2 = new Services.NickService();
        public void doTask2_1()
        {
            service2.processTask1();
        }

        public void doTask2_2()
        {
            service2.processTask2();
        }

        private Services.MaksymService service1 = new Services.MaksymService();
        public void doTask3_1()
        {
            service1.processTask1();
        }

        public void doTask3_2()
        {
            service1.processTask2();
        }
    }
}
