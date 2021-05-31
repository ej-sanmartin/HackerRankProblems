using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'alternatingCharacters' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int alternatingCharacters(string s){
      int deletions = 0;
      int current = 0;

      for(int i = current + 1; i <= s.Length - 1; i++){
          char currentChar = Char.ToUpper(s[i]);
          char prevChar = Char.ToUpper(s[i -1 ]);
          if(currentChar != 'A' && currentChar != 'B') return int.MinValue;
          if(currentChar == prevChar) deletions++;
      }

      return deletions;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = Result.alternatingCharacters(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}


/*
  T - O(n)
  S - O(1)
  
  Includes rough memo solution
*/

int alternatingCharacters(string s, Dictionary<string s, int output> memo){
  // if(memo.contains(s)) return memo.get(s);
  
  int deletions = 0;
  int current = 0;
  
  for(int i = current + 1; i <= s.Length() - 1; i++){
    char currentChar = Char.ToUpper(s[i]);
    char prevChar = Char.ToUpper(s[i - 1]);
    if(currentChar != 'A' && currentChar != 'B') return int.MinValue;
    if(currentChar == prevChar) deletions++;
  }
  
  // memo.add(s, deletions);
  
  return deletions;
}
