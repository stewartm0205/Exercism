import random
class Cipher:
    def __init__(self, key=None):
        if key == None:
            self.key = ''
            for i in range(0,100):
                self.key += chr(random.randint(97,122))
        else:
            self.key = key

        self.keyn=[]
        for ch in self.key:
                self.keyn.append(ord(ch)-ord('a'))

        self.kl = len(self.keyn)
        print (self.keyn)
        print (self.kl)

    def encode(self, text):
        encode_txt=''
        i = 0
        for ch in text:
            if ord(ch) + self.keyn[i % self.kl] <= 122:
                encode_txt += chr(ord(ch) + self.keyn[i % self.kl])
            else:
                encode_txt += chr(ord(ch) + self.keyn[i % self.kl] - ord('z')+ ord('a') - 1)
            i += 1
        return encode_txt

    def decode(self, text):
        decode_txt = ''
        i = 0
        for ch in text:
            print(ch,ord(ch),chr(97))
            if ord(ch) - self.keyn[i % self.kl] < 97:
                decode_txt += 'z'
            else:
                decode_txt += chr(ord(ch) - self.keyn[i % self.kl] - 1)
            i += 1
        return decode_txt

#cipher = Cipher("abcdefghij")
#print(cipher.decode("zabcdefghi"))
print('pppo',ord('a'), ord('z'), ord('r'),chr(106))