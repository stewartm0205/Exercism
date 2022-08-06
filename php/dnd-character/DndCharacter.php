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

class DndCharacter
{
    public $strength;
    public $dexterity;
    public $constitution;
    public $intelligence;
    public $wisdom;
    public $charisma;
    public $modifier;
    public $hitpoints;

    public function __construct()
    {
        $this->strength=DndCharacter::throw_dice();
        $this->dexterity=DndCharacter::throw_dice();
        $this->constitution=DndCharacter::throw_dice();
        $this->intelligence=DndCharacter::throw_dice();
        $this->wisdom=DndCharacter::throw_dice();
        $this->charisma=DndCharacter::throw_dice();
        $this->modifier=intdiv($this->constitution - 10, 2);
        $this->hitpoints=10+$this->modifier;

    }

    public function throw_dice() {
        $t=array();
        for ($i=0;$i<4;$i++){
            $t[$i]=rand(1,6);
        }
        rsort($t);
        return $t[0]+$t[1]+$t[2];
    }
}
