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

void bubblesort(int *arr, int count)
{
    for (int i = 0; i < count; i++)
    {
        for (int j = 0; j < count - i; j++)
        {   
            if(arr[j]>arr[j+1])
            {
                swap(arr,j,j+1);
            }
        }        
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
    bubblesort(arr,SIZE);
    showlist(arr,SIZE);

    return 0;
}