// Теория http://php.spb.ru/php/ip.html
// Переписал на C#

// Забрасываем в общий код и вызываем 
// return CommonCode.IpToInt("192.168.1.1"); // IP в число
// return CommonCode.IntToIp("1215161"); // Число в IP

public class CommonCode {
    public static int IpToInt (string ip){
        string[] arr = ip.Trim().Split('.');
        if( arr.Length == 4 ) {
            int a = int.Parse(arr[0]) * 256 * 256 * 256;
            int b = int.Parse(arr[1]) * 256 * 256;
            int c = int.Parse(arr[2]) * 256;
            int d = int.Parse(arr[3]);
            return a+b+c+d;
        }
        else{
            return 0;
        }
    }
    public static string IntToIp (int ip){
        int z = (int) Math.Pow(2, Math.Pow(2, 3));
        int a = ip/z/z/z;
        int b = ( ip - a*z*z*z )/z/z;
        int c = (( ip - a*z*z*z - b*z*z)/z);
        int d = ( ip - a * z*z*z - b * z*z - c * z); 
        return string.Format("{0}.{1}.{2}.{3}", a,b,c,d);
    }
}
