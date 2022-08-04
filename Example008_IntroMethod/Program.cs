int Max(int arg1, int arg2, int arg3)

{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result; 
}



int a1 = 5;
int b1 = 16;
int c1 = 20;

int a2 = 66;
int b2 = 54;
int c2 = 34;

int a3 = 4;
int b3 = 800;
int c3 = 100;


int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));


Console.WriteLine(max);