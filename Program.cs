namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Permutations!");
            perm("abc");
            //string tesmp = getRest('b', "abc");
        }


        public static void perm(string s) {
            foreach(char c in s){
                string currStr = getRest(c, s);
                foreach(char ch in currStr){
                    string res = c.ToString() + ch.ToString() + getRest(ch, currStr);
                    Console.WriteLine(res);
                }                
            }
        }

        public static string getRest(char c, string s) {
            string res = "";
            foreach(char ch in s){
                if(c != ch) {
                    res += ch;
                }
            }
            return res;
        }
    }
}