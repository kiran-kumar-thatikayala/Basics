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

void merging(int *arr,int low, int mid, int high) 
{
   int i=0,j=0,k=low;
   int n1=mid-low+1; //mid=2, low=0, mid-low+1 = 2-0+1=3
   int n2=high-mid; //high=4,mid=2,high-mid = 4-2=2
 

   int arr1[n1], arr2[n2];

   for (int index = 0; index <n1; index++)
   {
      arr1[index] = arr[low+index];
   }


   for (int index = 0; index < n2; index++)
   {      
      arr2[index] = arr[mid+1+index];
   }


   while(i<n1 && j<n2)
   {
      if(arr1[i]<=arr2[j])      
         arr[k++] = arr1[i++];
      else
         arr[k++] = arr2[j++];
   }

   while (i<n1)
   {
      arr[k++] = arr1[i++];
   }
   
   while (j<n2)
   {
      arr[k++] = arr2[j++];
   }

   cout<<"after merging:"<< endl;
   for (int i = 0; i <= high; i++)
   {
      cout<<arr[i]<<",";
   }
   cout<<endl;
}

void mergesort(int* arr,int low, int high) {
   
   if(low<high)
   {
      int mid = low+(high-low)/2;
      mergesort(arr,low,mid);
      mergesort(arr,mid+1,high);
      merging(arr,low,mid,high);      
   }
}

int main() 
{ 

   int n;   
   cout << "Enter the number of elements: ";
   cin >> n;
   
   int arr[n];     //create an array with given number of elements
   cout << "Enter elements:" << endl;
   
   for(int i = 0; i<n; i++) {
      cin >> arr[i];
   }  
  
   mergesort(arr,0,4);
   cout << "Array after Sorting: ";
   showlist(arr, n);

    return 1;
}