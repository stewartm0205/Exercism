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

class Poker
{
    private $hands;
    public array $bestHands = [];

    public function __construct(array $hands)
    {
        $this->hands=$hands;
        $hs=array();
        for ($i=0;$i<=count($hands);$i++) {
            array_push($hs,Poker::score($hands[$i]));
        }
        $l=0;
        for ($i=0;$i<count($hs); $i++) {
            if ($hs[$i]>$l) $l=$hs[$i];
        }
        for ($i=0;$i<count($hs); $i++) {
            if ($hs[$i]=$l) array_push($bestHands,$hands[$i]);
        }
    }

    public function score($hand): int {
        $vc=Poker::value_count($hand);
        $sc=Poker::suit_count($hand);
        $v=array();
        for($i=0;$i<5;$i++) $v[$i]=substr($hand[$i],0,1);
        sort($v);
        

    }

    public function value_count($hand): array {
        $cc=array();
        foreach($hand as $c) {
            $h=substr($c,0,1);
            if (in_array($h,$cc)) $cc[$h]++;
            else $cc[$h]=1;
        }
        return $cc;
    }

    public function suit_count($hand): array {
        $sc=array();
        foreach($hand as $c) {
            $s=substr($c,1,1);
            if (in_array($s,$sc)) $sc[$s]++;
            else $sc[$s]=1;
        }
        return $sc;
    }

}
