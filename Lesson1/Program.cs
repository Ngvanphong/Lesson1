// See https://aka.ms/new-console-template for more information

using System;

int a = 35;
int b = 20;
int tong = a + b;
int nhan = a * b;
int chia = a / b;
int phandu= a % b;

bool dungsai= a>b; // true
dungsai = a > b && a < 20; //false
dungsai = a >= b || a < 20 || a<=30; //true;
dungsai = a == b || a != 35;// false;
dungsai= a>b && (a>b || a <20); // true;

dungsai = !(a >= b); /// false;
//Console.WriteLine($"Tong = {tong}");

int c = 30;
//c++; // 31 c= c+1;
//c--; //30;
//c += 2; // 32; c= c+2;
//c -= 2;
int k = c++;
int g = k += 1;
//int k = ++c;

int m= 3;
int n = 10;

int o = !(m > n) ? (m+n): 300;


Console.WriteLine(o);





