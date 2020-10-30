﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

enum TileType
{
    Background,
    Normal,
    Platform
}

class Tile : SpriteGameObject
{
    protected TileType type;
    protected bool hot;
    protected bool ice;
    protected bool speed;
    protected bool slow;

    public Tile(string assetname = "", TileType tp = TileType.Background, int layer = 0, string id = "")
        : base(assetname, layer, id)
    {
        type = tp;
        hot = false;
        ice = false;
        speed = false;
        slow = false;
    }

    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
        if (type == TileType.Background)
        {
            return;
        }
        base.Draw(gameTime, spriteBatch);
    }

    public TileType TileType
    {
        get { return type; }
    }

    public bool Hot
    {
        get { return hot; }
        set { hot = value; }
    }

    public bool Ice
    {
        get { return ice; }
        set { ice = value; }
    }

    public bool Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public bool Slow
    {
        get { return slow; }
        set { slow = value; }
    }
}
