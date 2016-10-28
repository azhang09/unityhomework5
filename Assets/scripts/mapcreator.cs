using UnityEngine;
using System.Text.RegularExpressions;
using System.Collections;

public class mapcreator : MonoBehaviour
{
    public GameObject player;
    public GameObject floor_valid;
    public GameObject tree;
    public GameObject outofbounds;

    public const string sfloor_valid = ".";
    public const string stree = "T";
    public const string soutofbounds = "@";
    public const string sstart = "S";
    // Use this for initialization
    void Start()
    {
        string[][] jagged = readFile("arena2.map");

        // create planes based on matrix
        for (int y = 0; y < jagged.Length; y++)
        {
            for (int x = 0; x < jagged[0].Length; x++)
            {
                switch (jagged[y][x])
                {
                    case sstart:
                        Instantiate(floor_valid, new Vector3(x, 0, -y), Quaternion.identity);
                        Instantiate(player, new Vector3(0, 0.5f, 0), Quaternion.identity);
                        break;
                    case sfloor_valid:
                        Instantiate(floor_valid, new Vector3(x, 0, -y), Quaternion.identity);
                        break;
                    case stree:
                        Instantiate(tree, new Vector3(x, 0, -y), Quaternion.identity);
                        break;
                    case soutofbounds:
                        Instantiate(outofbounds, new Vector3(x, 0, -y), Quaternion.identity);
                        break;
                }
            }
        }
        Debug.Log("finished");

    }

    // Update is called once per frame
    void Update()
    {

    }

    string[][] readFile(string file)
    {
        string text = System.IO.File.ReadAllText(file);
        string[] lines = Regex.Split(text, "\r\n");
        int rows = lines.Length;

        string[][] levelBase = new string[rows][];
        for (int i = 0; i < lines.Length; i++)
        {
            string[] stringsOfLine = Regex.Split(lines[i], " ");
            levelBase[i] = stringsOfLine;
        }
        return levelBase;
    }



}
