/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     struct ListNode *next;
 * };
 */
struct ListNode* middleNode(struct ListNode* head){
    static int numberOfNodes=0, reverseNodeIndex=0, middleNodeIndex=0;
    struct ListNode* midNode;
    if(head==NULL)  return NULL;
    numberOfNodes++;
    midNode = middleNode(head->next);
    reverseNodeIndex++;
    middleNodeIndex = (numberOfNodes+1)/2;      //1-baesd index
    //printf("%d %d %d\n", numberOfNodes, middleNodeIndex, reverseNodeIndex);
    if(reverseNodeIndex == middleNodeIndex)  return head;
    if(reverseNodeIndex == numberOfNodes)  reverseNodeIndex = numberOfNodes = 0;
    return midNode;
}