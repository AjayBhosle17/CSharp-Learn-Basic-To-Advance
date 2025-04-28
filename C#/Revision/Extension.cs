namespace Revision
{
    public static class Extension
    {
        public static string CheckAgeVote(this int age)
        {

            if (age >= 18)
            {
                return $"Voting kr skta hai {age}";
            }
            else
            {
                return $"Bhai tu abhi Baccha hai {age}";
            
            
            }
        }

      static  List<string> data = new List<string>() { "Ajay","Bhosle"};
      


     public   static void fun()
        {
            foreach (var item in data)
            {
                data.Add(item);
                Console.WriteLine(item);
            }

        }
        

    }
}
