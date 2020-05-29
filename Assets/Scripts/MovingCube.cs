using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : MonoBehaviour
{
    public static MovingCube CurrentCube { get; private set; }
    public static MovingCube LastCube { get; private set; }

    [SerializeField]
    private float moveSpeed = 1f;

    private void OnEnable()
    {
        if (LastCube == null)
            LastCube = GameObject.Find("StartCube").GetComponent<MovingCube>();

        CurrentCube = this;
    }

    internal void Stop()
    {
        //moveSpeed = 0f;
        CurrentCube.enabled = false;

        float consequance = transform.position.z - LastCube.transform.position.z;

        SliceCubeOnZ(consequance);
    }

    private void SliceCubeOnZ(float hangover)
    {
        float newZSize = LastCube.transform.localScale.z - Mathf.Abs(hangover);

        float newZPosition = LastCube.transform.position.z + (hangover / 2);
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, newZSize);
        transform.position = new Vector3(transform.position.x, transform.position.y, newZPosition);
    }

    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * moveSpeed;
    }
}
