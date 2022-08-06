<?php

/*
 * By adding type hints and enabling strict type checking, code can become
 * easier to read, self-documenting and reduce the number of potential bugs.
 * By default, type declarations are non-strict, which means they will attempt
 * to change the original type to match the type specified by the
 * type-declaration.
 *
 * In other words, if you pass a string to a function requiring a float,
 * it will attempt to convert the string value to a float.
 *
 * To enable strict mode, a single declare directive must be placed at the top
 * of the file.
 * This means that the strictness of typing is configured on a per-file basis.
 * This directive not only affects the type declarations of parameters, but also
 * a function's return type.
 *
 * For more info review the Concept on strict type checking in the PHP track
 * <link>.
 *
 * To disable strict typing, comment out the directive below.
 */

declare(strict_types=1);

class SimpleCipher
{
    public $key;
    public $alpha="abcdefghijklmnopqrstuvwxyz";

    public function __construct(string $key = null)
    {

        $this->key="";
        if (gettype($key)=="NULL")
            for ($i=0;$i<100;$i++) $this->key.=substr($this->alpha,rand() % 26,1);
        else {
            if (preg_match("/[^a-z]+/",$key)) throw new InvalidArgumentException();
            if (strlen($key)==0) throw new InvalidArgumentException();
            $this->key=$key;
        }
    }

    public function encode(string $plainText): string
    {
        $cd="";
        foreach(str_split($plainText) as $ch) {
            $cd.=substr($this->key,strpos($this->alpha,$ch),1);
        }
        return $cd;
    }

    public function decode(string $cipherText): string
    {
        $dc="";
        foreach(str_split($cipherText) as $ch) {
            $dc.=substr($this->alpha,strpos($this->key,$ch),1);
        }
        return $dc;
    }
}
