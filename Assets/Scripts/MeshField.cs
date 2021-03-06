﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshCollider))]

public class MeshField : MonoBehaviour
{
    private MeshFilter meshFilter;

    public Point3 planeSize = new Point3(10, 1, 10);
    public float planeScale = 1f;

	// Use this for initialization
    void Start ()
    {
        meshFilter = GetComponent<MeshFilter>();
        Mesh mesh = MeshGenerator.GeneratePlane(planeSize, planeScale);
        //Obdob.loopThrough<Vector2>(mesh.uv);
        meshFilter.sharedMesh = mesh;
    }
	
	// Update is called once per frame
	void Update () {

	}
}
