#include<iostream>
using namespace std;

#define SIZE 5

void showlist(int *arr,int count)
{
    cout<<"list:"<<endl;
    for(int i=0; i<count;i++)
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

//sample : 7,2,4,1,5,3
void insertionsort(int *arr, int count)
{
    for (int i = 1; i < count; i++)
    {
      int val = arr[i];
      int hole = i;  
      
      while(hole > 0 && arr[hole-1]>val)
      {
          arr[hole] = arr[hole-1];
          hole--;
      }
      if(i!=hole)
        arr[hole] = val;
    }    
}

//test cases
void TestSwap(int *arr)
{
    swap(arr,2,3);
}

int main()
{
    int arr[SIZE];
    cout<<"enter input list"<<endl;
    for (int i = 0; i < SIZE; i++)
    {
        cin>>arr[i];
    }
    
    //showlist(arr,SIZE);
    //TestSwap(a);
    insertionsort(arr,SIZE);
    showlist(arr,SIZE);

    return 0;
}