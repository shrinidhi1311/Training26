public class Solution {
   public bool IsValid (string s) {
      Stack<char> stack = new Stack<char> ();
      Dictionary<char, char> bpair = new Dictionary<char, char> () {
            {')', '('},
            {']', '['},
            {'}', '{'}
        };

      foreach (char c in s) {
         if (bpair.ContainsKey (c)) {
            if (stack.Count == 0 || stack.Peek () != bpair[c]) {
               return false;
            }
            stack.Pop ();
         } else {
            stack.Push (c);
         }
      }

      return stack.Count == 0;
   }
}