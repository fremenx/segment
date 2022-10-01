var V = Sistem.GrafikVerileri;
var C = Sistem.GrafikFiyatSec("Kapanis");
var adx = Sistem.ADX(14);

var rsi_s1 = Sistem.RSI(28);
var rsi_s2 = Sistem.RSI(14);
var rsi_s3 = Sistem.RSI(7);

string sonyon = "";
float islemfiyat = 0.0f;
string sinyal = "";

for (int i = 72; i < V.Count; i++)
{
    sinyal = "";

    if (adx[i] < 15)
    {
        sinyal = "F";
    }
    else if (adx[i] > 15 && adx[i] < 25)
    {
        if (rsi_s3[i] > 55) sinyal = "A";
    }
    else if (adx[i] > 25)
    {
        if (rsi_s2[i] > 55) sinyal = "A";
    }
    
    if (sinyal != "" && sinyal != sonyon)
    {
        Sistem.Yon[i] = sinyal;
        sonyon = sinyal;
    }
}