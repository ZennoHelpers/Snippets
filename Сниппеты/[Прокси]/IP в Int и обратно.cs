// Теория http://php.spb.ru/php/ip.html
// Переписал на C#

// IP в виде строки: "222.222.222.222" занимает  15 байт.
// В виде числа - 4 байта - uint ( https://metanit.com/sharp/tutorial/2.1.php )
	
/*
Пример вызова в кубике:
string ip = "192.168.1.1";

uint int_ip =  CommonCode.IpToInt(ip); // IP в число
project.SendInfoToLog(string.Format(@"IP={0} int={1}",ip, int_ip));

ip = CommonCode.IntToIp(int_ip); // число в IP
project.SendInfoToLog(string.Format(@"uint={0} IP={1} ",int_ip, ip));

*/

// Добавляем в общий код
public class CommonCode {
    public static uint IpToInt (string ip){
        string[] abcd = ip.Trim().Split('.');
        if( abcd.Length == 4 ) {
            uint a = uint.Parse(abcd[0]) * 256 * 256 * 256;
            uint b = uint.Parse(abcd[1]) * 256 * 256;
            uint c = uint.Parse(abcd[2]) * 256;
            uint d = uint.Parse(abcd[3]);
            return a+b+c+d;
        }
        else{
            return 0;
        }
    }
    public static string IntToIp (uint ip){
        int z = (int) Math.Pow(2, Math.Pow(2, 3));
        long a = ip/z/z/z;
        long b = ( ip - a*z*z*z )/z/z;
        long c = (( ip - a*z*z*z - b*z*z)/z);
        long d = ( ip - a * z*z*z - b * z*z - c * z); 
        return string.Format("{0}.{1}.{2}.{3}", a,b,c,d);
    }
}
