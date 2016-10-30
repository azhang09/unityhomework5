using UnityEngine;
using System.Collections;

public class GUI : MonoBehaviour
{
    public Camera my_camera;
    
    // buttons and text
    public Button world_button;
    public Button heuristic_button;
    public Text world_text;
    public Text heuristic_text;
    public TextField start_x;
    public TextField start_y;
    public TextField finish_x;
    public TextField finish_y;
    
    // bools to track rep and heur
    private bool tile;
    private bool euclidean;
    
    void Start()
    {
    
    }
    
    void ToggleRepresentation()
    {
        if(tile)
        {
            world_text = "Waypoint";
            tile = false;
        }
        else
        {
            world_text = "Tile";
            tile = true;
        }
    }
    
    void ToggleHeuristic()
    {
        if(euclidean)
        {
            heuristic_text = "Manhattan";
            euclidean = false;
        }
        else
        {
            heuristic_text = "Euclidean";
            euclidean = true;
        }
    }
}