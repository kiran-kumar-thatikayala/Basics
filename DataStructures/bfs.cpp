#include<iostream>
using namespace std;

#define MAX 8
#define TRUE 1
#define FALSE 0

struct node
{
    int data;
    struct node* next;
};
int visited[MAX];
struct node* newnode;
struct node* getnode_write(int val);
void bfs(int v,struct node** arr,int n);
int q[MAX];
int rear,front;

int peek()
{
    return q[front];
}

bool queue_isempty()
{
    if(front ==-1)
        return true;
    else
     return false;
}

bool queue_isfull()
{
    if(rear == MAX-1)
    {
        return true;
    }
    else return false;
}

void queue_insert(int data)
{
    if(!queue_isfull())
    {
        rear++;
        q[rear] = data;
        if(front == -1)
            front = 0;
    }
    else
    {
        cout<<"queue is full"<<endl;
        //exit();
    }
    
}

int queue_dequeue()
{
    int data = -1;
    if(!queue_isempty())
    {
        data  = q[front];
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
    struct node* arr[MAX];
    struct node *v1,*v2,*v3,*v4,*v5,*v6,*v7, *v8;

    //vertex 1
    v1 = getnode_write(2);
    arr[0] = v1;
    v2 = getnode_write(3);
    v1->next = v2;
    v2->next = NULL;

    //vertex 2
    v1 = getnode_write(1);
    arr[1] = v1;
    v1->next = v2 = getnode_write(4);
    v2->next = v3 = getnode_write(5);
    v3->next = NULL;

    //vertex 3
    v1 = getnode_write(1);
    arr[2] = v1;
    v1->next = v2 = getnode_write(6);
    v2->next = v3 = getnode_write(7);
    v3->next = NULL;

    //vertex 4
    v1 = getnode_write(2);
    arr[3] = v1;
    v1->next = v2 = getnode_write(8);
    v2->next = NULL;

    //vertex 5
    v1 = getnode_write(2);
    arr[4] = v1;
    v1->next = v2 = getnode_write(8);
    v2->next = NULL;


    //vertex 6
    v1 = getnode_write(3);
    arr[5] = v1;
    v1->next = v2 = getnode_write(8);
    v2->next = NULL;


    //vertex 7
    v1 = getnode_write(3);
    arr[6] = v1;
    v1->next = v2 = getnode_write(8);
    v2->next = NULL;

     //vertex 8
    v1 = getnode_write(4);
    arr[7] = v1;
    v1->next = v2 = getnode_write(5);
    v2->next = v3 = getnode_write(6);
    v3->next = v4 = getnode_write(7);
    v4->next = NULL;

    rear=front=-1;

    bfs(1, arr,8);
}

struct node* getnode_write(int val)
{
    node* node = (struct node*)malloc(sizeof(struct node));
    node->data = val;
    node -> next = NULL;
    return node;
}

void bfs(int v,struct node** arr,int n)
{
    cout<<"visited:"<<v<<endl;
    queue_insert(v);
    visited[v-1] = TRUE;
    while (!queue_isempty())
    {
        int w= queue_dequeue();
        node *temp_array = *(arr+w-1);
        while (temp_array!=NULL)
        {
            if(visited[temp_array->data - 1] == FALSE)
            {
                visited[temp_array->data-1] = TRUE;
                queue_insert(temp_array->data);
                cout<<"visited: "<<temp_array->data<<endl;
            }
            
            temp_array=temp_array->next;

        }                
    }
    
}