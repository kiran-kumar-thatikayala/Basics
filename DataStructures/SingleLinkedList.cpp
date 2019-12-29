// Simple C++ program on single linked list 
  
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

void InsertNodeAtBegining(Node **node,int data)
{
    if (*node == NULL)
    {
        *node = (Node*) malloc(sizeof(Node));
        (*node)->key = data;
        (*node)->next = NULL;
    }
    else
    {
        Node *newNode = (Node*) malloc(sizeof(Node));
        newNode->key = data;
        newNode->next = *node;

        *node = newNode;        
    }
}

bool IsExisit(Node *root,int data)
{
    while(root !=NULL)
    {
        if (root->key == data)
        {
            return true;
        }

        root = root->next;        
    }
    return false;
}

bool InsertNodeAfter(Node *root,int searchData, int data)
{
     while(root !=NULL)
    {
        if (root->key == searchData)
        {
            Node *newNode = (Node*) malloc(sizeof(Node));
            newNode->key = data;
            newNode->next = root->next;
            root->next = newNode;

            return true;
        }

        root = root->next;        
    }
    
    return false;
    
}

bool Delete(Node **root, int data)
{   
    if((*root)->key == data)
    {
        Node *rootNode = *root;
        *root = (*root)->next;
        free(rootNode);
        return true;
    }
    else
    {    
        Node *temp = *root;
        while (temp -> next != NULL)
        {
            if(temp -> next -> key == data)
            {
                Node* nextNode = temp ->next;
                temp -> next = temp ->next ->next;               
                free(nextNode);
                return true;               
            }
            temp = temp ->next;
        }
    }

    return false;
}

void DisplayList(Node* root)
{
    while (root != NULL)
    {
        cout << root->key<<endl;
        root = root->next;
    }
}

void DisplayListRecursive(Node* root)
{
   if(root == NULL)
    return;
    cout<<root->key<<endl;
    DisplayListRecursive(root->next);
}

void ReverseLinkedList(Node** root)
{
    Node* current = *root;
    Node* next = NULL;
    Node* prev = NULL;
    while(current != NULL)
    {
        next = current ->next;
        current ->next = prev;
        prev = current;
        current = next;
    }

    *root = prev;
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

    //cout<<"Display after inserting at the end"<<endl<<endl;

    //DisplayList(root);

    InsertNodeAtBegining(&root,60);
    InsertNodeAtBegining(&root, 70);

    //cout<<"Display after inserting at the begining"<<endl;
    //DisplayList(root);

    /*
    if(IsExisit(root,60))
        cout<<"found it"<<endl;
    else    
        cout<<"element not found"<<endl;
    
    if(InsertNodeAfter(root,10,15))
    {
        cout<<"inserted after node 10"<<endl;
        DisplayList(root);
    }
    else
    {
        cout<<"Element not find. Failed insertion after node  key 10"<<endl;
    }

    if (Delete(&root , 70))
    {
        cout<<"deleted from the start"<<endl;
    }
    else
    {
        cout<<"filed to delete"<<endl;
    }
    DisplayList(root);    

    if (Delete(&root , 40))
    {
        cout<<"deleted in the middle"<<endl;
    }
    else
    {
        cout<<"failed to delete"<<endl;
    }

    DisplayList(root);   

    if (Delete(&root , 30))
    {
        cout<<"deleted in the middle"<<endl;
    }
    else
    {
        cout<<"failed to delete"<<endl;
    }

    DisplayList(root);

    if (Delete(&root , 50))
    {
        cout<<"deleted at end"<<endl;
    }
    else
    {
        cout<<"failed delete at end"<<endl;
    }

    DisplayList(root);   

    cout<<"recursive display"<<endl;

    */
    cout<<"Original list"<<endl;
    DisplayList(root);
    cout<<"after revesal"<<endl;
    ReverseLinkedList(&root);
    DisplayList(root);

    return 0; 
} 