using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CharacterBase : MonoBehaviour
{
    float CurrHP;
    float MaxHP;
    float CurrMP;
    float MaxMP;
    int Speed;
    float Evasion;
	int DiceRoll;
	float Defence;
    string Tag;

	void TakeDmg(int value) { CurrHP -= value; } //take damage
	void SetHP(int value1, int value2) { CurrHP = value1; CurrMP = value2; }//set current hp to float set current mp to float
	int ReturnSpeedRoll()
	{
        DiceRoll = Random.Range(0, 20) + Speed;
        return DiceRoll;
    }










	

}
