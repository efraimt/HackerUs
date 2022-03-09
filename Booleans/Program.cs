
bool b1 = false;
bool b2 = true;

b1 = true;
b2 = false;
b2 = false;

b2 = b1;

b1 = 13 < 15; // true
Console.WriteLine(b1); // true

Console.WriteLine(13 < 15); //true
b2 = 13 > 15; //false
b2 = !b2; // true
b2 = !b2; // false
b2 = !!b2; //false
b1 = false;
b2 = !b1;//b2 = true, b1 = flase


bool isTall = false;
bool isExpensive = true;


b1 = false;
b2 = false;
b2 = (!(!b1));

b2 = !!b2;
/*----------------------------*/

Console.WriteLine("Enter garde1");
int grade1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter garde2");
int grade2 = int.Parse(Console.ReadLine());

b2 = grade1 != grade2;
b2 = !(grade1 == grade2);

b1 = 13 >= 13;// true
b1 = 13 > 13; // false
b1 = 13 < 13; // false
b1 = (b1 == b1);// true
b1 = b2 != b1; // 

/*----------------------------*/

// < , > , == , ! , !=, <=, >=

grade1 = grade2  = 13;
Console.WriteLine(grade1!=grade2);//false
grade1 = 12;
grade2 = 13;
Console.WriteLine(++grade1 != grade2);//false


/*---------------------*/
string s1 = "M1", s2 = "M2";
bool b1 = s1 != s2;//flase
b1 = !(s1 == s2);






