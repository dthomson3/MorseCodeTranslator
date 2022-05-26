using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeTranslator;
public static class MorseCodeDictionary
{
    public static Dictionary<string, char> dictionary = new()
    {
        {".-", 'a' },
        {"-...", 'b' },
        {"-.-.", 'c'},
        {"-..",'d'},
        {"." ,'e'},
        {"..-.",'f'},
        {"--." ,'g'},
        {"...." ,'h'},
        {".." ,'i'},
        {".---" ,'j'},
        {"-.-" ,'k'},
        {".-..",'l'},
        {"--",'m'},
        {"-.",'n'},
        {"---",'o'},
        {".--.",'p'},
        {"--.-" ,'q'},
        {".-.",'r'},
        {"...",'s'},
        {"-",'t'},
        {"..-",'u'},
        {"...-",'v'},
        {".--",'w'},
        {"-..-",'x'},
        {"-.--",'y'},
        {"--..",'z'},
        {".----",'1'},
        {"..---",'2'},
        {"...--",'3'},
        {"....-",'4'},
        {".....",'5'},
        {"-....",'6'},
        {"--...",'7'},
        {"---..",'8'},
        {"----.",'9'},
        {"-----",'0'},
    };
}