
#region Buoi1

//// See https://aka.ms/new-console-template for more information


//using System;

//int a = 35;
//int b = 20;
//int tong = a + b;
//int nhan = a * b;
//int chia = a / b;
//int phandu = a % b;

//bool dungsai = a > b; // true
//dungsai = a > b && a < 20; //false
//dungsai = a >= b || a < 20 || a <= 30; //true;
//dungsai = a == b || a != 35;// false;
//dungsai = a > b && (a > b || a < 20); // true;

//dungsai = !(a >= b); /// false;
//Console.WriteLine($"Tong = {tong}");

//int c = 30;
//c++; // 31 c= c+1;
//c--; //30;
//c += 2; // 32; c= c+2;
//c -= 2;
//int k = c++;
//int g = k += 1;
//int k = ++c;

//int m = 3;
//int n = 10;

//int o = !(m > n) ? (m + n) : 300;


//Console.WriteLine(o);

#endregion



#region
using System.ComponentModel.Design;
using System.Security.Principal;

double number = 20;
bool isTrue = false;

double tong = 0;
if(number<10 && !isTrue)
{
    ++tong;
}
else if (number == 20)
{
    tong += 20;
}
else if (number == 15)
{
    tong += 15;
}
else
{
    --tong;
}


int day = 1;
if (day == 1)
{
    Console.WriteLine("Monday");
}
else if (day == 2) Console.WriteLine("Tuesday");
else if (day == 3) Console.WriteLine("Wednesday");
else Console.WriteLine("Noday");

switch (day)
{
    case 1:
        {
            Console.WriteLine("Monday");
            break;
        }
    case 2:
        Console.WriteLine("Tuesday");
        break;
    default:
        Console.WriteLine("Noday");
        break;
}

for(int i = 0; i<10; i++)
{
    //Console.WriteLine(i);
}

int total = 0;
bool isTrue2 = false;
for(int k = 0;k<5 && !isTrue2; k += 2)
{
    total += 1;
}

double totalAll = 0;
for(int i =0;i<10; i++)
{
    if (totalAll == 5) break;
    if (i == 2) continue;
    totalAll += 1;
}

//Console.WriteLine(totalAll);


int[] arrayInt = new int[] { 9, 7, 8, 10, 13 };

foreach(int item in arrayInt)
{
    Console.WriteLine(item);
}


int index = 1;
int indexTotal = 0;
while(index < 10)
{
    if (index == 5) break;
    indexTotal += 1;
    index++;
}

do
{
    indexTotal += 1;
    index++;
} while(index < 10);


for(int i = 0;i<10;i++)
{
    Console.WriteLine(i);
    for(int j = 0; j < 5; j++)
    {
        Console.WriteLine(j);
    }
}


Console.WriteLine(indexTotal);














#endregion


