using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joined_Third_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Adapter.StudentInfoAdapter adapter = new Adapter.StudentInfoAdapter();
            adapter.subtractStudentInfoList();
            Input input = new Input();
            bool flag = false;
        Label1:
            if (flag)
            {
                Console.WriteLine("If you wanna crear the console area print yes," +
                    " otherwise -- another phrase:");
                if (Console.ReadLine().ToUpper().Equals("YES"))
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("----------------------------------------");
                }
            }
            Console.WriteLine("Choose the task(1..2) or exit option('EXIT'):");
            TaskEnum task = input.setTask();
            TaskManager manager = new TaskManagerImpl();
            switch (task)
            {
                case TaskEnum.TASK_1:
                    flag = true;
                    Console.WriteLine("Choose the developer's name for TASK_1\n" +
                        "VIKTOR\n" +
                        "MYKYTA\n" +
                        "MAKSYM\n" +
                        " return option('RETURN')\n or exit option('EXIT'):");
                    NameEnum name = input.setName();
                    switch (name)
                    {
                        case NameEnum.VIKTOR:
                            manager.doTask1_1();
                            break;
                        case NameEnum.MYKYTA:
                            manager.doTask2_1();
                            break;
                        case NameEnum.MAKSYM:
                            manager.doTask3_1();
                            break;
                        case NameEnum.EXIT:
                            goto Label2;
                        default:
                            goto Label1;
                    }
                    goto Label1;
                case TaskEnum.TASK_2:
                    flag = true;
                    Console.WriteLine("Choose the developer's name for TASK_2\n" +
                        "VIKTOR\n" +
                        "MYKYTA\n" +
                        "MAKSYM\n" +
                        " return option('RETURN')\n or exit option('EXIT'):");
                    name = input.setName();
                    switch (name)
                    {
                        case NameEnum.VIKTOR:
                            manager.doTask1_2();
                            break;
                        case NameEnum.MYKYTA:
                            manager.doTask2_2();
                            break;
                        case NameEnum.MAKSYM:
                            manager.doTask3_2();
                            break;
                        case NameEnum.EXIT:
                            goto Label2;
                        default:
                            goto Label1;
                    }
                    goto Label1;
            }
        Label2:
            MessageBox.Show("Process has finished!");
            Console.ReadKey();
        }
    }
}
