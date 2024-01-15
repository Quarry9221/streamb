
// using System;
// using System.Collections.Generic;
// int Registration (User user)
// {
//     var random = new Random ();
//     var res = random.Next(1, 100);
//     if (user.sizeOfCarrot > 0 )
//     {
//         Console.WriteLine("Ви вже зареєструвались");
//     }
//     else
//     {
//          Console.WriteLine("Ви пройшли реєстрацію! - {0} ", res);
//          user.sizeOfCarrot = res;
//          user.isRegistered = true;
//     }
//     return res;
// }

// void ChangeSize (User user)
// {
//     var buff = new Random();
//     var rndSize = buff.Next(1,10);
//     var rndflag = buff.Next(1,2);
//     if(user.sizeOfCarrot > 0)
//     {
//         if (rndflag == 1)
//         {
            
//             user.sizeOfCarrot -= rndSize;
//             Console.WriteLine("Сьогодні ви пішли в мінус на {0}, ваша морквина тепер: {1}", rndSize, user.sizeOfCarrot);
//         }
//         else
//         {
//             user.sizeOfCarrot += rndSize;
//             Console.WriteLine("Сьогодні ви пішли в плюс на {0}, ваша морквина тепер: {1}", rndSize, user.sizeOfCarrot);
//         }
//     }
//     else
//     {
//         Console.WriteLine("Ви не зареєструвались");
//     }
// }


// public class CPHInline
// {
//     public bool Execute()
//     {
//         // points to add - update here if you want more than 1 point added every 5 minutes
        
//         var buff = new Random();
//         int rnd = buff.Next(1,2);
//         // import the present viewers list
//         var users = (List<Dictionary<string, object>>)args["users"];
//         //Only give points if you are live!
//         // - this time for testing instead if (args["isLive"].ToString() == "False")
//         if (args["isLive"].ToString() == "True")
//         {
//             int points, pointsout;
//             string currentuser;
//             int globaladd = CPH.GetGlobalVar<int>("globalpointsadd", true);
//             // Go through each viewer and process points addition.
//             for (int i = 0; i < users.Count; i++)
//             {
//                 int pointstoadd = buff.Next(1,10);
//                 if (rnd == 1)
//                 {
//                     currentuser = users[i]["userName"].ToString();
//                     points = CPH.GetUserVar<int>(currentuser, "points", true);
//                     points = points - pointstoadd;
//                     //Add any global adds too
//                     points = points - globaladd;
//                     CPH.SetUserVar(currentuser, "points", points, true);
//                 }
//                 else
//                 {
//                     currentuser = users[i]["userName"].ToString();
//                     points = CPH.GetUserVar<int>(currentuser, "points", true);
//                     points = points + pointstoadd;
//                     //Add any global adds too
//                     points = points + globaladd;
//                     CPH.SetUserVar(currentuser, "points", points, true);
//                 }
//                 // Read in current points and add 1

//             }

//             //report that global add has worked and set global back to 0
//             if (globaladd > 0)
//             {
// 				var pointsname = CPH.GetGlobalVar<string>("pointsname", true);
//                 CPH.SendMessage("Added " + globaladd.ToString() + " "+pointsname+" to all users here");
// 				CPH.SetGlobalVar("globalpointsadd",0, true);
//             }
//         }

//         return true;
//     }
// }
//         string inputraw = "quarryck 100";
//         char[] charSeparators = new char[]{' '};
//         string[] inputargs = inputraw.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
//         //Remove the @ if specified before user
//         string user = inputargs[0].ToString();

//         Console.WriteLine(user);


var buff = new Random();

for (int i = 0; i < 20; i++)
{
    var res = buff.Next(-10, 10);
    Console.WriteLine(res);
}