using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class HumanTimeFormat{
  public static int returnTime(int time, int unitTime){
    if (time >= unitTime) return time / unitTime;
    else return 0;
  }

  public static string formatDuration(int seconds){
    int time = seconds;
    StringBuilder result = new StringBuilder();
    
    List<string> timeList = new List<string>();
    Dictionary<int, ArrayList> unitTime = new Dictionary<int, ArrayList>();  
    unitTime.Add(1, new ArrayList(){ "year", 365 * 24 * 60 * 60});  
    unitTime.Add(2, new ArrayList(){ "day", 24 * 60 * 60}); 
    unitTime.Add(3, new ArrayList(){ "hour", 60 * 60});
    unitTime.Add(4, new ArrayList(){ "minute", 60 * 1});
    unitTime.Add(5, new ArrayList(){ "second", 1});

    for (int i = 1; i < 6; i++)
    {
        int currentUnit = (int) unitTime[i][1];
        int numTime = returnTime(time, currentUnit);
        time = time - (currentUnit * numTime);
        if (numTime == 1) timeList.Add(numTime.ToString() + " " + unitTime[i][0]);
        else if (numTime > 1) timeList.Add(numTime.ToString() + " " + unitTime[i][0] + "s");
    }

    for (int i = 0; i < timeList.ToArray().Length; i++)
    {
        if (timeList.ToArray().Length == 1) result.Append(timeList[i]);
        else if (i == timeList.ToArray().Length - 2) result.Append(timeList[i] + " ");
        else if (i == timeList.ToArray().Length - 1) result.Append("and " + timeList[i]);
        else result.Append(timeList[i] + ", ");
    }

    if(seconds < 1) return "now";
    return result.ToString();
  }
}

// using NUnit.Framework;
// using System;

// [TestFixture]
// public class Tests {
//   [Test]
//   public void basicTests() {
//     Assert.AreEqual("now",HumanTimeFormat.formatDuration(0));
//     Assert.AreEqual("1 second",HumanTimeFormat.formatDuration(1));
//     Assert.AreEqual("1 minute and 2 seconds",HumanTimeFormat.formatDuration(62));
//     Assert.AreEqual("2 minutes",HumanTimeFormat.formatDuration(120));
//     Assert.AreEqual("1 hour, 1 minute and 2 seconds",HumanTimeFormat.formatDuration(3662));
//     Assert.AreEqual("182 days, 1 hour, 44 minutes and 40 seconds",HumanTimeFormat.formatDuration(15731080));
//     Assert.AreEqual("4 years, 68 days, 3 hours and 4 minutes",HumanTimeFormat.formatDuration(132030240));
//     Assert.AreEqual("6 years, 192 days, 13 hours, 3 minutes and 54 seconds",HumanTimeFormat.formatDuration(205851834));
//     Assert.AreEqual("8 years, 12 days, 13 hours, 41 minutes and 1 second",HumanTimeFormat.formatDuration(253374061));
//     Assert.AreEqual("7 years, 246 days, 15 hours, 32 minutes and 54 seconds",HumanTimeFormat.formatDuration(242062374));
//     Assert.AreEqual("3 years, 85 days, 1 hour, 9 minutes and 26 seconds",HumanTimeFormat.formatDuration(101956166));
//     Assert.AreEqual("1 year, 19 days, 18 hours, 19 minutes and 46 seconds",HumanTimeFormat.formatDuration(33243586));
//   }
// }
