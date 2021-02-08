using System;
using System.Collections.Generic;  

namespace solutions
{
    class solution205 {
        
        static public int[] Encrypt(string Message) {
            if(Message.Length == 0)
                return new int[] {};

            List<int> charcodes = new List<int>();
            int prevcharcode = Message[0];
            charcodes.Add(prevcharcode);
            foreach (char ch in Message[1..]){
                int charcode = (int)ch;
                int encryptedcharcode = charcode-prevcharcode;
                charcodes.Add(encryptedcharcode);
                prevcharcode = charcode;
            }
                
            return charcodes.ToArray();
        }

        static public string Decrypt(int[] EncryptedMessage)
        {
            if(EncryptedMessage.Length == 0)
                return "";

            string decrypted_message = "";
            int prevEncryptedChar = EncryptedMessage[0];
            decrypted_message = string.Concat(decrypted_message, (char)prevEncryptedChar);
            foreach(int encryptedChar in EncryptedMessage[1..]){
                int decryptedcharcode = encryptedChar+prevEncryptedChar; 
                char descryptedchar = (char)decryptedcharcode;
                decrypted_message = string.Concat(decrypted_message, descryptedchar);
                prevEncryptedChar = decryptedcharcode; 
            }
            return decrypted_message;
        }
    }
    
}