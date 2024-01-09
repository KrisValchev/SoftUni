using _08.CollectionHierarchy.Interfaces;
using _08.CollectionHierarchy.Models;

namespace _08.CollectionHierarchy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> addCollections = new Dictionary<string, List<int>>
            {
                {"AddCollection",new List<int>()},
                { "RemoveCollection",new List<int>()},
                { "MyList",new List<int>()}
            };
            Dictionary<string, List<string>> removeCollections = new Dictionary<string, List<string>>
            {
                { "RemoveCollection",new List<string>()},
                { "MyList",new List<string>()}
            };
            List<string> list = new List<string>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));
            IAddable addCollection = new AddCollection();
            IRemovable removeAddCollection = new AddRemoveCollection();
            IMyList myList = new MyList();
            int removeOperators = int.Parse(Console.ReadLine());
            foreach (var element in list)
            {
                addCollections["AddCollection"].Add(addCollection.Add(element));
                addCollections["RemoveCollection"].Add(removeAddCollection.Add(element));
                addCollections["MyList"].Add(myList.Add(element));
            }
            for (int i = 0; i < removeOperators; i++)
            {
                removeCollections["RemoveCollection"].Add(removeAddCollection.Remove());
                removeCollections["MyList"].Add(myList.Remove());
            }
            Console.WriteLine(string.Join(' ', addCollections["AddCollection"]));
            Console.WriteLine(string.Join(' ', addCollections["RemoveCollection"]));
            Console.WriteLine(string.Join(' ', addCollections["MyList"]));
            Console.WriteLine(string.Join(' ', removeCollections["RemoveCollection"]));
            Console.WriteLine(string.Join(' ', removeCollections["MyList"]));
        }
    }
}