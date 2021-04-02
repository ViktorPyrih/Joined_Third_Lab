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

        public void doTask2_1()
        {
            throw new NotImplementedException();
        }

        public void doTask2_2()
        {
            throw new NotImplementedException();
        }

        private Services.MaksymService service1 = new Services.MaksymService();
        public void doTask3_1()
        {
            service1.processTask1();
        }

        public void doTask_3_2()
        {
            service1.processTask2();
        }
    }
}
