class Solution:
    def romanToInt(self, s: str) -> int:
        si=0
        rtoi={'M':1000,'CM':900,'D':500,'CD':400,'C':100,'XC':90,'L':50,'XL':40,'X':10,'IX':9,'V':5,'IV':4,'I':1}
        i=0
        while i<len(s):
             if s[i:i+2] in rtoi:
                si+=rtoi[s[i:i+2]]
                i+=2
             elif s[i:i+1] in rtoi:
                si+=rtoi[s[i:i+1]]
                i+=1
        return si
a=Solution()
print(a.romanToInt('IV'))