﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography.Algorithms
{
    public class RandomKeyGenerator
    {
        //used to generate strong random keys



        readonly private char[] _keyCharMap = new char[256];

        public string RandomKey { get; private set; }
        public bool ValidKeyLength { get; private set; }

        public RandomKeyGenerator(int KeyLength)
        {
            //require at least 10 characters!
            if (KeyLength > 10)
            {

                ValidKeyLength = true;
                LoadKeyMap();

                //now set key
                SetKey(KeyLength);
            }
            else
            {
                ValidKeyLength = false;
            }
        }

        private void SetKey(int KeyLength)
        {
            byte[] randomBytes = new byte[KeyLength];
            string privateKey = "";

            using (RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetBytes(randomBytes);

                foreach (byte charValue in randomBytes)
                {
                    char randomChar = _keyCharMap[charValue];
                    privateKey += randomChar.ToString();
                }
            }

            RandomKey = privateKey;
        }

        private void LoadKeyMap()
        {
            //this should be different for each application
            //I generated this random mapping in excel 
            _keyCharMap[0] = 't';
            _keyCharMap[1] = 'f';
            _keyCharMap[2] = '1';
            _keyCharMap[3] = '?';
            _keyCharMap[4] = '1';
            _keyCharMap[5] = 'R';
            _keyCharMap[6] = '1';
            _keyCharMap[7] = '2';
            _keyCharMap[8] = '*';
            _keyCharMap[9] = 'E';
            _keyCharMap[10] = 'N';
            _keyCharMap[11] = 'L';
            _keyCharMap[12] = '5';
            _keyCharMap[13] = 'V';
            _keyCharMap[14] = 'L';
            _keyCharMap[15] = 'U';
            _keyCharMap[16] = '4';
            _keyCharMap[17] = 'y';
            _keyCharMap[18] = 'p';
            _keyCharMap[19] = 'i';
            _keyCharMap[20] = '9';
            _keyCharMap[21] = 'Q';
            _keyCharMap[22] = 'V';
            _keyCharMap[23] = 'R';
            _keyCharMap[24] = 'U';
            _keyCharMap[25] = 'v';
            _keyCharMap[26] = 'N';
            _keyCharMap[27] = '6';
            _keyCharMap[28] = 'm';
            _keyCharMap[29] = 'Q';
            _keyCharMap[30] = '%';
            _keyCharMap[31] = 'F';
            _keyCharMap[32] = 'Z';
            _keyCharMap[33] = 'V';
            _keyCharMap[34] = 't';
            _keyCharMap[35] = 'd';
            _keyCharMap[36] = 'b';
            _keyCharMap[37] = 'v';
            _keyCharMap[38] = 'g';
            _keyCharMap[39] = 'Y';
            _keyCharMap[40] = '0';
            _keyCharMap[41] = 'V';
            _keyCharMap[42] = '7';
            _keyCharMap[43] = '+';
            _keyCharMap[44] = 'u';
            _keyCharMap[45] = 's';
            _keyCharMap[46] = 'V';
            _keyCharMap[47] = 'i';
            _keyCharMap[48] = '*';
            _keyCharMap[49] = 'z';
            _keyCharMap[50] = '8';
            _keyCharMap[51] = 'y';
            _keyCharMap[52] = 'S';
            _keyCharMap[53] = 'Y';
            _keyCharMap[54] = '3';
            _keyCharMap[55] = '*';
            _keyCharMap[56] = '9';
            _keyCharMap[57] = '!';
            _keyCharMap[58] = '&';
            _keyCharMap[59] = 'R';
            _keyCharMap[60] = 'Z';
            _keyCharMap[61] = 'R';
            _keyCharMap[62] = '9';
            _keyCharMap[63] = 'E';
            _keyCharMap[64] = '*';
            _keyCharMap[65] = 'T';
            _keyCharMap[66] = 'K';
            _keyCharMap[67] = '2';
            _keyCharMap[68] = 'g';
            _keyCharMap[69] = 'a';
            _keyCharMap[70] = 'N';
            _keyCharMap[71] = 'U';
            _keyCharMap[72] = 'u';
            _keyCharMap[73] = 'e';
            _keyCharMap[74] = 'd';
            _keyCharMap[75] = 'L';
            _keyCharMap[76] = 'e';
            _keyCharMap[77] = 'T';
            _keyCharMap[78] = 'L';
            _keyCharMap[79] = 'c';
            _keyCharMap[80] = 'w';
            _keyCharMap[81] = 'L';
            _keyCharMap[82] = 'Q';
            _keyCharMap[83] = 'S';
            _keyCharMap[84] = 'X';
            _keyCharMap[85] = 'v';
            _keyCharMap[86] = 'Y';
            _keyCharMap[87] = 'E';
            _keyCharMap[88] = 'Y';
            _keyCharMap[89] = 'A';
            _keyCharMap[90] = '8';
            _keyCharMap[91] = 'i';
            _keyCharMap[92] = 'n';
            _keyCharMap[93] = 'N';
            _keyCharMap[94] = 'd';
            _keyCharMap[95] = '2';
            _keyCharMap[96] = '+';
            _keyCharMap[97] = 'Y';
            _keyCharMap[98] = 'J';
            _keyCharMap[99] = '+';
            _keyCharMap[100] = 'T';
            _keyCharMap[101] = 'H';
            _keyCharMap[102] = 't';
            _keyCharMap[103] = 'Z';
            _keyCharMap[104] = 'F';
            _keyCharMap[105] = 'A';
            _keyCharMap[106] = 'v';
            _keyCharMap[107] = 'v';
            _keyCharMap[108] = 'e';
            _keyCharMap[109] = 'N';
            _keyCharMap[110] = 'I';
            _keyCharMap[111] = 'h';
            _keyCharMap[112] = '*';
            _keyCharMap[113] = 'o';
            _keyCharMap[114] = 'B';
            _keyCharMap[115] = 'p';
            _keyCharMap[116] = 'H';
            _keyCharMap[117] = '%';
            _keyCharMap[118] = 'b';
            _keyCharMap[119] = 'T';
            _keyCharMap[120] = 'f';
            _keyCharMap[121] = 'V';
            _keyCharMap[122] = 'R';
            _keyCharMap[123] = 'A';
            _keyCharMap[124] = 'C';
            _keyCharMap[125] = 'w';
            _keyCharMap[126] = 'J';
            _keyCharMap[127] = '0';
            _keyCharMap[128] = '1';
            _keyCharMap[129] = 'o';
            _keyCharMap[130] = 'C';
            _keyCharMap[131] = 'U';
            _keyCharMap[132] = 'P';
            _keyCharMap[133] = 'h';
            _keyCharMap[134] = 'Q';
            _keyCharMap[135] = 'a';
            _keyCharMap[136] = 'Y';
            _keyCharMap[137] = 'p';
            _keyCharMap[138] = 'c';
            _keyCharMap[139] = '#';
            _keyCharMap[140] = 'g';
            _keyCharMap[141] = '%';
            _keyCharMap[142] = 'S';
            _keyCharMap[143] = 'F';
            _keyCharMap[144] = '2';
            _keyCharMap[145] = 'D';
            _keyCharMap[146] = '?';
            _keyCharMap[147] = '0';
            _keyCharMap[148] = 's';
            _keyCharMap[149] = 'x';
            _keyCharMap[150] = 'n';
            _keyCharMap[151] = 'J';
            _keyCharMap[152] = 'M';
            _keyCharMap[153] = 't';
            _keyCharMap[154] = 'T';
            _keyCharMap[155] = 'A';
            _keyCharMap[156] = 'e';
            _keyCharMap[157] = 'n';
            _keyCharMap[158] = '#';
            _keyCharMap[159] = '!';
            _keyCharMap[160] = 'v';
            _keyCharMap[161] = '!';
            _keyCharMap[162] = '5';
            _keyCharMap[163] = '+';
            _keyCharMap[164] = 'i';
            _keyCharMap[165] = 'u';
            _keyCharMap[166] = '*';
            _keyCharMap[167] = 'R';
            _keyCharMap[168] = 'N';
            _keyCharMap[169] = 'g';
            _keyCharMap[170] = 'Q';
            _keyCharMap[171] = 'C';
            _keyCharMap[172] = 'M';
            _keyCharMap[173] = 'w';
            _keyCharMap[174] = 'A';
            _keyCharMap[175] = 'F';
            _keyCharMap[176] = 'w';
            _keyCharMap[177] = 'T';
            _keyCharMap[178] = 'b';
            _keyCharMap[179] = 'J';
            _keyCharMap[180] = 'a';
            _keyCharMap[181] = 'V';
            _keyCharMap[182] = 't';
            _keyCharMap[183] = 'I';
            _keyCharMap[184] = 'u';
            _keyCharMap[185] = '+';
            _keyCharMap[186] = 'w';
            _keyCharMap[187] = 'R';
            _keyCharMap[188] = 'o';
            _keyCharMap[189] = '1';
            _keyCharMap[190] = 'q';
            _keyCharMap[191] = 'k';
            _keyCharMap[192] = '%';
            _keyCharMap[193] = 'Z';
            _keyCharMap[194] = '%';
            _keyCharMap[195] = 'S';
            _keyCharMap[196] = '2';
            _keyCharMap[197] = '0';
            _keyCharMap[198] = '6';
            _keyCharMap[199] = '5';
            _keyCharMap[200] = '?';
            _keyCharMap[201] = 'R';
            _keyCharMap[202] = 'B';
            _keyCharMap[203] = '4';
            _keyCharMap[204] = 's';
            _keyCharMap[205] = 'y';
            _keyCharMap[206] = 'A';
            _keyCharMap[207] = 'a';
            _keyCharMap[208] = 'x';
            _keyCharMap[209] = 'U';
            _keyCharMap[210] = 'G';
            _keyCharMap[211] = 'c';
            _keyCharMap[212] = 'l';
            _keyCharMap[213] = 'D';
            _keyCharMap[214] = 'T';
            _keyCharMap[215] = 'x';
            _keyCharMap[216] = 'c';
            _keyCharMap[217] = 'I';
            _keyCharMap[218] = 'o';
            _keyCharMap[219] = 'y';
            _keyCharMap[220] = 'K';
            _keyCharMap[221] = 'a';
            _keyCharMap[222] = '2';
            _keyCharMap[223] = 'c';
            _keyCharMap[224] = 'o';
            _keyCharMap[225] = 'a';
            _keyCharMap[226] = 'F';
            _keyCharMap[227] = 'd';
            _keyCharMap[228] = '?';
            _keyCharMap[229] = 'T';
            _keyCharMap[230] = 'L';
            _keyCharMap[231] = 'Z';
            _keyCharMap[232] = '&';
            _keyCharMap[233] = 'i';
            _keyCharMap[234] = 'T';
            _keyCharMap[235] = '0';
            _keyCharMap[236] = 'p';
            _keyCharMap[237] = 'r';
            _keyCharMap[238] = '0';
            _keyCharMap[239] = 'H';
            _keyCharMap[240] = 'j';
            _keyCharMap[241] = 'l';
            _keyCharMap[242] = 'X';
            _keyCharMap[243] = 'u';
            _keyCharMap[244] = '-';
            _keyCharMap[245] = '$';
            _keyCharMap[246] = 'Y';
            _keyCharMap[247] = '-';
            _keyCharMap[248] = '2';
            _keyCharMap[249] = 'e';
            _keyCharMap[250] = 'M';
            _keyCharMap[251] = 'x';
            _keyCharMap[252] = 'p';
            _keyCharMap[253] = 'B';
            _keyCharMap[254] = 'f';
            _keyCharMap[255] = 'G';


        }
    }
}
