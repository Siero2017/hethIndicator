using UnityEngine;
using System;

[Serializable]
public class Board
{
    private Sprite _image;
    private DateTime _creationTime;

    public Board(Sprite image, DateTime createTime)
    {
        _image = image;
        _creationTime = createTime;
    }

    public Sprite Image => _image;
    public DateTime CreationTime => _creationTime;
}
