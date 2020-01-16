// Общий код
namespace Analizing
{
    public static class EncodingTest
    {
        /// <summary>
        /// UTF8         : EF BB BF      
        /// UTF16 BE    : FE FF          
        /// UTF16 LE    : FF FE
        /// UTF32 BE    : 00 00 FE FF
        /// UTF32 LE    : FF FE 00 00
        /// </summary>
        public static Encoding DetectEncoding(string path)
        {
            FileStream fstream = new FileStream(path, FileMode.OpenOrCreate);
            Encoding result=Encoding.Default;
            if (!fstream.CanSeek || !fstream.CanRead){
                fstream.Close();
                throw new Exception("DetectEncoding() файл не может быть прочитан");
            }
            long Length_File = fstream.Length;
            int Length_Probe_Read = 1000;
            if (Length_Probe_Read >Length_File )Length_Probe_Read = Convert.ToInt32(Length_File);
            Byte[] u8_Buf = new Byte[Length_Probe_Read];
            int s32_Count = fstream.Read(u8_Buf, 0, Length_Probe_Read);
            if (s32_Count >= 2)
            {
                if (u8_Buf[0] == 0xFE && u8_Buf[1] == 0xFF)                {
                    result = new UnicodeEncoding(true, true);
                }
                if (u8_Buf[0] == 0xFF && u8_Buf[1] == 0xFE)                {
                    if (s32_Count >= 4 && u8_Buf[2] == 0 && u8_Buf[3] == 0)                    {
                        result = new UTF32Encoding(false, true);
                    }
                    else                    {
                        result = new UnicodeEncoding(false, true);
                    }
                }
                if (s32_Count >= 3 && u8_Buf[0] == 0xEF && u8_Buf[1] == 0xBB && u8_Buf[2] == 0xBF)                {
                    result = Encoding.UTF8;
                }
                if (s32_Count >= 4 && u8_Buf[0] == 0 && u8_Buf[1] == 0 && u8_Buf[2] == 0xFE && u8_Buf[3] == 0xFF)                {
                    result = new UTF32Encoding(true, true);
                }
                // проверка по коду 0xD0
                    double res= 0.0; double p =  0.0 ;
                    for (int i=0; i<u8_Buf.Length; i++) {
                        if (u8_Buf[i] == 0xD0 ) res++;
                    }
                    p =  res/u8_Buf.Length*100 ;
                    if ( p > 5 ) {                                // при ниличии символа 0xD0 больше чем 5%, можно предположить что кодировка UTF8
                        result = Encoding.UTF8;
                    }
                /////////////////////////////
            }
            fstream.Close();
            return result;
        }      
    }
}

// В кубике

string path = project.Directory + @"\" + project.Variables["input"].Value ; // путь к файлу
Encoding ecn1 =  Analizing.EncodingTest.DetectEncoding(path);                // попытка определить кодировку
project.SendInfoToLog("Определили кодировку как : " + ecn1.ToString());        // вывод кодировки в PM

var t = File.ReadAllText(path, ecn1);                                         // читаем весь файл
project.Variables["res"].Value = t;                                            // ложим в переменную
