using System;
using UnityEngine;

public class DuckySpawnerScript : MonoBehaviour
{
    private float _timer;
    private float _timeInterval = 1000;

    public GameObject Ducky;
    public LogicScript gameManager;

    // Update is called once per frame
    void FixedUpdate()
    {
        int interval = (int)(_timeInterval / 100) * 100;

        if (GameObject.FindGameObjectsWithTag("Ducky").Length < 15 && _timer >= 5 &&
            ((int)(_timer * 1000)) % interval == 0)
        {
            Instantiate(Ducky, transform.position, transform.rotation);
        }

        if (GameObject.FindGameObjectsWithTag("Ducky").Length >= 15)
        {
            gameManager.gameOver();
        }

        //Spawn rate of the ducks
        _timer += Time.deltaTime;

        _timeInterval -= 0.1f;
        if (_timeInterval <= 250f)
        {
            _timeInterval = 250;
        }
    }
}