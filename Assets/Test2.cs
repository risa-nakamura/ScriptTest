using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }

    public void Magic()
    {


        //for(;mp>0;mp-=5){
        if (mp>=5)
        { 
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);

        }
        else//if(mp<0)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }


       
    }

}




public class Test2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Boss lastboss = new Boss();

        lastboss.Attack();

        lastboss.Defence(3);
        
        for (int Magic=0;Magic<13;++Magic) {

            lastboss.Magic();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
