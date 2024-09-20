
string name = "Ajay Bhosle";
name += " AB";

Console.WriteLine(name.ToUpper());

Console.Write(name.MyMethod());

/*public static class StringHelper : string {

    public string MyMethod() {

        return " ";
    }
} */

string name2=stringHepler.MyMethod("Ajay");
Console.WriteLine(name2.ToUpper());

BMW obj2 = new BMW();
obj2.print("Ajay");
public static class stringHepler {

    public static string MyMethod(this string name) {

        //return "Mera Method Hai Bro";
        string Capitalize = "";
        // Ajay  => aJAY
        for (int i= 0; i <name.Length; i++)
        {
            if (i == 0)
            {

                Capitalize += name[i].ToString();
            }
            else {

                Capitalize += name[i];
            }
        }
        return Capitalize;
    }
}




