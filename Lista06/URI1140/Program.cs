using System;

namespace URI1140
{
    class Program
    {
        static void Main(string[] args)
        
        { 
          string s;
          do{
          s = Console.ReadLine().ToLower();
          
          char ini = s[0];
           int pomba = 0;
          
            for (int i = 0;i < s.Length; i++)
              {
                if (s=="*") break;
                else if (s[i] == ' '){
                char c = s[i+1];
                  if (c ==ini) {pomba++;}
                  else {pomba--; break;}
                }
              }

           if(pomba < 0) Console.WriteLine("N");
           else if (pomba > 0)Console.WriteLine("Y");
          }
          while(s != "*");
          
          }
    }
}
