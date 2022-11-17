using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameField : MonoBehaviour
{
    //public GameObject Cell;
    public Transform Position;
    public int Height, Width;
    private GrassBuilder Gbuild;
    private EarthBuilder Ebuild;
    private WaterBuilder Wbuild;
    private SandBuilder Sbuild;
    
    // Start is called before the first frame update
    void Start()
    {
        Gbuild = GameObject.Find("GrassScript").GetComponent<GrassBuilder>();
        Ebuild = GameObject.Find("EarthScript").GetComponent<EarthBuilder>();
        Wbuild = GameObject.Find("WaterScript").GetComponent<WaterBuilder>();
        Sbuild = GameObject.Find("SandScript").GetComponent<SandBuilder>();
        Generete();
    }
    void Generete()
    {
        int random;


        for(int i= 0; i < Width; i++)
        {
            for(int j = 0; j < Height; j++)
            {
                random = Random.Range(0, 4);
                switch (random)
                {
                    case 0:
                        {
                            Gbuild.PutCell(i, j, Position);
                            break;
                        }
                    case 1:
                        {
                            Ebuild.PutCell(i, j, Position);
                            break;
                        }
                    case 2:
                        {
                            Wbuild.PutCell(i, j, Position);
                            break;
                        }
                    case 3:
                        {
                            Sbuild.PutCell(i, j, Position);
                            break;
                        }
                }
               
            }
        }
    }
}
