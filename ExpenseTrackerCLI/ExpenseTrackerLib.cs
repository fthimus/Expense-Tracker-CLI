using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExpenseTrackerCLI
{
    internal class ExpenseTrackerLib
    {
        const string FILE_PATH = "expenses.json";
        internal static void ProcessArguments(string[] args)
        {
            InitializeJsonFile();
            if (args.Length < 1)
            {
                ShowUsage();
                return;
            }
            switch (args[0].ToUpper())
            {
                //case ADD:
                //    AddTask(args);
                //    break;
                //case LIST:
                //    ListTask(args);
                //    break;
                //case UPDATE:
                //    UpdateTask(args);
                //    break;
                //case DELETE:
                //    DeleteTask(args);
                //    break;
                //case MARK_IN_PROGRESS:
                //    MarkTask(args, STATUS_IN_PROGRESS);
                //    break;
                //case MARK_DONE:
                //    MarkTask(args, STATUS_DONE);
                //    break;
                default:
                    ShowUsage();
                    break;
            }
        }

        internal static void InitializeJsonFile()
        {
            if (!File.Exists(FILE_PATH))
                File.WriteAllText(FILE_PATH, JsonSerializer.Serialize(new List<ExpenseData>()));
        }

        internal static void ShowUsage()
        {
            //string alignmentComponent = "{0,-50} {1,5}";
            Console.WriteLine("Usage:");
            //Console.WriteLine(alignmentComponent, "task-cli add <task description>", "Adding a new task");
            //Console.WriteLine(alignmentComponent, "task-cli update <task id> <task description>", "Updating a task");
            //Console.WriteLine(alignmentComponent, "task-cli delete <task id>", "Deleting a task");
            //Console.WriteLine(alignmentComponent, "task-cli mark-in-progress <task id>", "Marking a task as in progress");
            //Console.WriteLine(alignmentComponent, "task-cli mark-done <task id>", "Marking a task as done");
            //Console.WriteLine(alignmentComponent, "task-cli list", "Listing all tasks");
            //Console.WriteLine(alignmentComponent, "task-cli list done <task description>", "Listing done tasks");
            //Console.WriteLine(alignmentComponent, "task-cli list todo <task description>", "Listing todo tasks");
            //Console.WriteLine(alignmentComponent, "task-cli list in-progress <task description>", "Listing in progress tasks");
        }

        static void AddExpense()
        {

        }

        static void UpdateExpense()
        {

        }

        static void DeleteExpense()
        {

        }

        static void ViewAllExpenses()
        {

        }

        static void ViewSummaryAllExpenses()
        {

        }

        static void ViewSummaryAllExpenses(int month)
        {

        }
    }
}
