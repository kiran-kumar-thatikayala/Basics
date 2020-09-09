#include<iostream>
using namespace std;

#define MAX 8

int arr[MAX];  
int front, rear;

int peek()
{
    return arr[front];
}

bool isempty()
{
    if(front ==-1)
        return true;
    else
     return false;
}

bool isfull()
{
    if(rear == MAX-1)
    {
        return true;
    }
    else return false;
}

void insert(int data)
{
    if(!isfull())
    {
        rear++;
        arr[rear] = data;
        if(front == -1)
            front = 0;
    }
    else
    {
        cout<<"queue is full"<<endl;
        //exit();
    }
    
}

int dequeue()
{
    int data = -1;
    if(!isempty())
    {
        data  = arr[front];
         if(front == rear)
             front=rear=-1;
        else
            front++;
    }
   else
   {
       cout<<"queue is empty"<<endl;
       //exit();
   }
   
    return data;
}
int main()
{
    front = rear = -1;
    insert(1);
    insert(4);  
    insert(2);
    insert(10);
    insert(3);
    insert(5);
    insert(8);
    insert(7);
    insert(9);

    cout<<dequeue()<<endl;
    cout<<dequeue()<<endl;
    cout<<dequeue()<<endl;
    cout<<dequeue()<<endl;
    cout<<dequeue()<<endl;
    cout<<dequeue()<<endl;
    cout<<dequeue()<<endl;
    cout<<dequeue()<<endl;
    cout<<dequeue()<<endl;    

    return 0;
}