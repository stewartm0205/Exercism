import { createHook } from "async_hooks";

export class Cipher {
    constructor(key) {
        this.alpha = 'abcdefghijklmnopqrstvuwxyz';
        if (key == undefined) {
            for (var i = 0; i<100; i++){
                this.key += chr(ord('a')+Math.random() * 26);
            };
            console.log('random key=',this.key)
        } else {
            this.key = key;
        }
    }

    encode (sentence) {
        var code =""
        for (var i = 0; i<sentence.length; i++) {
            var ch = sentence.substr(i,1);
            var codepos = ord(ch) - ord('a');
            if (codepos > this.key.length) codepos = codepos % this.key.length;
            code += key.substr(codepos,1);
        }
        return code;
    }

    decode (code) {
        var sentence = "";
        for (var i = 0; i<code.length; i++) {
            var ch = code.substr(i,1);
            var letpos = ord(ch) - ord('a');
            if (letpos > this.key.length) letpos = letpos % this.key.length;
            sentence += key.substr(letpos,1);
        }
        return sentence;
    }