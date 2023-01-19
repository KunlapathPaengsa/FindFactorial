using System.Text.RegularExpressions;


class Calculator7
{
    static void Main7()
    {
        List<string> excludeList = new List<string> { "bike", "boat", "car" };
        List<string> sentense = new List<string> { "I love bikes", "I have boat and car", "I no have truck" };

        //Solution 1
        var result1 = sentense.Select(x => Regex.Replace(x, String.Join("|", excludeList), "")).ToList();

        //Solution 2
        var result2 = sentense.Select(x =>
        {
            excludeList.ForEach(word => x = x.Replace(word, ""));
            return x;
        }).ToList();

        //Solution 3
        var result3 = new List<string>();
        excludeList.ForEach(word => result3.Add(sentense.FirstOrDefault(w => w.Contains(word)).Replace(word, "")));
    }
}