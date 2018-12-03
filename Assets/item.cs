using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item: MonoBehaviour {

    [SerializeField] private int _maxAmountOfItems;
    private int _amoutOfItems = 0;
    public int AmoutOfItems
    {
        get
        {
            return _amoutOfItems;
        }
        set
        {
            if (_amoutOfItems + value > _maxAmountOfItems)
            {
                Drop((value + _amoutOfItems) - _maxAmountOfItems);
                _amoutOfItems = _maxAmountOfItems;
                print(_maxAmountOfItems);
                return;
            }
            _amoutOfItems += value;
            print(_amoutOfItems);
        }
    }

    public abstract void Use();
    public abstract void Drop(int amount);
}
