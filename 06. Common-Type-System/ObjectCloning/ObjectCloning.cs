using System;

class ObjectCloning
{
    public static void Go()
    {
        LinkedList<string> initialList =
                                        new LinkedList<string>("Old fellow Vlado",
                                        new LinkedList<string>("Granny Yaga",
                                        new LinkedList<string>("Bai Ivan")));

        LinkedList<string> deeplyClonedList = initialList.Clone();
        deeplyClonedList.Value = "first changed";
        deeplyClonedList.NextNode.Value = "second changed";

        Console.WriteLine("initial list = {0}", initialList);
        Console.WriteLine("deeply cloned list = {0}", deeplyClonedList);

        initialList =
                     new LinkedList<string>("Old fellow Vlado",
                     new LinkedList<string>("Granny Yaga",
                     new LinkedList<string>("Bai Ivan")));

        LinkedList<string> shallowCopy = initialList.ShallowCopy();
        shallowCopy.Value = "first changed";
        shallowCopy.NextNode.Value = "second changed";

        Console.WriteLine("initial list = {0}", initialList);
        Console.WriteLine("deeply cloned list = {0}", shallowCopy);

        Console.WriteLine();
        initialList =
                     new LinkedList<string>("Old fellow Vlado",
                     new LinkedList<string>("Granny Yaga",
                     new LinkedList<string>("Bai Ivan")));
        LinkedList<string> memberwiseCopy = initialList.MemberwiseCopy();
        memberwiseCopy.Value = "1st changed";
        memberwiseCopy.NextNode.Value = "2nd changed";

        Console.WriteLine("initial list = {0}", initialList);
        Console.WriteLine("memberwise cloned list = {0}", memberwiseCopy);






    }
}