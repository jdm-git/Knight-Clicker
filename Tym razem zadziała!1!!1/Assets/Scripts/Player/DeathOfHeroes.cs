using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

//Na razie nie jest używane

public class DeathOfHeroes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //  private Timer _timer = new Timer()

        //  Task.Delay(1000).ContinueWith( t => koniec() );
        //    System.Threading.Thread.Sleep(1000);
        koniec();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void koniec()
    {
        var Coin = new CoinPop();
        Destroy(this.gameObject);

    }

}
