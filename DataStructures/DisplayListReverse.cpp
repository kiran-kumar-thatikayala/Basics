// Simple C++ program on single linked list ---
  
// Header file for input output functions 
#include<iostream>  
  
using namespace std; 
  
struct  Node
{
    /* data */
    int key;
    Node* next;
};

void InsertNodeAtEnd(Node **node,int data)
{
    if (*node == NULL)
    {
        *node = (Node*) malloc(sizeof(Node));
        (*node)->key = data;
        (*node)->next = NULL;
    }
    else
    {
        Node* temp = *node;
        while (temp->next != NULL)
        {
            temp = temp->next;
        }
        
        Node *newNode = (Node*) malloc(sizeof(Node));
        newNode->key = data;
        newNode->next = NULL;
        temp->next = newNode;
    }
}

void DisplayList(Node* node)
{
    if(node==NULL) return;
    cout<<node->key<<endl;
    DisplayList(node->next);
}

void DisplayListReverse(Node* node)
{
    if(node!=NULL)
    {
        DisplayListReverse(node->next);
        cout<<node->key<<endl;
    }
}
// main function - 
// where the execution of program begins 
int main() 
{ 
    Node *root=NULL;
    
    InsertNodeAtEnd(&root, 5);
    InsertNodeAtEnd(&root,10);
    InsertNodeAtEnd(&root,30);
    InsertNodeAtEnd(&root,40);
    InsertNodeAtEnd(&root,50);
   
    cout<<"Original list"<<endl;
    DisplayList(root);

    cout<<"after revesal"<<endl;
    
    DisplayListReverse(root);

    return 0; 
} 