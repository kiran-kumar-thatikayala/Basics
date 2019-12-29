// Simple C++ program on double linked list 
  
// Header file for input output functions 
#include<iostream>  
  
using namespace std; 
  
struct  Node
{
    /* data */
    int key;
    Node* next;
    Node* prev;
};

void InsertNodeAtEnd(Node **root, Node** tail, int data)
{
    if (*root == NULL)
    {
        *root = (Node*) malloc(sizeof(Node));
        (*root)->key = data;
        (*root)->next = NULL;
        (*root)->prev = NULL;
        *tail = *root;
    }
    else
    {
        Node* temp = *root;
        while (temp->next != NULL)
        {
            temp = temp->next;
        }
        
        Node *newNode = (Node*) malloc(sizeof(Node));
        newNode->key = data;
        newNode->next = NULL;
        newNode->prev = temp;
        temp->next = newNode;
        *tail = newNode;

    }
}

void InsertNodeAtBegining(Node **root, Node** tail, int data)
{
    if (*root == NULL && *tail == NULL)
    {
        *root = (Node*) malloc(sizeof(Node));
        (*root)->key = data;
        (*root)->next = NULL;
        *tail = *root;
    }
    else
    {
        Node *newNode = (Node*) malloc(sizeof(Node));
        newNode->key = data;
        newNode->next = *root;
        newNode -> prev = NULL;
        *root = newNode;          
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
            cout<<"data found"<<endl;
            Node *newNode = (Node*) malloc(sizeof(Node));
            newNode->key = data;
            newNode->next = root->next;
            newNode -> prev = root;
            if(root->next != NULL)
                root -> next -> prev = newNode;
            root->next = newNode;

            return true;
        }

        root = root->next;        
    }
    
    return false;
    
}

bool DeleteNode(Node **root, int data)
{   
    if((*root)->key == data) //if first node to delete
    {
        Node *rootNode = *root;
        *root = (*root)->next;
        (*root) -> prev = NULL;
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
                temp -> prev = temp -> next ->prev;               
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

void DisplayListEnd(Node* tail)
{
    while (tail != NULL)
    {
        cout << tail->key<<endl;
        tail = tail->prev;
    }
}

void DisplayListRecursive(Node* root)
{
   if(root == NULL)
    return;
    cout<<root->key<<endl;
    DisplayListRecursive(root->next);
}

void DisplayListReverse(Node* tail)
{
   if(tail == NULL)
    return;
    cout<<tail->key<<endl;
    DisplayListReverse(tail->prev);
}

// main function - 
// where the execution of program begins 
int main() 
{ 
    Node *root=NULL, *tail = NULL;

    /* insert at the begining */
    
    InsertNodeAtBegining(&root,&tail,5);
    InsertNodeAtBegining(&root,&tail,4);
    InsertNodeAtBegining(&root,&tail,3);
    InsertNodeAtBegining(&root,&tail,2);
    InsertNodeAtBegining(&root,&tail,1);

    /* insert at the End */
    InsertNodeAtEnd(&root,&tail,10);
    InsertNodeAtEnd(&root,&tail,20);
    InsertNodeAtEnd(&root,&tail,30);
    InsertNodeAtEnd(&root,&tail,40);
    InsertNodeAtEnd(&root,&tail,50);
     

    /*insert after */
    InsertNodeAfter(root,3,35);
    InsertNodeAfter(root,30,13);
    InsertNodeAfter(root,50,60);

    DisplayList(root);

    DeleteNode(&root, 35);

    DeleteNode(&root, 1);
    DisplayList(root);


/*
    cout<<"display from begining - iterative"<<endl;
    DisplayList(root);

    cout<<"display from begining - recursive"<<endl;

    DisplayListRecursive(root);

    cout<<"display from end - iterative"<<endl;
    DisplayListEnd(tail);

    cout<<"display from end - recursive:"<<endl;
    DisplayListReverse(tail);
    */
    return 0; 
} 