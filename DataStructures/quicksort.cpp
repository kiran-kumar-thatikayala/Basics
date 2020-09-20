#include<iostream>
using namespace std;

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

//5 4 3 2 1
int Partition(int arr[],int low,int high)
{
    int i = low-1;
    int pivot = arr[high];
    for (int j = low; j <= high-1; j++)
    {
        if(arr[j] <= pivot)
        {
            i++;
            swap(arr, i,j);
        }
    }    
    swap(arr, i+1, high);
    return (i+1);
}

void QuickSort(int arr[],int low, int high)
{
    if(low<high)
    {
        int pIndex = Partition(arr,low,high);        
        QuickSort(arr,low,pIndex-1);
        QuickSort(arr,pIndex+1,high);        
    }
}


int main()
{
   int n;   
   cout << "Enter the number of elements: ";
   cin >> n;
   
   int *arr = new int[n];     //create an array with given number of elements
   cout << "Enter elements:" << endl;
   
   for(int i = 0; i<n; i++) {
      cin >> arr[i];
   }  
  

   cout << "beore sorting: ";
   showlist(arr, n);

   QuickSort(arr,0,n-1);

   cout << "after Sorting: ";
   showlist(arr, n);

    return 1;
}