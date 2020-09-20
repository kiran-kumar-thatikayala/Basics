#include<iostream>
using namespace std;


void showlist(int *arr,int low,int high)
{
    cout<<"list:"<<endl;
    for(int i=low; i<=high;i++)
    {
        cout<<arr[i]<<" "<<endl;
    }
}

void swap(int *arr, int i, int j)
{
    int temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}

void reverse(int arr[],int low,int high)
{
    while (low<high)
    {
        swap(arr,low,high);
        low++;
        high--;      
    }    
}

int main() 
{ 

    int n;   
    cout << "Enter the number of elements: ";
    cin >> n;

    int *arr  = new int[n];     //create an array with given number of elements
    cout << "Enter elements:" << endl;

    for(int i = 0; i<n; i++) 
    {
    cin >> arr[i];
    }  

    cout << "before reversing: ";
    showlist(arr, 0,n-1);


    reverse(arr,0,n-1);

    cout << "Array reversing: ";
    showlist(arr, 0,n-1);


    delete arr;
    return 0;
}