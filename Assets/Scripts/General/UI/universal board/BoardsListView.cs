using System;
using System.Collections.Generic;
using UnityEngine;

public class BoardsListView : MonoBehaviour
{
    [SerializeField] private BoardView _template;
    [SerializeField] private Transform _container;

    [SerializeField] private Sprite _defaultSprite;  
    [SerializeField] private Transform _dragingParent;  

    private void Awake()
    {
        Render(new List<Board>()
        {
            new Board(_defaultSprite, DateTime.Now),
            new Board(_defaultSprite, DateTime.Now),
            new Board(_defaultSprite, DateTime.Now),
            new Board(_defaultSprite, DateTime.Now)
        });
    }

    private void Render(IEnumerable<Board> boards)
    {
        foreach(var board in boards)
        {
            var view = Instantiate(_template, _container) as BoardView;
            view.Init(_dragingParent);
            view.Render(board);
        }
    }
}
