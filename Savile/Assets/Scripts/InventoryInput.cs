using UnityEngine;

public class InventoryInput : MonoBehaviour
{
    [SerializeField] GameObject inventoryGameOject;
    [SerializeField] KeyCode[] toggleInventoryKeys;

    void Update()
    {
        for (int i = 0; i < toggleInventoryKeys.Length; i++)
        {
            if (Input.GetKeyDown(toggleInventoryKeys[i]))
            {
                inventoryGameOject.SetActive(!inventoryGameOject.activeSelf);
                break;
            }
        }    
    }
}
