using Presentaion_Layer.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentaion_Layer.Presenters;
public abstract class BaseShowListPresenter<TModel, TServices>
{
    protected readonly IShowListView _showListView;
    protected readonly TServices _services;
    protected readonly Dictionary<string, Action> _searchHandlers;
    protected readonly BindingSource last = new();

    protected BaseShowListPresenter(IShowListView showListView, TServices services)
    {
        _showListView = showListView;
        _services = services;

        _searchHandlers = new Dictionary<string, Action>();
        InitializeSearchHandlers();

        Setup();
    }

    protected abstract void InitializeSearchHandlers();

    protected virtual void Setup()
    {
        _showListView.SearchBy = _searchHandlers.Keys.ToList();
        _showListView.SetListBindingSource(last);
        _showListView.Search += _showListView_Search;
    }

    private void _showListView_Search(object? sender, EventArgs e)
    {
        if (_searchHandlers.TryGetValue(_showListView.SearchByCategory, out var handler))
        {
            handler.Invoke();
        }
    }

    protected  void UpdateList(IEnumerable<TModel> items)
    {
        last.DataSource = new BindingList<TModel>(items.ToList());
        _showListView.SetListBindingSource(last);
    }
}
