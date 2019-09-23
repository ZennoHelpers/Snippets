string base64 = project.Variables["base64"].Value;
using (Bitmap bitmap = new Bitmap(new MemoryStream(Convert.FromBase64String(base64)))) { // base64 to bitmap
  for (int y = 0; y < bitmap.Height; y++) {
    for (int x = 0; x < bitmap.Width; x++) {
      string Brightness = bitmap.GetPixel(x, y).GetBrightness().ToString();
      string A = bitmap.GetPixel(x, y).A.ToString();
      string R = bitmap.GetPixel(x, y).R.ToString();
      string G = bitmap.GetPixel(x, y).G.ToString();
      string B = bitmap.GetPixel(x, y).B.ToString();
      project.SendInfoToLog(string.Format(@"x:{0} y:{1}, Яркость: {2} Прозрачность:{3} R:{4} G:{5} B:{6}",x,y,Brightness, A,R,G,B));
      Thread.Sleep(10);
    }
  }
}
