#include<iostream>  
  
using namespace std; 

struct Node
{
    Node* left;
    int data;
    Node* right;
};

void Insert(Node** tree, int data)
{

    if(*tree == NULL)
    {
        Node* temp = (Node*) malloc(sizeof(Node));
        temp->left = NULL;
        temp->right = NULL;
        temp->data = data;
        *tree = temp;
        return;
    }
    else
    {
        if(data<=(*tree)->data)
        {
            Insert(&(*tree)->left,data);
        }
        else
        {
            Insert(&(*tree)->right,data);
        }        
    } 
}
void PreOrderTraversal(Node* tree)
{
    if(tree!=NULL)
    {
        cout<<tree->data<<endl;
        PreOrderTraversal(tree->left);
        PreOrderTraversal(tree->right);
    }
}
void InOrderTraversal(Node* tree)
{
    if(tree!=NULL)
    {
        InOrderTraversal(tree->left);
        InOrderTraversal(tree->right);
        cout<<tree->data<<endl;
    }
}

void PostOrderTraversal(Node* tree)
{
    if(tree!=NULL)
    {
        PostOrderTraversal(tree->left);
        cout<<tree->data<<endl;
        PostOrderTraversal(tree->right);
    }
}
int main()
{
    Node *tree = NULL;
    Insert(&tree, 9);
    Insert(&tree, 12);
    Insert(&tree, 17);
    Insert(&tree, 4);
    Insert(&tree, 15);
    Insert(&tree, 2);
    Insert(&tree, 6);

    cout<<"Pre Order:"<<endl;
    PreOrderTraversal(tree);
    cout<<endl<<"In Order:"<<endl;
    InOrderTraversal(tree);
    cout<<endl<<"Post Order:"<<endl;
    PostOrderTraversal(tree);
}