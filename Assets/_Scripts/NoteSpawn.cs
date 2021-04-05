﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawn : MonoBehaviour
{
    public HamonicsDisplay hd;
    public MouseOnInputNote[] mc;

    public GameObject[] spawnPositions;
    public GameObject[] notes;
    public List<GameObject> tempSpawnContainer = new List<GameObject>();

    public float incrementPosition = 0.0f;
<<<<<<< HEAD
<<<<<<< HEAD
//<<<<<<< Updated upstream
=======
>>>>>>> 73c82c150380afca1e09ea407fb0f5db9c0a92af
=======
<<<<<<< Updated upstream
>>>>>>> parent of 73c82c1... Revert "Hakeem's push"
    private float offset = 9.0f;

    public bool EndIsReached { get; set; } = false;

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
<<<<<<< HEAD
    }
//=======
=======
=======
>>>>>>> parent of 73c82c1... Revert "Hakeem's push"
    public bool endIsReached = false;

    // Start is called before the first frame update
    void Start()
    {        
<<<<<<< HEAD
//>>>>>>> Stashed changes
=======
>>>>>>> 73c82c150380afca1e09ea407fb0f5db9c0a92af
=======
>>>>>>> Stashed changes
>>>>>>> parent of 73c82c1... Revert "Hakeem's push"
        //Set notes in designated positions on music sheet
        for (int i = 0; i < notes.Length; i++)
        {
            notes[i].transform.position = spawnPositions[i].transform.position;
        }
    }

    // Update is called once per frame
    void Update()
<<<<<<< HEAD
<<<<<<< HEAD
//<<<<<<< Updated upstream
=======
>>>>>>> 73c82c150380afca1e09ea407fb0f5db9c0a92af
=======
<<<<<<< Updated upstream
>>>>>>> parent of 73c82c1... Revert "Hakeem's push"
    {
        //Playing a note will happen once when touched
        if (!mc[0].IsHit && mc[0].GetInputNoteName == "Up Button") 
        {
            mc[0].IsHit = true;
            noteSpawn(0);
        }
        else if (!mc[1].IsHit && mc[1].GetInputNoteName == "Right Button")
        {
            mc[1].IsHit = true;
            noteSpawn(1);
        }
        else if (!mc[2].IsHit && mc[2].GetInputNoteName == "Left Button")
        {
            mc[2].IsHit = true;
            noteSpawn(2);
        }
        else if (!mc[3].IsHit && mc[3].GetInputNoteName == "Down Button")
        {
            mc[3].IsHit = true;
<<<<<<< HEAD
<<<<<<< HEAD
//=======
=======
=======
>>>>>>> parent of 73c82c1... Revert "Hakeem's push"
    {        
        //Playing a note will happen once when touched
        if (!mc[0].isHit && mc[0].GetInputNoteName == "Up Note") 
        {
            mc[0].isHit = true;
            noteSpawn(0);
        }
        else if (!mc[1].isHit && mc[1].GetInputNoteName == "Right Note")
        {
            mc[1].isHit = true;
            noteSpawn(1);
        }
        else if (!mc[2].isHit && mc[2].GetInputNoteName == "Left Note")
        {
            mc[2].isHit = true;
            noteSpawn(2);
        }
        else if (!mc[3].isHit && mc[3].GetInputNoteName == "Down Note")
        {
            mc[3].isHit = true;
<<<<<<< HEAD
//>>>>>>> Stashed changes
=======
>>>>>>> 73c82c150380afca1e09ea407fb0f5db9c0a92af
=======
>>>>>>> Stashed changes
>>>>>>> parent of 73c82c1... Revert "Hakeem's push"
            noteSpawn(3);
        }
        
    }

    //How notes will be displayed in proper positions
    void noteSpawn(int i) 
    {
        tempSpawnContainer.Add(Instantiate(notes[i]));
        tempSpawnContainer[tempSpawnContainer.Count - 1].transform.position =
            new Vector3(tempSpawnContainer[tempSpawnContainer.Count - 1].transform.position.x + incrementPosition,
            tempSpawnContainer[tempSpawnContainer.Count - 1].transform.position.y);
<<<<<<< HEAD
<<<<<<< HEAD
//<<<<<<< Updated upstream
        if (!EndIsReached)
        {
            if (incrementPosition < transform.position.x + offset)
//=======
        if (!endIsReached)
        {
            if (incrementPosition < 8.0f)
//>>>>>>> Stashed changes
=======
        if (!EndIsReached)
        {
            if (incrementPosition < transform.position.x + offset)
>>>>>>> 73c82c150380afca1e09ea407fb0f5db9c0a92af
=======
<<<<<<< Updated upstream
        if (!EndIsReached)
        {
            if (incrementPosition < transform.position.x + offset)
=======
        if (!endIsReached)
        {
            if (incrementPosition < 8.0f)
>>>>>>> Stashed changes
>>>>>>> parent of 73c82c1... Revert "Hakeem's push"
            {
                incrementPosition += 1.0f;
            }
        }
    }

    //Once notes reach past the front of music sheet, they all move back to make room for incoming notes
    public void noteShift()
    {
        for (int i = 0; i < tempSpawnContainer.Count; i++) 
        {
            //tempSpawnContainer[i].transform.Translate(new Vector3(tempSpawnContainer[i].transform.position.x - 1.0f,
            //tempSpawnContainer[i].transform.position.y));
            tempSpawnContainer[i].transform.position = new Vector3(tempSpawnContainer[i].transform.position.x - 1.0f,
                tempSpawnContainer[i].transform.position.y);
        }
    }

    //Once a note reach the back end of the music sheet they disappear
<<<<<<< HEAD
<<<<<<< HEAD
//<<<<<<< Updated upstream
    public void Despawn()
//=======
    void despawn()
//>>>>>>> Stashed changes
=======
    public void Despawn()
>>>>>>> 73c82c150380afca1e09ea407fb0f5db9c0a92af
=======
<<<<<<< Updated upstream
    public void Despawn()
=======
    public void despawn()
>>>>>>> Stashed changes
>>>>>>> parent of 73c82c1... Revert "Hakeem's push"
    {
        Destroy(tempSpawnContainer[0]);
        tempSpawnContainer.RemoveAt(0);        
    }
<<<<<<< HEAD
<<<<<<< HEAD
//<<<<<<< Updated upstream
=======
>>>>>>> 73c82c150380afca1e09ea407fb0f5db9c0a92af
=======
<<<<<<< Updated upstream
>>>>>>> parent of 73c82c1... Revert "Hakeem's push"

    void NoteSpawnReset() 
    {
        for (int i = 0; i < tempSpawnContainer.Count; i++)
        {
            Destroy(tempSpawnContainer[i]);
        }

        tempSpawnContainer.Clear();

        EndIsReached = false;
        incrementPosition = 0;
    }
<<<<<<< HEAD
<<<<<<< HEAD
//=======
//>>>>>>> Stashed changes
=======
>>>>>>> 73c82c150380afca1e09ea407fb0f5db9c0a92af
=======
=======
>>>>>>> Stashed changes
>>>>>>> parent of 73c82c1... Revert "Hakeem's push"
}
