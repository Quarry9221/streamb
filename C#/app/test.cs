// using System;

// public class CPHInline
// {
//     public bool Execute()
//     {
//         int newpoints;
//         var buff = new Random();
//         int rnd = buff.Next(1,2);
//         // split up the arguments into user and points
//         string inputraw = args["rawInput"].ToString();
//         char[] charSeparators = new char[]{' '};
//         string[] inputargs = inputraw.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
//         //Remove the @ if specified before user
//         string user = inputargs[0].ToString();
//         //Check if we want to add points to all - if so just add to global and let the timed event pick up on this. We return false so we do not continue execution.

//         if (user.Substring(0, 1) == "@")
//         {
		
//             user = user.Remove(0, 1);
			
		
//         }

//         //Get current points
//         int currentpoints = CPH.GetUserVar<int>(user, "points", true);
//         //Test to see if we have a valid argument here to add.

//         if (rnd == 1)
//         {
//             int pointstoadd = buff.Next()
//         }
//         if (int.TryParse(inputargs[1], out newpoints))
//         {
            
//             //Add the points and set it as an argument and set to user.
//             newpoints += currentpoints;
//             if (newpoints < 0)
//             {
//                 newpoints = 0;
//             }

//             CPH.SetUserVar(user, "points", newpoints, true);
//             //Set arguments for message
//             CPH.SetArgument("points", newpoints);
//             CPH.SetArgument("pointstarget", user);
//             return true;
//         }
//         else
//         {
//             CPH.SendMessage("No valid amount selected");
//             return false;
//         }
//     }
// }