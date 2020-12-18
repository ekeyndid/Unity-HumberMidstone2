using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAttack
{
 
    float Damage; //Damage of the attack
    float Accuracy; //Accuracy of the attack
    string Tag; //Tag of the attack, typically for defining
    int EffectPic; //Image of the attack
    bool IsMagic; //is it magical?
    int EffectType;// What effects doesnt this attack do? int from a list such as burning
    string Name;//Name of the attack

}
