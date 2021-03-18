﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HamonicsDisplay : MonoBehaviour
{
    /*
     * ATTACH TO GAMEOBJECT WITH LINERENDERER AND ASSIGN LINERENDERER TO SCRIPT
     * TO ENABLE HIT MIDDLE MOUSE BUTTON
     * USE LEFT AND RIGHT MOUSE BUTTONS TO DISPLAY INPUT
     * 
    */

    public int numberOfSides = 4;
    public float polygonRadius = 2;
    public Vector3 polygonCenter;

    //private int angle = (2 * Mathf.PI) / 180.0f;

    public LineRenderer lr;

    public float detectRadius = 1f;
    public float width = 1f;

    private Vector2 mosPos;

    private bool harmonicsMode = false;

    void Start() 
    {
        if (!lr) 
        {
            if (gameObject.GetComponent<LineRenderer>() == null) 
            {
                gameObject.AddComponent<LineRenderer>();                
            }
            lr = gameObject.GetComponent<LineRenderer>();
            lr.loop = true;
        }

        detectRadius = polygonRadius;
    }

    void Update()
    {
        mosPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        lr.positionCount = numberOfSides;

        DrawPolygon(polygonCenter, polygonRadius, numberOfSides);

        if (Input.GetMouseButtonDown(2))
        {
            if (!harmonicsMode)
            {
                harmonicsMode = true;
            }
            else
            {
                harmonicsMode = false;
            }
        }

        if (harmonicsMode)
        {
            gameObject.GetComponent<LineRenderer>().enabled = true;
            if (Input.GetMouseButton(0) || Input.GetMouseButton(1))
            {
                DetectNoteInput();
            }
        }
        else 
        {
            gameObject.GetComponent<LineRenderer>().enabled = false;
        }
    }

    // Draw a polygon in the XY plane with a specfied position, number of sides
    // and radius.
    void DrawPolygon(Vector2 center, float radius, int numSides)
    {
        // The corner that is used to start the polygon (parallel to the X axis).
        Vector2 startCorner = transform.TransformPoint(new Vector2(radius, radius));

        var points = new Vector3[numSides];
        points[0] = startCorner;
        
        // For each corner after the starting corner...
        for (int i = 1; i < numSides; i++)
        {
            // Calculate the angle of the corner in radians.
            float cornerAngle = 2f * Mathf.PI / (float)numSides * i;

            // Get the X and Y coordinates of the corner point.
            float x = (Mathf.Cos(cornerAngle) - Mathf.Sin(cornerAngle));
            float y = (Mathf.Sin(cornerAngle) + Mathf.Cos(cornerAngle));
            Vector2 currentCorner = transform.TransformPoint(new Vector2(x * radius, y * radius));

            points[i] = currentCorner;
        }

        lr.SetPositions(points);

        lr.startWidth = width;
        lr.endWidth = width;
    }

    /// <summary>
    /// Detect input for each harmonic node
    /// </summary>
    void DetectNoteInput() 
    {
        for (int i = 0; i < lr.positionCount - 1; i++)
        {
            //Debug.DrawLine(lr.GetPosition(i), lr.GetPosition(i + 1), Color.red);

            if ((Vector2.Distance(lr.GetPosition(i), mosPos) + Vector2.Distance(lr.GetPosition(i + 1), mosPos))
                 <= Vector2.Distance(lr.GetPosition(i), lr.GetPosition(i + 1)) * detectRadius - width / 2.0f)
            {
                Debug.Log("We did hit Line: " + (i + 1));
            }
        }
        
        //Debug.DrawLine(lr.GetPosition(0), lr.GetPosition(3), Color.red);
        if ((Vector2.Distance(lr.GetPosition(0), mosPos) + Vector2.Distance(lr.GetPosition(lr.positionCount - 1), mosPos))
                <= Vector2.Distance(lr.GetPosition(0), lr.GetPosition(lr.positionCount - 1)) * detectRadius - width / 2.0f)
        {
            Debug.Log("We did Line: " + (lr.positionCount));
        }
        
    }
}
