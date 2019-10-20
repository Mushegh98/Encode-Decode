using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Based_Method
{
    static class Myclass
    {
        
        public static string Encoding(string text)
        {
            string ReturnedText = "";
            string EncodeText = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmopqrstuvwxyz";
              string SwapText = "0123456789abcdefghijklmopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for(int i=0;i<text.Length;i++)
            {
                int index = EncodeText.IndexOf(text[i]);
                if(index==-1)
                {
                    ReturnedText += text[i];
                }

                else
                {
                    ReturnedText += SwapText[index];
                }
            }
            return ReturnedText;
        }
        public static string Decoding(string text)
        {
            string ReturnedText = "";
              string SwapText = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmopqrstuvwxyz";
            string DecodeText = "0123456789abcdefghijklmopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < text.Length; i++)
            {
                int index = DecodeText.IndexOf(text[i]);
                if (index == -1)
                {
                    ReturnedText += text[i];
                }

                else
                {
                    ReturnedText += SwapText[index];
                }
            }
            return ReturnedText;
        }

    }
}
