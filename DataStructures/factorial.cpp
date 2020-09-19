#include <iostream>
using namespace std;

int fact(int n)
{
    if(n<=1) 
        return 1;
    return n* fact(n-1);
}

int factWhile(int n)
{
    int fact=1;
    while (n>1)
    {
        fact = fact*n;
        n=n-1;
    }
    return fact;
    
}

int main()
{
    cout<<fact(5)<<endl;
    cout<<factWhile(5);
    return 0;
}
