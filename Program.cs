// See https://aka.ms/new-console-template for more information

Console.WriteLine("**Implicit Conversions**");
byte a = 5;
sbyte b = 30;
short c = 10;

int d = a+b+c;
Console.WriteLine("d= " + d);

long h = d;
Console.WriteLine("h= " + h);

string e = "BURAK";
char f = 'A';
object g = e+f+d;
Console.WriteLine("g= " + g);


Console.WriteLine("**Explicit Conversions**");
int x = 4;
byte y = (byte)x;
Console.WriteLine("y= " + y);

int z = 100;
byte t = (byte)z;
Console.WriteLine("t= " + t);

float w = 10.3f;
byte v = (byte)w;
Console.WriteLine("v= " + v);

Console.WriteLine("**ToString Method**");
int xx = 6;
string yy = xx.ToString();
Console.WriteLine("yy= " + yy);

string zz = 12.5f.ToString();
Console.WriteLine("zz= " + zz);

Console.WriteLine("**Convert Sınıfı**");
string s1="10", s2="20";
int sayi1, sayi2, toplam;

sayi1 = Convert.ToInt32(s1);
sayi2 = Convert.ToInt32(s2);
toplam = sayi1+sayi2;
Console.WriteLine("toplam= " + toplam);

Console.WriteLine("**Parse Method**");

parseMethod();

static void parseMethod() {

    string metin1 = "10" , metin2 = "10.25";
    int rakam1;
    double double1;

    rakam1 = int.Parse(metin1);
    double1 = double.Parse(metin2);

    Console.WriteLine("rakam1= " + rakam1);
    Console.WriteLine("double1= " + double1); 
}
