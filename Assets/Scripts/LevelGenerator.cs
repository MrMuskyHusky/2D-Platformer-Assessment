using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    //pixel map of level
    public Texture2D mapTexture;
    //array (list) pixel and prefab mappings
    public PixelToObject[] pixelColorMappings;
    //current pixel color to map to compare to the mappings
    private Color pixelColor;

    private void Start()
    {
        GenerateLevel();
    }
    void GenerateLevel()
    {
        //Scan the whole texture and get the positions of objects
        for (int x = 0; x < mapTexture.width; x++)
        {
            for (int y = 0; y < mapTexture.height; y++)
            {
                GenerateObject(x, y);
            }
        }
    }
    void GenerateObject(int x, int y)
    {
        //Read pixel color
        pixelColor = mapTexture.GetPixel(x, y);
        if(pixelColor == Color.white)
        {
            //Do nothing
            return;
        }
        foreach(PixelToObject pixelColorMapping in pixelColorMappings)
        {
            //Scan pixelColorMappings array for matching color mapping
            if (pixelColorMapping.pixelColor.Equals(pixelColor))
            {
                Vector2 position = new Vector2(x, y);
                Instantiate(pixelColorMapping.prefab,position,Quaternion.identity, transform);
            }
        }
    }
}
