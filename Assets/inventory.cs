using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour {

    private Dictionary<string, item> inventory_ = new Dictionary<string, item>();
    [SerializeField] private int _maxslots;
    private int _slots = 0;

    public int getAmoutOfItems(string key)
    {
        if (inventory_.ContainsKey(key))
        {
            return inventory_[key].AmoutOfItems;
        }
        return 0;
    }
    public void additem(string key, item Item, int amount)
    {
        if (inventory_.ContainsKey(key))
        {
            inventory_[key].AmoutOfItems = amount;
            return;
        }
        else if (_slots < _maxslots)
        {
            inventory_.Add(key, Item);
            inventory_[key].AmoutOfItems = amount;
            _slots++;
            //print("added item: " + key);
        }

    }
    public void removeitem(string key, int amount)
    {
        if (inventory_[key].AmoutOfItems - amount <= 0)
        {
            inventory_.Remove(key);
            _slots--;
            //print("no items left: "+ key);
            return;
        }

        inventory_[key].AmoutOfItems = -amount;
    }
    public void useitem(string key)
    {
        inventory_[key].Use();
    }
}
