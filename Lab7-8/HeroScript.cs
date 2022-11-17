using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroScript : Unit, IObservable
{
    private bool flag = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovementLogic();
    }

    private void MovementLogic()
    {
        float moveVertical;
        float moveHorizontal;
        int dX = (int)this.transform.position.x;
        int dY = (int)this.transform.position.y;
        

        moveHorizontal = Input.GetAxis("Horizontal");

        moveVertical = Input.GetAxis("Vertical");

        if (moveHorizontal != 0)
        {
            if (flag)
            {
                dX += (int)Mathf.Sign(moveHorizontal);
                this.transform.position = new Vector3(dX, dY, 0);
            }
            flag = false;
        }
        else if (moveVertical != 0)
        {
            if (flag)
            {
                dY += (int)Mathf.Sign(moveVertical);
                this.transform.position = new Vector3(dX, dY, 0);
            }
            flag = false;
        }
        else
            flag = true;

    }

    public void RegisterObserver(IObserver o)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveObserver(IObserver o)
    {
        throw new System.NotImplementedException();
    }

    public void NotifyObservers()
    {
        throw new System.NotImplementedException();
    }
}
