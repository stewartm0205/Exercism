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

class Game
{
    private $frame=[];


    public function _contruct () {
        $this->score = 0;
        $this->roll = 0;
        $this->frame = 0;
        $this->last_frame_open=true;
    }
    public function score(): int
    {
        $score=0;
        if (count($this->frame)==0)throw new Exception();
        if (count($this->frame)<20)throw new Exception();
        if (count($this->frame)>21)throw new Exception();
        if (count($this->frame)==19 && $this->frame[19]==10)throw new Exception();
        if (count($this->frame)==20 && $this->frame[19]==10)throw new Exception();
       # if (count($this->frame)==21 && ($this->frame[19]+$this->frame[20])==10)throw new Exception();
        for($i=0;$i<20;$i+=2){
            if ($this->frame[$i]+$this->frame[$i+1]>10) throw new Exception();
            if ($this->frame[$i]==10) {
                $score+=$this->frame[$i]+$this->frame[$i+2];
                if ($this->frame[$i+2]==10){
                    $score+=$this->frame[$i+4];
                } else {
                    $score+=$this->frame[$i+3];
                }
            } elseif(($this->frame[$i]+$this->frame[$i+1])==10){
                $score+=$this->frame[$i]+$this->frame[$i+1]+$this->frame[$i+2];
            } else {
                $score+=$this->frame[$i]+$this->frame[$i+1];
            }
        }
        return $score;
    }

    public function roll(int $pins): void
    {
        if ($pins<0) throw new Exception();
        if ($pins>10) throw new Exception();
        array_push($this->frame, $pins);
        if ($pins==10) array_push($this->frame,null);
    }

}
