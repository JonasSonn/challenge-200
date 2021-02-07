
namespace solutions
{
    class solution201 {
        static public string 
        Maskify(string number){
            int unmaskedlength = 4;
            int length = number.Length;
            if(length > unmaskedlength){
                int substring_start = length-unmaskedlength;
                string substring = number.Substring(substring_start, unmaskedlength);
                number = substring.PadLeft(length, 'X');
            }
          
            return number;
        }
    }
}