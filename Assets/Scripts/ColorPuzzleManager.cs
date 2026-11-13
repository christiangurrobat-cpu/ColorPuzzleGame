
using UnityEngine;
using UnityEngine.UI;

public class ColorPuzzleManager : MonoBehaviour
{
    [Header("Grid Settings")]
    public int rows = 6;
    public int columns = 6;

    [Header("Tile Prefab")]
    public GameObject tilePrefab;

    [Header("Available Colors")]
    public Color[] tileColors =
    {
        Color.red,
        Color.blue,
        Color.green,
        Color.yellow,
        new Color(0.6f, 0.2f, 0.9f)
    };

    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        if (tilePrefab == null)
        {
            Debug.LogError("Please assign the Tile Prefab!");
            return;
        }

        for (int i = 0; i < rows * columns; i++)
        {
            GameObject newTile = Instantiate(
                tilePrefab,
                transform
            );

            Image tileImage = newTile.GetComponent<Image>();

            if (tileImage != null)
            {
                int randomIndex = Random.Range(
                    0,
                    tileColors.Length
                );

                tileImage.color = tileColors[randomIndex];
            }
        }

        Debug.Log("36 Tiles Generated!");
    }
}
