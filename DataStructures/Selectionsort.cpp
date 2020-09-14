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

void selectionsort(int *arr, int count)
{
    for (int i = 0; i < count-1; i++)
    {
        int min = i;

        for (int j = i+1; j < count; j++)
        {   
            if(arr[j] < arr[min])
            {
                min = j;
            }
        }        
            if(i!= min)
                swap(arr, min, i);
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
    selectionsort(arr,SIZE);
    showlist(arr,SIZE);

    return 0;
}