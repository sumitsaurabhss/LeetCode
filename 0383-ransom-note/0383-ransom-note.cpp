class Solution {
public:
    bool canConstruct(string ransomNote, string magazine) {
        int ransomLetterArray[26]={0}, magazineLetterArray[26]={0};
        int ransomNoteSize = ransomNote.size(), magazineSize = magazine.size();
        if(ransomNoteSize > magazineSize)  return false;
        for(int i=0; i<ransomNoteSize; i++){
            int letterIndexInAlphabet = ransomNote[i]-'a';
            ransomLetterArray[letterIndexInAlphabet]++;
        }
        for(int i=0; i<magazineSize; i++){
            int letterIndexInAlphabet = magazine[i]-'a';
            magazineLetterArray[letterIndexInAlphabet]++;
        }
        for(int i=0; i<26; i++){
            if(ransomLetterArray[i] > magazineLetterArray[i])  return false;
        }
        return true;
    }
};