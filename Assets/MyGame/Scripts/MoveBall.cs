using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    [SerializeField]
    private GameObject[] ballPositions;

    private Vector3 posBallDefault;

    [SerializeField]
    private GameObject ball;

    int lastRandomIndex;

    private void Start()
    {
        posBallDefault = ball.transform.position;
    }

    public void ChangeBallPosition()
    {
        int index = GetDifferentRandomNumber();
        ball.transform.position = ballPositions[index].transform.position;
    }

    private int GetRandomNumber()
    {
        int index = Random.Range(0, 4);
        return index;
    }

    private int GetDifferentRandomNumber()
    {
        int newIndex;

        do
        {
            newIndex = Random.Range(0, 4);
        }
        while (newIndex == lastRandomIndex);

        lastRandomIndex = newIndex;

        return newIndex;
    }
}
