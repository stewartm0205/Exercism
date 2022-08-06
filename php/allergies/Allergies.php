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



class Allergies
{
    private $allergies;


    public function __construct(int $score)
    {
        $this->allergies=$score;
    }

    public function isAllergicTo(Allergen $allergen): bool
    {
        if ($this->score % $allergen == 0) return true;
        return false;
    }

    public function getList(): array
    {
        $al=[];
        $s=$this->score;
        $m=1;
        for($i=0;$i<=8;$i++) {
            if ($s % 2==1) array_push($al,$m);
            $m*=2;
        }
        return $al;
    }
}

class Allergen
{

    const EGGS = 1;
    const PEANUTS = 2;
    const SHELLFISH = 4;
    const STRAWBERRIES = 8;
    const TOMATOES = 16;
    const CHOCOLATE = 32;
    const POLLEN = 64;
    const CATS = 128;

    public static function allergenList(): array {
        $al=[];
        $m=1;
        for($i=0;$i<=8;$i++) {
            array_push($al,$m);
            $m*=2;
        }
        return $al;
    }
}

