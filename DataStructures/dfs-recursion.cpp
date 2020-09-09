#include<iostream>
using namespace std;

#define MAX 8
#define TRUE 1
#define FALSE 0;

struct node
{
    int data;
    struct node* next;
};
int visited[MAX];
struct node* newnode;
struct node* getnode_write(int val);
void dfs(int v,struct node** arr,int n);


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

    dfs(1, arr,8);
}

struct node* getnode_write(int val)
{
    node* node = (struct node*)malloc(sizeof(struct node));
    node->data = val;
    node -> next = NULL;
    return node;
}

void dfs(int v,struct node** arr,int n)
{
    visited[v-1] = TRUE;
    cout<<v<<endl;
    node *q = *(arr + v-1);
    while (q!=NULL)
    {
        if(visited[q->data - 1] == 0)
        {
            dfs(q->data, arr, n);
        }
        else
            q=q->next;
    }    
}