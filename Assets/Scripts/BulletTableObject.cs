using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New BulletData", menuName = "Bullet Data", order = 51)]
public class BulletTableObject : ScriptableObject
{
    [SerializeField]
    private string bulletName;
    [SerializeField]
    private int damage;
    [SerializeField]
    private Texture icon;
    [SerializeField]
    private int speed;




    public string BulletName
    {
        get
        {
            return bulletName;
        }
    }

    public int Damage
    {
        get
        {
            return damage;
        }
    }

    public Texture Icon
    {
        get
        {
            return icon;
        }
    }

    public int Speed
    {
        get
        {
            return speed;
        }
    }
}
