
using System.Runtime.CompilerServices;

public static class MyExtensions
{
    public static bool IsCoordExistInList(this List<List<int>> list, int x, int y)
    {
        return list.Any(item => item[0]==x && item[1]==y);
    }

    public static List<List<int>> ReMoveSubList(this List<List<int>> list, List<List<int>> subList)
    {
        var temp = list;
        foreach(List<int> item in subList)
        {
            temp.RemoveAll(ele => ele[0]==item[0] && ele[1]==item[1]);
        }
        return temp;
    }

    public static void CoordsPrint(this List<List<int>> list)
    {
        foreach (List<int> item in list)
        {
            Console.Write("{0},{1}; ", item[0], item[1]);
        }
    }
}