int x1 = 8;

x1 = x1 + 3; //11
x1 += 3; //14
x1 -= 3;//11
x1 *= 2; //22 => (x1 = x1 * 2);
x1 /= 2; //11 => x1 = x1 / 2;
// x1 /= 3; // 3
x1 %= 3; //2 => x1 = x1 % 3

/*----------------------------*/
x1 += 1; //3
x1++; //4 => x1 += 1 => (x1 = x1 + 1)

x1--; // 3 => x1 -= 1 => (x1 = x1 - 1)

string s = "Moshe";
s = "Eran";
s = s + " Halali"; // Eran Halali
s += " Halali"; // Eran Halali Halali

s = s.ToUpper();//ERAN HALALI HALALI
s = s.ToLower();//eran halali halali
Console.WriteLine(s.Length); // 18

x1 = 0;
x1++;// 1
++x1;//2

Console.WriteLine(x1); // 2
Console.WriteLine(x1++); //2 => and afterwith advance x1 to 3
Console.WriteLine(x1); // 3
Console.WriteLine(++x1); //4

x1 = 10;
int x2 = x1++;//x2=10,x1=11

x1 = 10;
x2 = ++x1;//x1=x2=11










