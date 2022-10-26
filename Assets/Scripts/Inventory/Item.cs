﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {
    public int id;
    public string title;
    public string description;
    public Sprite icon;
    public Dictionary<string, int> stats = new Dictionary<string, int>();

    public Item(int id, string title, string description, Dictionary<string, int> stats)
    {
        this.id = id;
        this.title = title;
        this.description = description;
        /// <summary>
        /// Sets the path to where the item is 
        /// change the path to local path for where items are placed in project
        /// </summary>
        this.icon = Resources.Load<Sprite>("Sprites/Items/" + title); 
        this.stats = stats;
    }

    public Item(Item item)
    {
        this.id = item.id;
        this.title = item.title;
        this.description = item.description;
        this.icon = Resources.Load<Sprite>("Sprites/Items/" + item.title);
        this.stats = item.stats;
    }
}
